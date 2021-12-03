using Factory.Method.Pattern.Pattern;

namespace Factory.Method.Pattern.Implementation
{
    public class SydneyHamPizza : PizzaProduct
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding Dough,Cheese & Roaches...");
        }

        public override void Cook()
        {
            Console.WriteLine("Fried a Sydney Ham Pizza!");
        }
    }
}
