using System.Globalization;

namespace ExPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct () { }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name} $ {(Price + CustomsFee).ToString("F2", CultureInfo.InvariantCulture)} " +
                   $"(Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
