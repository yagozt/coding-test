using CodingTest.MarsRovers;
using Xunit;

namespace CodingTest.Tests.MarsRovers
{
    public class PositionTests
    {
        [Fact]
        public void Position_NewPosition()
        {
            var position = new Position(3, 3, 'N');

            AssertPosition(3, 3, "N", position);
        }

        [Fact]
        public void Position_MoveToNorth_ShouldMoveOnePositionY()
        {
            var position = new Position(3, 3, 'N');
            position.Move();
            AssertPosition(3, 4, "N", position);
        }

        [Fact]
        public void Position_ChangeDirectionAndMove_ShouldMoveOnePosition()
        {
            var position = new Position(3, 3, 'N');
            position.TurnRight();
            position.Move();
            AssertPosition(4, 3, "E", position);
            position.TurnLeft();
            position.Move();
            AssertPosition(4, 4, "N", position);
        }


        public static void AssertPosition(int x, int y, string direction, Position position)
        {
            Assert.Equal(x, position.X);
            Assert.Equal(y, position.Y);
            Assert.Equal(direction, position.Direction.ToString());
        }
    }
}
