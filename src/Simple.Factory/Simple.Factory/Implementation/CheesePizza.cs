namespace Simple.Factory.Implementation
{
    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Adding Dough & Cheese...");
        }

        public override void Cook()
        {
            Console.WriteLine("Baking a Cheese Pizza...");
        }
    }
}
