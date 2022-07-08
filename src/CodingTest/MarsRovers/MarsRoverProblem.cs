namespace CodingTest.MarsRovers
{
    public class MarsRoverProblem
    {
        private Map? Map;
        private string Input = string.Empty;
        private bool AddingMap => Input.Split().Length == 2;
        private bool AddingRover => Input.Split().Length == 3;

        public string Proccess(string input = "", string exitKey = "Q")
        {
            Input = input;
            if (AddingMap)
            {
                var gridSize = Input.Split();
                Map = new Map(Convert.ToInt32(gridSize[0]), Convert.ToInt32(gridSize[1]));
            }
            else if (AddingRover)
            {
                var roverPosition = Input.Split();
                var rover = new Rover(Convert.ToInt32(roverPosition[0]), Convert.ToInt32(roverPosition[1]), roverPosition[2][0]);
                if (Map == null) throw new InvalidOperationException("Map is not yet created");
                Map.AddRover(rover);
            }
            else if (!exitKey.Equals(Input))
            {
                if (Map == null) throw new InvalidOperationException("Map is not yet created");
                Map.ProcessMoves(Input?.ToArray());
                return Map.Rover.ToString();
            }
            return string.Empty;
        }

    }
}