using Simple.Factory.Pattern;

namespace Simple.Factory.Implementation
{
    public class SimplePizzaFactory : ISimplePizzaFactory
    {
        public Pizza Create(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
            }
            throw new NotImplementedException();
        }
    }
}
