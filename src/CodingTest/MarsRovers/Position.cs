namespace CodingTest.MarsRovers
{
    public class Position
    {
        public Position(int x, int y, char z)
        {
            X = x;
            Y = y;
            Direction = new Direction(z);
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {
            var newPosition = Direction.Move(X, Y);
            X = newPosition.Item1;
            Y = newPosition.Item2;
        }

        public Direction Direction { get; set; }

        public void TurnLeft()
        {
            Direction.ChangeDirection(DirectionEnum.L);
        }

        public void TurnRight()
        {
            Direction.ChangeDirection(DirectionEnum.R);
        }
    }
}