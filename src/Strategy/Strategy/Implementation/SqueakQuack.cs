using Strategy.Pattern;

namespace Strategy.Implementation
{
    public class SqueakQuack : IQuacker
    {
        public List<Type> SupportedDucks => new List<Type> { typeof(RubberDuck) };

        public void Quack()
        {
            Console.Write("SQUEAK!");
        }
    }
}