namespace Composite.Pattern
{
    public abstract class AbstractMenuComponent
    {
        // Composite methods
        public virtual void Add(AbstractMenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(AbstractMenuComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual AbstractMenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        // Operation methods
        public virtual string GetName()
        {
            throw new NotImplementedException();
        }

        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }

        public virtual double GetPrice()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}
