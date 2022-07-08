namespace CodingTest;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Q to exist");
        Console.WriteLine("Test Input: ");
        var problem = new MarsRovers.MarsRoverProblem();
        string input = Console.ReadLine() ?? string.Empty;
        string exitKey = "q";

        do
        {
            Console.WriteLine(problem.Proccess(input, exitKey));
            input = Console.ReadLine() ?? exitKey;
            
        } while (input.ToLower() != exitKey);
    }
}
