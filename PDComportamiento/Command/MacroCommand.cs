using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> commands;

        public MacroCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
           for (int i = 0; i < commands.Count; i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = commands.Count - 1; i >= 0; i--)
            {
                commands[i].Undo();
            }
        }
    }
}
