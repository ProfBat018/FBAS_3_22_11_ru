using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookCenter.Services.Classes
{
    class MyRelayCommand : ICommand 
    {
        public event EventHandler? CanExecuteChanged
        {
            add { }
            remove { }
        }

        private readonly Action _action;
        private readonly Func<bool> _canExecute;

        public MyRelayCommand(Action action)
        {
            _action = action;
            _canExecute = () => true;
        }

        public MyRelayCommand(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute();
        }

        public void Execute(object? parameter)
        {
            _action();
        }
    }
}
