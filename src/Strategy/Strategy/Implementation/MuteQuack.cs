using Strategy.Pattern;

namespace Strategy.Implementation
{
    public class MuteQuack : IQuacker
    {
        public List<Type> SupportedDucks => new List<Type> { typeof(WoodenDuck) };

        public void Quack()
        {
            Console.Write("*Silence*");
        }
    }
}