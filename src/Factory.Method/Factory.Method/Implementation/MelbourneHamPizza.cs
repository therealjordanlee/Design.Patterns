using Factory.Method.Pattern;

namespace Factory.Method.Implementation
{
    public class MelbourneHamPizza : PizzaProduct
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding Dough,Cheese & Ham...");
        }

        public override void Cook()
        {
            Console.WriteLine("Fried a Melbourne Ham Pizza!");
        }
    }
}
