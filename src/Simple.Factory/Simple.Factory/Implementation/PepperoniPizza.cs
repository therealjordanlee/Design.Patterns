namespace Simple.Factory.Implementation
{
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding Dough, Cheese & Pepperoni...");
        }

        public override void Cook()
        {
            Console.WriteLine("Baking a Pepperoni Pizza...");
        }
    }
}
