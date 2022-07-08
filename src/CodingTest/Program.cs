namespace CodingTest;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Q to exist");
        Console.WriteLine("Test Input: ");
        var problem = new MarsRovers.MarsRoverProblem();
        string input = Console.ReadLine() ?? string.Empty;

        do
        {
            Console.WriteLine(problem.Proccess(input));
            input = Console.ReadLine() ?? "q";
            
        } while (input.ToLower() != "q");
    }
}
