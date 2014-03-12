using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace openTill.GUI.Commands
{
    public class AddProductCommand : ICommand
    {
        private InventoryViewModel viewModel;
        public AddProductCommand(InventoryViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            string upc = parameter as string;
            if (!viewModel.Products.Contains(viewModel.SelectedProduct) && viewModel.Products.Any(x => x.UPC == upc))
                return false;
            else
                return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            viewModel.Products.Add(viewModel.SelectedProduct);
        }
    }
}
