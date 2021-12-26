using Iterator.Pattern;

namespace Iterator.Implementation
{
    public class DinnerMenu : IAggregate
    {
        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator();
        }
    }
}
