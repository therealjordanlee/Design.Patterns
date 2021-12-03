using Factory.Method.Pattern.Pattern;

namespace Factory.Method.Pattern.Implementation
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
