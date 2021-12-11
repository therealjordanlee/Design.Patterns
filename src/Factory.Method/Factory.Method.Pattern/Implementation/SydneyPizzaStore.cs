using Factory.Method.Pattern.Pattern;

namespace Factory.Method.Pattern.Implementation
{
    public class SydneyPizzaStore : PizzaCreator
    {
        protected override PizzaProduct CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new SydneyCheesePizza();
                case PizzaType.Ham:
                    return new SydneyHamPizza();
            }

            throw new ArgumentException();
        }
    }
}
