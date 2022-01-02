namespace State.Pattern
{
    public interface IState
    {
        StateType Type { get; }
        void InsertQuarter();
        void EjectQuarter();
        void Dispense();
    }
}
