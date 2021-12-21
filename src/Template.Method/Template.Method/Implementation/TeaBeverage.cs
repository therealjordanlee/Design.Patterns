using Template.Method.Pattern;

namespace Template.Method.Implementation
{
    public class TeaBeverage : CaffeineBeverage
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("Add a drop of milk.");
        }

        internal override void Brew()
        {
            Console.WriteLine("Steep the tea for 2 minutes.");
        }
    }
}
