using CodingTest.MarsRovers;
using Xunit;

namespace CodingTest.Tests.MarsRovers
{
    public class MapTests
    {
        [Fact]
        public void Map_NewMap_ShouldHaveRowsAndColumns()
        {
            var map = new Map(5, 5);

            Assert.Equal(5, map.Columns);
            Assert.Equal(5, map.Rows);
        }

        [Fact]
        public void Map_AddRover_ShouldReturnRover()
        {
            var map = new Map(5, 5);

            var rover = new Rover(3, 3, 'N');
            map.AddRover(rover);

            PositionTests.AssertPosition(3, 3, "N", map.Rover.Position);
        }

        [Fact]
        public void Map_ProcessMoves_ShouldRoverChangePosition()
        {
            var map = new Map(5, 5);

            var rover = new Rover(1, 2, 'N');
            map.AddRover(rover);

            map.ProcessMoves("LMLMLMLMM".ToArray());

            PositionTests.AssertPosition(1, 3, "N", map.Rover.Position);
        }
    }
}
