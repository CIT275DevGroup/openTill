using openTill.Domain;
using openTill.Domain.DTO;
using System.Collections.Generic;

namespace openTill.GUI
{
    public class ObservableProduct : ObservableObject
    {
        private string _upc;
        private int _categoryListID;
        private int _brandID;
        private string _name;
        private string _description;
        private decimal _storeCost;
        private decimal _sellingPrice;
        private int _minOnHand;
        private int _onHand;
        private bool _hasDeposit;
        private bool _isTaxable;
        private int _minimumAge;
        private Brand _brand;
        private List<ProductCategory> _categoryList;
        private List<SaleItem> _saleItem;

        public string UPC
        {
            get { return _upc; }
            set
            {
                _upc = value;
                RaisePropertyChanged("UPC");
            }
        }

        public int CategoryListID
        {
            get { return _categoryListID; }
            set
            {
                _categoryListID = value;
                RaisePropertyChanged("CategoryListID");
            }
        }

        public int BrandID
        {
            get { return _brandID; }
            set
            {
                _brandID = value;
                RaisePropertyChanged("BrandID");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged("Description");
            }
        }

        public decimal StoreCost
        {
            get { return _storeCost; }
            set
            {
                _storeCost = value;
                RaisePropertyChanged("StoreCost");
            }
        }

        public decimal SellingPrice
        {
            get { return _sellingPrice; }
            set
            {
                _sellingPrice = value;
                RaisePropertyChanged("SellingPrice");
            }
        }

        public int OnHand
        {
            get { return _onHand; }
            set
            {
                _onHand = value;
                RaisePropertyChanged("OnHand");
            }
        }

        public int MinOnHand
        {
            get { return _minOnHand; }
            set
            {
                _minOnHand = value;
                RaisePropertyChanged("MinOnHand");
            }
        }

        public bool HasDeposit
        {
            get { return _hasDeposit; }
            set
            {
                _hasDeposit = value;
                RaisePropertyChanged("HasDeposit");
            }
        }

        public bool IsTaxable
        {
            get { return _isTaxable; }
            set
            {
                _isTaxable = value;
                RaisePropertyChanged("IsTaxable");
            }
        }

        public int MinimumAge
        {
            get { return _minimumAge; }
            set
            {
                _minimumAge = value;
                RaisePropertyChanged("MinimumAge");
            }
        }

        public Brand Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
                RaisePropertyChanged("Brand");
            }
        }

        public List<ProductCategory> CategoryList
        {
            get { return _categoryList; }
            set
            {
                _categoryList = value;
                RaisePropertyChanged("CategoryList");
            }
        }

        public List<SaleItem> SaleItem
        {
            get { return _saleItem; }
            set
            {
                _saleItem = value;
                RaisePropertyChanged("SaleItem");
            }
        }

        public ProductDTO GetDTO()
        {
            return new ProductDTO
            {
                UPC = this.UPC,
                CategoryListID = this.CategoryListID,
                BrandID = this.BrandID,
                Name = this.Name,
                Description = this.Description,
                StoreCost = this.StoreCost,
                SellingPrice = this.SellingPrice,
                MinOnHand = this.MinOnHand,
                OnHand = this.OnHand,
                HasDeposit = this.HasDeposit,
                IsTaxable = this.IsTaxable,
                MinimumAge = this.MinimumAge,
                Brand = this.Brand,
                CategoryList = this.CategoryList,
                SaleItem = this.SaleItem
            };
        }

        public ObservableProduct(ProductDTO dto)
        {
            UPC = dto.UPC;
            CategoryListID = dto.CategoryListID;
            BrandID = dto.BrandID;
            Name = dto.Name;
            Description = dto.Description;
            StoreCost = dto.StoreCost;
            SellingPrice = dto.SellingPrice;
            MinOnHand = dto.MinOnHand;
            OnHand = dto.OnHand;
            HasDeposit = dto.HasDeposit;
            IsTaxable = dto.IsTaxable;
            MinimumAge = dto.MinimumAge;
            Brand = dto.Brand;
            CategoryList = dto.CategoryList;
            SaleItem = dto.SaleItem;
        }
    }
}