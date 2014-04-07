using GalaSoft.MvvmLight;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.GUI.Models
{
    public class ObservableCategory : ObservableObject
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
        /// The <see cref="Name" /> property's name.
        /// </summary>
        public const string NamePropertyName = "Name";

        private string _name;

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
        /// The <see cref="Description" /> property's name.
        /// </summary>
        public const string DescriptionPropertyName = "Description";

        private string _description;

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
        public ObservableCategory()
        {
            Id = 0;
            Name = String.Empty;
            Description = String.Empty;
        }
        public ObservableCategory(CategoryDTO dto)
        {
            this.Id = dto.Id;
            this.Name = dto.Name;
            this.Description = dto.Description;
        }
        public CategoryDTO GetDTO()
        {
            return new CategoryDTO
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description
            };
        }
    }
}
