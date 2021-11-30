using Decorator.Pattern;

namespace Decorator.Implementation
{
    public class Milk : Condiment
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override float Cost()
        {
            return 0.2f + _beverage.Cost();
        }

        public override string Description()
        {
            return $"{_beverage.Description()} with Milk";
        }
    }

    public class Mocha : Condiment
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override float Cost()
        {
            return 0.3f + _beverage.Cost();
        }

        public override string Description()
        {
            return $"{_beverage.Description()} with Mocha";
        }
    }

    public class Soy : Condiment
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override float Cost()
        {
            return 0.5f + _beverage.Cost();
        }

        public override string Description()
        {
            return $"{_beverage.Description()} with Soy";
        }
    }
}
