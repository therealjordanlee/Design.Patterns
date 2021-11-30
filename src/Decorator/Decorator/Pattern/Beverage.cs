namespace Decorator.Pattern
{
    public abstract class Beverage : IProduct
    {
        public abstract string Description();
        public abstract float Cost();
    }
}
