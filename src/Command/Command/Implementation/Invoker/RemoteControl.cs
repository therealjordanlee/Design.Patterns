using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Pattern;

namespace Command.Implementation.Invoker
{
    public class RemoteControl : IInvoker
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
        }

        public void SetCommand(int commandSlot, ICommand onCommand, ICommand offCommand)
        {
            if (commandSlot < 0 || commandSlot > 7)
                throw new ArgumentOutOfRangeException("Command slot value must be between 0 - 7");

            _onCommands[commandSlot] = onCommand;
            _offCommands[commandSlot] = offCommand;
        }

        public void ExecuteOn(int commandSlot)
        {
            if (commandSlot < 0 || commandSlot > 7)
                throw new ArgumentOutOfRangeException("Command slot value must be between 0 - 7");

            _onCommands[commandSlot].Execute();
        }

        public void ExecuteOff(int commandSlot)
        {
            if (commandSlot < 0 || commandSlot > 7)
                throw new ArgumentOutOfRangeException("Command slot value must be between 0 - 7");

            _offCommands[commandSlot].Execute();
        }
    }
}
