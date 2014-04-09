using GalaSoft.MvvmLight;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.GUI.Models
{
    /// <summary>
    /// A class for an ObservableBrand
    /// </summary>
    public class ObservableBrand : ObservableObject
    {
        /// <summary>
        /// The <see cref="Id" /> property's name.
        /// </summary>
        public const string IdPropertyName = "Id";

        private int _id;

        /// <summary>
        /// Sets and gets the Id property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                Set(IdPropertyName, ref _id, value);
            }
        }
        /// <summary>
        /// The <see cref="BrandName" /> property's name.
        /// </summary>
        public const string BrandNamePropertyName = "BrandName";

        private string _brandName;

        /// <summary>
        /// Sets and gets the BrandName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                Set(BrandNamePropertyName, ref _brandName, value);
            }
        }
        /// <summary>
        /// Makes an empty observable brand.
        /// </summary>
        public ObservableBrand()
        {
            Id = 0;
            BrandName = String.Empty;
        }
        /// <summary>
        /// Creates an Observable Brand with information from the BrandDTO
        /// </summary>
        /// <param name="dto">The Brand data transfer object</param>
        public ObservableBrand(BrandDTO dto)
        {
            Id = dto.Id;
            BrandName = dto.Name;
        }
        /// <summary>
        /// Creates a BrandDTO
        /// </summary>
        /// <returns>A BrandDTO</returns>
        public BrandDTO GetDTO()
        {
            return new BrandDTO
            {
                Id = this.Id,
                Name = this.BrandName
            };
        }
    }
}
