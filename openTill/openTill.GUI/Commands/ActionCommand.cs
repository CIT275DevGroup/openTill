using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace openTill.GUI.Commands
{
    public class ActionCommand : ICommand
    {
        private Func<bool> canExecuteDelegate;

        public Func<bool> CanExecuteDelegate
        {
            get { return canExecuteDelegate; }
            set { canExecuteDelegate = value; }
        }
        private Action executeDelegate;

        public Action ExecuteDelegate
        {
            get { return executeDelegate; }
            set { executeDelegate = value; }
        }
        
        public ActionCommand(Func<bool> canExecute, Action execute)
        {
            CanExecuteDelegate = canExecute;
            ExecuteDelegate = execute;
        }
        public bool CanExecute(object parameter)
        {
            return CanExecuteDelegate.Invoke();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteDelegate.Invoke();
        }
    }
}
