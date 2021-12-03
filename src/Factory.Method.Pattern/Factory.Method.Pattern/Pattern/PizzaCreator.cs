namespace Factory.Method.Pattern.Pattern
{
    public abstract class PizzaCreator
    {
        public void OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Cook();
        }

        /// <summary>
        /// This is the factory method.
        /// A factory method handles object creation and encapsulates it in a subclass.
        /// This decouples clients from products.
        /// </summary>
        /// <param name="pizzaType"></param>
        /// <returns><see cref="PizzaProduct"/></returns>
        protected abstract PizzaProduct CreatePizza(PizzaType pizzaType);
    }
}
