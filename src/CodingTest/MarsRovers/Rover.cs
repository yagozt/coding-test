namespace CodingTest.MarsRovers
{
    public class Rover
    {
        public Rover(int x, int y, char z)
        {
            Position = new Position(x, y, z);
        }

        public Position Position { get; set; }

        public void Move()
        {
            Position.Move();
        }

        public void ChangeDirection(char newDirection)
        {
            ChangeDirection(Enum.Parse<DirectionEnum>(newDirection.ToString()));
        }

        public void ChangeDirection(DirectionEnum newDirection)
        {
            if(newDirection == DirectionEnum.L)
                Position.TurnLeft();
            else if(newDirection == DirectionEnum.R)
                Position.TurnRight();
            else
                throw new ArgumentException("");
        }

        public override string ToString()
        {
            return $"{Position.X} {Position.Y} {Position.Direction}";
        }
    }
}