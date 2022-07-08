using CodingTest.MarsRovers;
using Xunit;

namespace CodingTest.Tests.MarsRovers
{
    public class MarsRoverProblemTests
    {
        [Fact]
        public void MarsRoverProblem_ProcessOneRover_ShouldReturnPosition()
        {
            var problem = new MarsRoverProblem();
            problem.Proccess("5 5");
            problem.Proccess("1 2 N");
            problem.Proccess("LMLMLMLMM");
            Assert.Equal("1 3 N", problem.Proccess());
        }

        [Fact]
        public void MarsRoverProblem_ProcessMoreRovers_ShouldReturnPosition()
        {
            var problem = new MarsRoverProblem();
            problem.Proccess("5 5");
            problem.Proccess("1 2 N");
            problem.Proccess("LMLMLMLMM");
            Assert.Equal("1 3 N", problem.Proccess());

            problem.Proccess("3 3 E");
            problem.Proccess("MMRMMRMRRM");
            Assert.Equal("5 1 E", problem.Proccess());
        }

        [Fact]
        public void MarsRoverProblem_ProcessInvalidMovement_ShouldThrownException()
        {
            var problem = new MarsRoverProblem();
            problem.Proccess("5 5");
            problem.Proccess("1 2 N");
            var exception = Assert.Throws<ArgumentException>(() => problem.Proccess("LNLMLMLMM"));

            Assert.Contains("wrong input", exception.Message);
        }

        [Fact]
        public void MarsRoverProblem_CreateRoversWithoutNap_ShouldThrownException()
        {
            var problem = new MarsRoverProblem();
            var exception = Assert.Throws<InvalidOperationException>(() => problem.Proccess("1 2 N"));

            Assert.Contains("Map is not yet created", exception.Message);
        }

        [Fact]
        public void MarsRoverProblem_MoveRoversWithoutMap_ShouldThrownException()
        {
            var problem = new MarsRoverProblem();
            var exception = Assert.Throws<InvalidOperationException>(() => problem.Proccess("LMLMLMLMM"));

            Assert.Contains("Map is not yet created", exception.Message);
        }

        [Fact]
        public void MarsRoverProblem_MoveRoversWithoutRover_ShouldThrownException()
        {
            var problem = new MarsRoverProblem();
            problem.Proccess("5 5");
            var exception = Assert.Throws<InvalidOperationException>(() => problem.Proccess("LMLMLMLMM"));

            Assert.Contains("Rover is not yet created", exception.Message);
        }

        [Fact]
        public void MarsRoverProblem_ProcessOneRoverOverMap_ShouldThrownExcpetion()
        {
            var problem = new MarsRoverProblem();
            problem.Proccess("5 5");
            problem.Proccess("1 2 N");
            var exception = Assert.Throws<InvalidOperationException>(() =>problem.Proccess("RMMMMMMM"));

            Assert.Contains("Rover went over the map", exception.Message);
        }
    }
}
