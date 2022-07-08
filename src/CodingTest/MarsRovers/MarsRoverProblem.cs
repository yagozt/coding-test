namespace CodingTest.MarsRovers
{
    public class MarsRoverProblem
    {
        private Map? Map;
        public string Proccess(string? input = "")
        {
            if (input?.Split().Length == 2)
            {
                var gridSize = input.Split();
                Map = new Map(Convert.ToInt32(gridSize[0]), Convert.ToInt32(gridSize[1]));
            }
            else if (input?.Split().Length == 3)
            {
                var roverPosition = input.Split();
                var rover = new Rover(Convert.ToInt32(roverPosition[0]), Convert.ToInt32(roverPosition[1]), roverPosition[2][0]);
                if (Map == null) throw new InvalidOperationException("Map is not yet created");
                Map.AddRover(rover);
            }
            else if (input != "Q")
            {
                if (Map == null) throw new InvalidOperationException("Map is not yet created");
                Map.ProcessMoves(input?.ToArray());
                return Map.Rover.ToString();
            }
            return string.Empty;
        }
    }
}