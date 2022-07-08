namespace CodingTest.MarsRovers
{
    public class Map
    {
        public void AddRover(Rover rover) => Rover = rover;

        public Map(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public int Rows { get; set; }
        public int Columns { get; set; }
        public Rover? Rover { get; set; }

        public void ProcessMoves(char[]? chars)
        {
            if(chars == null) throw new ArgumentException("wrong input");
            if (Rover == null) throw new InvalidOperationException("Rover is not yet created");
            foreach (var letter in chars)
            {
                if (letter == 'L' || letter == 'R')
                    Rover.ChangeDirection(letter);
                else if (letter == 'M')
                {
                    Rover.Move();
                    if(Rover.Position.X < 0 || Rover.Position.X > Columns ||
                        Rover.Position.Y > Rows || Rover.Position.Y < 0)
                        throw new InvalidOperationException("Rover went over the map");

                }
                else
                    throw new ArgumentException("wrong input");
            }
        }
    }
}