using Iterator.Pattern;

namespace Iterator.Implementation
{
    public class LunchMenuIterator : IIterator
    {
        private List<MenuItem> _menuItems;
        private int _currentIndex;

        public LunchMenuIterator()
        {
            _menuItems = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "Beef Burger",
                    Description = "Fresh roasted cow with bread.",
                    Price = 5
                },
                new MenuItem()
                {
                    Name = "Chicken",
                    Description = "Deep fried goodness.",
                    Price = 10
                }
            };
        }

        public bool HasNext()
        {
            return _currentIndex < _menuItems.Count;
        }

        public MenuItem Next()
        {
            return _menuItems[_currentIndex++];
        }
    }
}
