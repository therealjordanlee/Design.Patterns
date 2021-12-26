using Iterator.Pattern;

namespace Iterator.Implementation
{
    public class DinnerMenuIterator : IIterator
    {
        private MenuItem[] _menuItems;
        private int _currentIndex;

        public DinnerMenuIterator()
        {
            _menuItems = new MenuItem[2]
            {
                new MenuItem()
                {
                    Name = "Old Shoes",
                    Description = "A pair of dirty old shoes",
                    Price = 10
                },
                new MenuItem()
                {
                    Name = "New Shoes",
                    Description = "A pair of barely used shoes",
                    Price = 100
                }
            };

            _currentIndex = 0;
        }
        public bool HasNext()
        {
            return _currentIndex < _menuItems.Length;
        }

        public MenuItem Next()
        {
            return _menuItems[_currentIndex++];
        }
    }
}
