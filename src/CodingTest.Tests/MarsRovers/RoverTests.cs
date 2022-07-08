using CodingTest.MarsRovers;
using Xunit;

namespace CodingTest.Tests.MarsRovers
{
    public class RoverTests
    {
        [Fact]
        public void Rover_NewRover()
        {
            var rover = new Rover(3, 3, 'N');

            PositionTests.AssertPosition(3, 3, "N", rover.Position);
            Assert.Equal("3 3 N", rover.ToString());
        }

        [Fact]
        public void Rover_Move_ChangePosition()
        {
            var rover = new Rover(3, 3, 'N');
            rover.Move();

            PositionTests.AssertPosition(3, 4, "N", rover.Position);
            Assert.Equal("3 4 N", rover.ToString());
        }

        [Fact]
        public void Rover_ChangeDirection_ChangeToAnotherPosition()
        {
            var rover = new Rover(3, 3, 'N');
            rover.ChangeDirection('L');
            rover.Move();
            PositionTests.AssertPosition(2, 3, "W", rover.Position);
            rover.ChangeDirection('R');
            rover.Move();
            PositionTests.AssertPosition(2, 4, "N", rover.Position);

            Assert.Equal("2 4 N", rover.ToString());
        }

        [Fact]
        public void Rover_ChangeToInvalidDirection_ShouldThrowException()
        {
            var rover = new Rover(3, 3, 'N');
            var exception = Assert.Throws<ArgumentException>(() => rover.ChangeDirection('T'));

            Assert.Contains("Invalid direction", exception.Message);
        }
    }
}
