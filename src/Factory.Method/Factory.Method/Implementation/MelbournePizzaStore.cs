using Factory.Method.Pattern;

namespace Factory.Method.Implementation
{
    public class MelbournePizzaStore : PizzaCreator
    {
        protected override PizzaProduct CreatePizza(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    return new MelbourneCheesePizza();
                case PizzaType.Ham:
                    return new MelbourneHamPizza();
            }

            throw new ArgumentException();
        }
    }
}
