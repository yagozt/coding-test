namespace CodingTest.MarsRovers
{
    public class MarsRoverProblem
    {
        private Map Map;
        public void Proccess(string input)
        {
            if (input?.Length == 3)
            {
                var gridSize = input.Split();
                Map = new Map(Convert.ToInt32(gridSize[0]), Convert.ToInt32(gridSize[1]));
            }
            else if (input?.Length == 5)
            {
                var roverPosition = input.Split();
                var rover = new Rover(Convert.ToInt32(roverPosition[0]), Convert.ToInt32(roverPosition[1]), roverPosition[2][0]);
                Map.AddRover(rover);
            }
            else if(input != "Q")
            {
                Map.ProcessMoves(input?.ToArray());
                Console.WriteLine(Map.Rover);
            }
        }
    }
}