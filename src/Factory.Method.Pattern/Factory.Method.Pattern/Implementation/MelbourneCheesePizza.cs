using Factory.Method.Pattern.Pattern;

namespace Factory.Method.Pattern.Implementation
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
