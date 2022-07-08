using CodingTest.MarsRovers;

namespace CodingTest;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Input: ");
        var problem = new SalesTaxes.SalesTaxesProblem();
        string input = string.Empty;
        do
        {
            input = Console.ReadLine() ?? "Q";
            
            problem.Proccess(input);
        } while (input != "Q");
    }
}
