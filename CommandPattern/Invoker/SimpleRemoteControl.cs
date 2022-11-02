using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Invoker
{
    internal class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand Command)
        {
            _slot = Command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
