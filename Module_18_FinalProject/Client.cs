using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_FinalProject
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Client
    {
        ICommand command;

        public void PrepareCommand(ICommand command)
        {
            this.command = command;
        }

        public void Execute()
        {
            command.Execute();
        }

        public void Cancel()
        {
            command.Cancel();
        }
    }
}
