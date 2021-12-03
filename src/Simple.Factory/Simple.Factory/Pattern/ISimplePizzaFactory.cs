using Simple.Factory.Implementation;

namespace Simple.Factory.Pattern
{
    public interface ISimplePizzaFactory
    {
        Pizza Create(PizzaType pizzaType);
    }
}