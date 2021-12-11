using Factory.Method.Pattern;

namespace Factory.Method.Implementation
{
    public class MelbourneCheesePizza : PizzaProduct
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding Dough and Cheese...");
        }

        public override void Cook()
        {
            Console.WriteLine("Baked a Melbourne Cheese Pizza!");
        }
    }
}
