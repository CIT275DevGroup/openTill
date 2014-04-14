//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace openTill.Persistence
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Sale
    /// </summary>
    public partial class Sale
    {
        /// <summary>
        /// Sale
        /// </summary>
        public Sale()
        {
            this.SaleItems = new HashSet<SaleItem>();
        }
        /// <summary>
        /// Sale ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Date of Sale
        /// </summary>
        public System.DateTime DateOfSale { get; set; }
        /// <summary>
        /// Sale Total
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// Employee ID
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// Employee
        /// </summary>
        public virtual Employee Employee { get; set; }
        /// <summary>
        /// Sale Items
        /// </summary>
        public virtual ICollection<SaleItem> SaleItems { get; set; }
    }
}
