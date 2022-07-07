namespace CodingTest.MarsRovers
{
    public class Direction
    {
        public Direction(char z)
        {
            if (z == 'N')
                ChangeToNorth();
            else if (z == 'S')
                ChangeToSoulth();
            else if (z == 'W')
                ChangeToWest();
            else if (z == 'E')
                ChangeToEast();
            else
                throw new ArgumentException("");

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