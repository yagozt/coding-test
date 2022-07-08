namespace CodingTest.SalesTaxes
{
    public class Item
    {
        public int Quantity { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public decimal UnitPrice { get { return finalPrice; } }
        public decimal FinalPrice { get { return finalPrice * Quantity; } }
        public decimal Tax { get { return tax * Quantity; } }

        private decimal tax;
        private decimal finalPrice;
        private bool isImported;

        public Item(int quantity, string itemName, decimal price, bool isImported)
        {
            this.Quantity = quantity;
            this.Name = itemName;
            this.Price = price;
            this.isImported = isImported;
            ApplyTax();
        }

        public void UpdateQuantity(int quantity = 1)
        {
            Quantity += quantity;
        }

        private void ApplyTax()
        {
            if (isImported)
            {
                tax = decimal.Round(Price * 0.05m, 1);
                tax += ApplyBasicTax();
                finalPrice = tax + Price;
            }
            else
            {
                tax = ApplyBasicTax();
                finalPrice = tax + Price;
            }
        }

        private decimal ApplyBasicTax()
        {
            var name = Name.Trim().ToLower();
            if (!(name.Contains("book") || name.Contains("chocolate") || name.Contains("pills")))
            {
                return decimal.Round(Price * 0.1m, 2);
            }
            return 0m;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var item = (Item)obj;
            return item.Name == Name;
        }
    }
}