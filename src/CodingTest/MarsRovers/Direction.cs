namespace CodingTest.MarsRovers
{
    public class Direction
    {
        public Direction(char direction)
        {
            if (direction == 'N')
                ChangeToNorth();
            else if (direction == 'S')
                ChangeToSoulth();
            else if (direction == 'W')
                ChangeToWest();
            else if (direction == 'E')
                ChangeToEast();
            else
                throw new ArgumentException("Invalid direction", nameof(direction));

        }

        public int X { get; set; }
        public int Y { get; set; }
        public bool IsNorth => X == 0 && Y == 1;
        public bool IsSoulth => X == 0 && Y == -1;
        public bool IsWest => X == -1 && Y == 0;
        public bool IsEast => X == 1 && Y == 0;

        public (int, int) Move(int x, int y)
        {
            return (x + X, y + Y);
        }

        public void ChangeDirection(DirectionEnum direction)
        {
            if (IsNorth)
                if (direction == DirectionEnum.R)
                {
                    ChangeToEast();
                }
                else
                {
                    ChangeToWest();
                }
            else if (IsSoulth)
                if (direction == DirectionEnum.R)
                {
                    ChangeToWest();
                }
                else
                {
                    ChangeToEast();
                }
            else if (IsWest)
                if (direction == DirectionEnum.R)
                {
                    ChangeToNorth();
                }
                else
                {
                    ChangeToSoulth();
                }
            else
                if (direction == DirectionEnum.R)
                {
                    ChangeToSoulth();
                }
                else
                {
                    ChangeToNorth();
                }
        }

        public override string ToString()
        {
            if (IsNorth)
                return "N";
            else if (IsSoulth)
                return "S";
            else if (IsWest)
                return "W";
            else
                return "E";
        }

        private void ChangeToNorth()
        {
            X = 0;
            Y = 1;
        }

        private void ChangeToSoulth()
        {
            X = 0;
            Y = -1;
        }
        private void ChangeToWest()
        {
            X = -1;
            Y = 0;
        }
        private void ChangeToEast()
        {
            X = 1;
            Y = 0;
        }
    }

    public enum DirectionEnum
    {
        L,
        R
    }
}