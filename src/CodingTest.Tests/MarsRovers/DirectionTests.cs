using CodingTest.MarsRovers;
using Xunit;

namespace CodingTest.Tests.MarsRovers
{
    public class DirectionTests
    {
        [Fact]
        public void Direction_NewDirection()
        {
            var direction = new Direction('N');
            Assert.Equal(1, direction.Y);
            Assert.Equal(0, direction.X);
            Assert.True(direction.IsNorth);
        }

        [Fact]
        public void Direction_ChangeDirectionToRight_ShouldUpdateToRightDirection()
        {
            var direction = new Direction('N');
            direction.ChangeDirection(DirectionEnum.R);
            Assert.Equal(0, direction.Y);
            Assert.Equal(1, direction.X);
            Assert.True(direction.IsEast);

            direction.ChangeDirection(DirectionEnum.R);
            Assert.Equal(-1, direction.Y);
            Assert.Equal(0, direction.X);
            Assert.True(direction.IsSoulth);

            direction.ChangeDirection(DirectionEnum.R);
            Assert.Equal(0, direction.Y);
            Assert.Equal(-1, direction.X);
            Assert.True(direction.IsWest);

            direction.ChangeDirection(DirectionEnum.R);
            Assert.Equal(1, direction.Y);
            Assert.Equal(0, direction.X);
            Assert.True(direction.IsNorth);
        }

        [Fact]
        public void Direction_ChangeDirectionToLeft_ShouldUpdateToLeftDirection()
        {
            var direction = new Direction('N');
            direction.ChangeDirection(DirectionEnum.L);
            Assert.Equal(0, direction.Y);
            Assert.Equal(-1, direction.X);
            Assert.True(direction.IsWest);

            direction.ChangeDirection(DirectionEnum.L);
            Assert.Equal(-1, direction.Y);
            Assert.Equal(0, direction.X);
            Assert.True(direction.IsSoulth);

            direction.ChangeDirection(DirectionEnum.L);
            Assert.Equal(0, direction.Y);
            Assert.Equal(1, direction.X);
            Assert.True(direction.IsEast);

            direction.ChangeDirection(DirectionEnum.L);
            Assert.Equal(1, direction.Y);
            Assert.Equal(0, direction.X);
            Assert.True(direction.IsNorth);
        }

        [Fact]
        public void Direction_ShouldThrownException_WhenInvalidDirection()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Direction('A'));

            Assert.Contains("Invalid direction", exception.Message);
        }
    }
}
