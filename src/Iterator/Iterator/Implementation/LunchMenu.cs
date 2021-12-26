using Iterator.Pattern;

namespace Iterator.Implementation
{
    public class LunchMenu : IAggregate
    {
        public IIterator CreateIterator()
        {
            return new LunchMenuIterator();
        }
    }
}
