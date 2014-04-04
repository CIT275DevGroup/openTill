using openTill.Domain.DTO;
using openTill.Domain.Interface.Service;
using openTill.Domain.Services;
using openTill.GUI.Commands;
using openTill.Persistence;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace openTill.GUI
{
    public class InventoryViewModel : ObservableObject
    {
        private BrandDTO[] _brands;
        private CategoryDTO[] _categories;
        private ObservableProduct _selectedProduct = new ObservableProduct(new ProductDTO());
        private ActionCommand addCommand;
        private IProductService productService;
        private ICategoryService categoryService;

        public IProductService ProductService
        {
            get { return productService; }
            private set { productService = value; }
        }
        private RemoveProductCommand removeCommand;

        /// <summary>
        /// Default constructor, hooks up to the product and brand services from openTill.Domain
        /// </summary>
        public InventoryViewModel()
        {
            this.productService = new ProductService(new ProductRepository());
            this.categoryService = new CategoryService(new CategoryRepository());
            Brands = new BrandService(new BrandRepository()).GetAllBrands().ToArray();
            AddCommand = new ActionCommand(CanAddProduct, AddProduct);
            RemoveCommand = new RemoveProductCommand(this);
            this.SelectedProduct = new ObservableProduct(new ProductDTO() { UPC="111" });
        }

        /// <summary>
        /// Constructor taking product and brand services as parameters, for testing
        /// </summary>
        /// <param name="productService">an object that implements IProductService</param>
        /// <param name="brandService">an object that implements IBrandService</param>
        public InventoryViewModel(IProductService productService, IBrandService brandService, ICategoryService categoryService)
        {
            this.productService = productService;
            Brands = brandService.GetAllBrands().ToArray();
            AddCommand = new ActionCommand(CanAddProduct, AddProduct);
            RemoveCommand = new RemoveProductCommand(this);
        }

        /// <summary>
        /// Instance of a command for adding the selected product to Products collection
        /// </summary>
        public ActionCommand AddCommand
        {
            get { return addCommand; }
            private set { addCommand = value; }
        }
        private bool CanAddProduct()
        {
            try
            {
                if (SelectedProduct.UPC == String.Empty || SelectedProduct.UPC == null)
                    return false;
                // THIS IS HERE BECAUSE I CODE SHITELY (MW recommends Poorly, you decide)
                //Also because if it throws an error it found no matching upcs and will procede to the catch and return true
                ProductService.GetProductByUPC(SelectedProduct.UPC);
                return false;
            }
            catch
            {
                return true;
            }
        }
        private void AddProduct()
        {
            ProductService.SaveProduct(SelectedProduct.GetDTO());
            SelectedProduct = new ObservableProduct();
        }

        /// <summary>
        /// List of brands for use in product dropdown
        /// </summary>
        public BrandDTO[] Brands
        {
            get { return _brands; }
            set { _brands = value; }
        }
        /// <summary>
        /// Array of categories for use in category selection, assignment, and creation
        /// </summary>
        public CategoryDTO[] Categories { get { return _categories; } set { _categories = value; } }
        /// <summary>
        /// Instance of a command for removing the selected product from the Products collection
        /// </summary>
        public RemoveProductCommand RemoveCommand
        {
            get { return removeCommand; }
            private set { removeCommand = value; }
        }

        /// <summary>
        /// The currently selected product, may not be part of Products collection
        /// </summary>
        public ObservableProduct SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                RaisePropertyChanged("SelectedProduct");
            }
        }
    }
}