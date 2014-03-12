using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace openTill.GUI.Commands
{
    public class RemoveProductCommand : ICommand
    {
        private InventoryViewModel viewModel;
        public RemoveProductCommand(InventoryViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            if (viewModel.Products.Contains(viewModel.SelectedProduct))
                return true;
            else
                return false;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            viewModel.Products.Remove(viewModel.SelectedProduct);
        }
    }
}
