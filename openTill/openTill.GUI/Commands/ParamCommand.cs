using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace openTill.GUI.Commands
{
    public class ParamCommand : ICommand
    {
        private Func<object,bool> canExecuteDelegate;

        public Func<object,bool> CanExecuteDelegate
        {
            get { return canExecuteDelegate; }
            set { canExecuteDelegate = value; }
        }
        private Action<object> executeDelegate;

        public Action<object> ExecuteDelegate
        {
            get { return executeDelegate; }
            set { executeDelegate = value; }
        }
        
        public ParamCommand(Func<object,bool> canExecute, Action<object> execute)
        {
            CanExecuteDelegate = canExecute;
            ExecuteDelegate = execute;
        }
        public bool CanExecute(object parameter)
        {
            return CanExecuteDelegate.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteDelegate.Invoke(parameter);
        }
    }
}
