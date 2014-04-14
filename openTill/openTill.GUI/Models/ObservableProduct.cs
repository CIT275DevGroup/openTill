using GalaSoft.MvvmLight;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace openTill.GUI.Models
{
    /// <summary>
    /// A class for an ObservableProduct
    /// </summary>
    public class ObservableProduct : ObservableObject
    {
        /// <summary>
        /// The <see cref="BrandID" /> property's name.
        /// </summary>
        public const string BrandIDPropertyName = "BrandID";

        /// <summary>
        /// The <see cref="CategoryListID" /> property's name.
        /// </summary>
        public const string CategoryListIDPropertyName = "CategoryListID";

        /// <summary>
        /// The <see cref="CategoryList" /> property's name.
        /// </summary>
        public const string CategoryListPropertyName = "CategoryList";

        /// <summary>
        /// The <see cref="Description" /> property's name.
        /// </summary>
        public const string DescriptionPropertyName = "Description";

        /// <summary>
        /// The <see cref="HasDeposit" /> property's name.
        /// </summary>
        public const string HasDepositPropertyName = "HasDeposit";

        /// <summary>
        /// The <see cref="IsTaxable" /> property's name.
        /// </summary>
        public const string IsTaxablePropertyName = "IsTaxable";

        /// <summary>
        /// The <see cref="MinimumAge" /> property's name.
        /// </summary>
        public const string MinimumAgePropertyName = "MinimumAge";

        /// <summary>
        /// The <see cref="MinOnHand" /> property's name.
        /// </summary>
        public const string MinOnHandPropertyName = "MinOnHand";

        /// <summary>
        /// The <see cref="Name" /> property's name.
        /// </summary>
        public const string NamePropertyName = "Name";

        /// <summary>
        /// The <see cref="OnHand" /> property's name.
        /// </summary>
        public const string OnHandPropertyName = "OnHand";

        /// <summary>
        /// The <see cref="ProductState" /> property's name.
        /// </summary>
        public const string ProductStatePropertyName = "ProductState";

        /// <summary>
        /// The <see cref="SellingPrice" /> property's name.
        /// </summary>
        public const string SellingPricePropertyName = "SellingPrice";

        /// <summary>
        /// The <see cref="StoreCost" /> property's name.
        /// </summary>
        public const string StoreCostPropertyName = "StoreCost";

        /// <summary>
        /// The <see cref="UPC" /> property's name.
        /// </summary>
        public const string UPCPropertyName = "UPC";

        private int _brandID;
        private List<CategoryDTO> _categoryList;
        private int _categoryListID;
        private string _description;
        private bool _hasDeposit;
        private bool _isTaxable;
        private int _minimumAge;
        private int _minOnHand;
        private string _name;
        private int _onHand;
        private State _productState;
        private decimal _sellingPrice;
        private decimal _storeCost;
        private string _upc;

        /// <summary>
        /// Creates an empty ObservableProduct
        /// </summary>
        public ObservableProduct()
        {
            UPC = String.Empty;
            CategoryListID = 0;
            BrandID = 0;
            Name = String.Empty;
            Description = String.Empty;
            StoreCost = 0;
            SellingPrice = 0;
            MinOnHand = 0;
            OnHand = 0;
            HasDeposit = false;
            IsTaxable = false;
            MinimumAge = 0;
            ProductState = State.New;
        }
        /// <summary>
        /// Creates an ObservableProduct
        /// </summary>
        /// <param name="dto"></param>
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
            CategoryList = dto.CategoryList;
            ProductState = State.Unmodified;
        }
        /// <summary>
        /// Created a State enum
        /// </summary>
        public enum State 
        { 
            /// <summary>
            /// Unmodified
            /// </summary>
            Unmodified, 
            /// <summary>
            /// Modified
            /// </summary>
            Modified, 
            /// <summary>
            /// New
            /// </summary>
            New 
        };

        /// <summary>
        /// Sets and gets the BrandID property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public int BrandID
        {
            get
            {
                return _brandID;
            }
            set
            {
                Set(BrandIDPropertyName, ref _brandID, value);
            }
        }

        /// <summary>
        /// Sets and gets the CategoryList property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public List<CategoryDTO> CategoryList
        {
            get
            {
                return _categoryList;
            }
            set
            {
                Set(CategoryListPropertyName, ref _categoryList, value);
            }
        }

        /// <summary>
        /// Sets and gets the CategoryListID property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public int CategoryListID
        {
            get
            {
                return _categoryListID; ;
            }
            set
            {
                Set(CategoryListIDPropertyName, ref _categoryListID, value);
            }
        }

        /// <summary>
        /// Sets and gets the Description property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                Set(DescriptionPropertyName, ref _description, value);
            }
        }

        /// <summary>
        /// Sets and gets the HasDeposit property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public bool HasDeposit
        {
            get
            {
                return _hasDeposit;
            }
            set
            {
                Set(HasDepositPropertyName, ref _hasDeposit, value);
            }
        }

        /// <summary>
        /// Sets and gets the IsTaxable property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public bool IsTaxable
        {
            get
            {
                return _isTaxable;
            }
            set
            {
                Set(IsTaxablePropertyName, ref _isTaxable, value);
            }
        }

        /// <summary>
        /// Sets and gets the MinimumAge property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public int MinimumAge
        {
            get
            {
                return _minimumAge;
            }
            set
            {
                Set(MinimumAgePropertyName, ref _minimumAge, value);
            }
        }

        /// <summary>
        /// Sets and gets the MinOnHand property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public int MinOnHand
        {
            get
            {
                return _minOnHand;
            }
            set
            {
                Set(MinOnHandPropertyName, ref _minOnHand, value);
            }
        }

        /// <summary>
        /// Sets and gets the Name property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Set(NamePropertyName, ref _name, value);
            }
        }

        /// <summary>
        /// Sets and gets the OnHand property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public int OnHand
        {
            get
            {
                return _onHand;
            }
            set
            {
                Set(OnHandPropertyName, ref _onHand, value);
            }
        }

        /// <summary>
        /// Sets and gets the ProductState property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public State ProductState
        {
            get
            {
                return _productState;
            }
            set
            {
                Set(ProductStatePropertyName, ref _productState, value);
            }
        }

        /// <summary>
        /// Sets and gets the SellingPrice property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public decimal SellingPrice
        {
            get
            {
                return _sellingPrice;
            }
            set
            {
                Set(SellingPricePropertyName, ref _sellingPrice, value);
            }
        }

        /// <summary>
        /// Sets and gets the StoreCost property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public decimal StoreCost
        {
            get
            {
                return _storeCost;
            }
            set
            {
                Set(StoreCostPropertyName, ref _storeCost, value);
            }
        }

        /// <summary>
        /// Sets and gets the UPC property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public string UPC
        {
            get
            {
                return _upc;
            }
            set
            {
                Set(UPCPropertyName, ref  _upc, value);
            }
        }
        /// <summary>
        /// Creates a ProductDTO
        /// </summary>
        /// <returns>A ProductDTO</returns>
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
            };
        }
    }
}