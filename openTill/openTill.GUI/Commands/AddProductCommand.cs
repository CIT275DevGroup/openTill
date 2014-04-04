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
                if (viewModel.SelectedProduct.UPC == String.Empty || viewModel.SelectedProduct.UPC == null)
                    return false;
                // THIS IS HERE BECAUSE I CODE SHITELY (MW recommends Poorly, you decide)
                //Also because if it throws an error it found no matching upcs and will procede to the catch and return true
                viewModel.ProductService.GetProductByUPC(viewModel.SelectedProduct.UPC);
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
