using System.Collections.Generic;

namespace Command
{
    public class Switch
    {
        public List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}
