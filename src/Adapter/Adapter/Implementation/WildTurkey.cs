using Adapter.Pattern;

namespace Adapter.Implementation
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Wild Turkey flies for a little bit!");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble!");
        }
    }
}
