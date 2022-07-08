using System.Globalization;
using System.Text;

namespace CodingTest.SalesTaxes
{
    public class Basket
    {
        private decimal total => GetTotal();
        private decimal salesTaxes => GetTotalTaxes();

        private decimal GetTotal()
        {
            return Itens.Sum(s => s.FinalPrice);
        }

        private decimal GetTotalTaxes()
        {
            return Itens.Sum(s => s.Tax);
        }

        public void Reset()
        {
            Itens.Clear();
        }

        public Basket()
        {
            Itens = new List<Item>();
        }

        public void AddItem(string input)
        {
            var inputWords = input.Split();
            var quantity = int.Parse(inputWords[0]);
            var price = decimal.Parse(inputWords.Last().ToString(), CultureInfo.InvariantCulture);
            var isImported = input.Contains("Imported");
            var name = GetName(input);
            AddItem(quantity, name, price, isImported);
        }



        public void AddItem(int quantity, string itemName, decimal price, bool isImported)
        {
            var newItem = new Item(quantity, itemName, price, isImported);
            var itemRegistrated = Itens.Any(f => f.Equals(newItem));
            if (itemRegistrated) Itens.First(f => f.Equals(newItem)).UpdateQuantity(quantity);
            else
                Itens.Add(new Item(quantity, itemName, price, isImported));
        }

        public IList<Item> Itens { get; set; }

        private string GetName(string input)
        {
            var name = new StringBuilder();
            var price = input.Last().ToString();
            var words = input.Split();
            for (int i = 1; i < words.Length - 1; i++)
            {
                if (words[i] == "at") continue;
                name.Append($" {words[i]}");
            }
            return name.ToString().Trim();
        }

        public override string ToString()
        {
            var receipt = new StringBuilder();
            foreach (var item in Itens)
            {
                var quantity = item.Quantity > 1 ? $" ({item.Quantity} @ {item.UnitPrice})" : string.Empty;
                receipt.AppendLine($"{item.Name}: {item.FinalPrice}{quantity}");
            }
            receipt.AppendLine($"Sales Taxes: {salesTaxes}");
            receipt.AppendLine($"Total: {total}");
            return receipt.ToString(); ;
        }
    }
}