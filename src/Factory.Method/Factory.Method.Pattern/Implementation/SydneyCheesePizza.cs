using Factory.Method.Pattern.Pattern;

namespace Factory.Method.Pattern.Implementation
{
    public class SydneyCheesePizza : PizzaProduct
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding Dough and Mud...");
        }

        public override void Cook()
        {
            Console.WriteLine("Baked a Sydney Cheese Pizza!");
        }
    }
}
