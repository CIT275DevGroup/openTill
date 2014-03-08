using openTill.Domain.DTO;
using openTill.Domain.Interface.Repository;
using openTill.Domain.Interface.Service;
using openTill.Domain.Services;
using openTill.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private ObservableProduct _selectedProduct;

        public ObservableProduct SelectedProduct
        {
            get { return _selectedProduct; }
            set 
            {
                _selectedProduct = value;
                RaisePropertyChanged("SelectedProduct");
            }
        }
        public InventoryViewModel()
        {
            this.productService = new ProductService(new ProductRepository());
            Brands = new BrandService(new BrandRepository()).GetAllBrands().ToArray();
        }
    }
}
