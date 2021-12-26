using Iterator.Implementation;

namespace Iterator.Pattern
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}
