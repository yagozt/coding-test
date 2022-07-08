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
            DirectionEnum newDirectionEnum;
            if (!Enum.TryParse<DirectionEnum>(newDirection.ToString(), out newDirectionEnum)) throw new ArgumentException("Invalid direction", nameof(newDirection));
            ChangeDirection(newDirectionEnum);
        }

        private void ChangeDirection(DirectionEnum newDirection)
        {
            if (newDirection == DirectionEnum.L)
                Position.TurnLeft();
            else
                Position.TurnRight();
        }

        public override string ToString()
        {
            return $"{Position.X} {Position.Y} {Position.Direction}";
        }
    }
}