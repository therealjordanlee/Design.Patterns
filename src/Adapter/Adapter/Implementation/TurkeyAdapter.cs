using Adapter.Pattern;

namespace Adapter.Implementation
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for(int i=0; i<3; i++)
                _turkey.Fly();
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
