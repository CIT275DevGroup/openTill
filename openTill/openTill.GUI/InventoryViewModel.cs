using openTill.Domain.DTO;
using openTill.Domain.Interface.Service;
using openTill.Domain.Services;
using openTill.GUI.Commands;
using openTill.Persistence;
using System.Collections.ObjectModel;
using System.Linq;

namespace openTill.GUI
{
    public class InventoryViewModel : ObservableObject
    {
        private IProductService productService;
        private BrandDTO[] _brands;

        public BrandDTO[] Brands
        {
            get { return _brands; }
            set { _brands = value; }
        }

        private ObservableCollection<ObservableProduct> _products;

        public ObservableCollection<ObservableProduct> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        private ObservableProduct _selectedProduct = new ObservableProduct(new ProductDTO());

        public ObservableProduct SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                RaisePropertyChanged("SelectedProduct");
            }
        }

        private AddProductCommand addCommand;

        public AddProductCommand AddCommand
        {
            get { return addCommand; }
            private set { addCommand = value; }
        }

        private RemoveProductCommand removeCommand;

        public RemoveProductCommand RemoveCommand
        {
            get { return removeCommand; }
            private set { removeCommand = value; }
        }

        public InventoryViewModel()
        {
            this.productService = new ProductService(new ProductRepository());
            Products = new ObservableCollection<ObservableProduct>(productService.GetAllProducts().Select(x => new ObservableProduct(x)));
            Brands = new BrandService(new BrandRepository()).GetAllBrands().ToArray();
            AddCommand = new AddProductCommand(this);
            RemoveCommand = new RemoveProductCommand(this);
        }

        public InventoryViewModel(IProductService productService, IBrandService brandService)
        {
            this.productService = productService;
            Brands = brandService.GetAllBrands().ToArray();
        }
    }
}