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
            try
            {
                viewModel.ProductService.GetProductByUPC(upc);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            viewModel.ProductService.SaveProduct(viewModel.SelectedProduct.GetDTO());
        }
    }
}
