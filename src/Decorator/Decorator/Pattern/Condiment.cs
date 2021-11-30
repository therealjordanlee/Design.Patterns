namespace Decorator.Pattern
{
    public abstract class Condiment : Beverage
    {
        internal Beverage _beverage;
        public Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}
