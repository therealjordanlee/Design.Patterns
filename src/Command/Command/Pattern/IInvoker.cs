namespace Command.Pattern
{
    public interface IInvoker
    {
        void SetCommand(int commandSlot, ICommand onCommand, ICommand offCommand);
    }
}
