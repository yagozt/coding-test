namespace CodingTest.MarsRovers
{
    public class Map
    {
        public Map()
        {
            Rows = 0;
            Columns = 0;
        }
        public void AddRover(Rover rover) => Rover = rover;

        public Map(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public int Rows { get; set; }
        public int Columns { get; set; }
        public Rover Rover { get; set; }

        public void ProcessMoves(char[]? chars)
        {
            if(chars == null) throw new ArgumentException("wrong input");
            foreach (var letter in chars)
            {
                if(letter == 'L' || letter == 'R')
                    Rover.ChangeDirection(letter);
                else if (letter == 'M')
                    Rover.Move();
                else
                    throw new ArgumentException("wrong input");
            }
        }
    }
}