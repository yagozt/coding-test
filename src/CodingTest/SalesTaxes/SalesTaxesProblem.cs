namespace CodingTest.SalesTaxes
{
    public class SalesTaxesProblem
    {
        public Basket Basket = new Basket();
        public void Proccess(string input)
        {
            Console.WriteLine("Write the item to add, leave empty to show the receipt or press R to reset the basket.");
            if(input != string.Empty)
            {
                if(input.Equals("R"))
                    Basket.Reset();
                else
                    Basket.AddItem(input);
            }
            else
                Console.WriteLine(Basket);
        }
    }
}