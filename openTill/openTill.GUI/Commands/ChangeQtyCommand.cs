using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace openTill.GUI.Commands
{
    public class ChangeQtyCommand : ICommand
    {
        MainWindowViewModel viewModel;
        public ChangeQtyCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public bool CanExecute(object obj)
        {
            if (viewModel.SelectedItem != null)
                return true;
            else
                return false;
        }

        public event EventHandler CanExecuteChanged;
        public void Execute(object obj)
        {
            int amount = (int)obj;
            viewModel.SelectedItem.Quantity += amount;
        }
    }
}
