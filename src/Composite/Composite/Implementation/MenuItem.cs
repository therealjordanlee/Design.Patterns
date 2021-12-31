using Composite.Pattern;

namespace Composite.Implementation
{
    /// <summary>
    /// MenuItem represents a leaf node.
    /// </summary>
    public class MenuItem : AbstractMenuComponent
    {
        private string _name;
        private string _description;
        private double _price;

        public MenuItem(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override void Print()
        {
            Console.WriteLine($"{_name}: {_description}\t{_price}");
        }
    }
}
