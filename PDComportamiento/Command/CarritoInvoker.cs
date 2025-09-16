using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDComportamiento.Command
{
    public class CarritoInvoker
    {
        private readonly Stack<ICommand> undo = new Stack<ICommand>();
        private readonly Stack<ICommand> redo = new Stack<ICommand>();

        public void Run(ICommand cmd)
        {
            cmd.Execute();
            undo.Push(cmd);
            redo.Clear();
        }

        public void Undo() 
        {
            if(undo.Count == 0)
            {
                var cmd = undo.Pop();
                cmd.Undo();
                redo.Push(cmd);
            }
        
        }

        public void Redo()
        {
            if (redo.Count == 0)
            {
                return;
            }
            var cmd = redo.Pop();
            cmd.Execute();
            undo.Push(cmd);
        }

    }
}
