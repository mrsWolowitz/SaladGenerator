using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SaladGenerator.ViewModel
{
    class RelayCommand : ICommand
    {
        public Predicate<object> CanExecudeDelegate { get; set; }
        public Action<object> ExecuteDelegate { get; set; }

        public RelayCommand(Action<object> action)
        {
            ExecuteDelegate = action;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (CanExecudeDelegate != null)
                return CanExecudeDelegate(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            if (ExecuteDelegate != null)
                ExecuteDelegate(parameter);
        }
    }
}
