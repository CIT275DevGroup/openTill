using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using openTill.Domain.Interface.Repository;

namespace openTill.Persistence
{
    // Author: Ryan Redburn
    // Project: openTill
    // Date: 2/25/2014

    #region [ Updates ]

    // Author: Ryan Redburn
    // Date: 3/4/2014
    // Revisions: Fixed minor logic and spelling errors. Added some additional exception handling.
    // Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

    #endregion
    /// <summary>
    /// A class that actually perform the CRUD operations of a Product.
    /// </summary>
    public sealed class ProductRepository : IProductRepository
    {
        #region [ Methods ]

        /// <summary>
        /// Returns all products.
        /// </summary>
        /// <returns>IEnumerable of ProductDTO</returns>
        public IEnumerable<ProductDTO> GetAll()
        {
            IEnumerable<ProductDTO> products;

            using (var context = new openTillEntities())
            {
                products = Mapper.Map<IEnumerable<ProductDTO>>(context.Products);
            }

            return products;
        }

        /// <summary>
        /// Returns all products that match the given brand.
        /// </summary>
        /// <param name="brand">String product brand</param>
        /// <returns>IEnumerable of ProductDTO</returns>
        public IEnumerable<ProductDTO> GetByBrand(string brand)
        {
            // Throws an exception for invalid brand value
            if (String.IsNullOrWhiteSpace(brand))
                throw new ArgumentNullException("brand",
                    "brand does not accept a null or empty string as an argument.");

            IEnumerable<ProductDTO> products;

            using (var context = new openTillEntities())
            {
                products = Mapper.Map<IEnumerable<ProductDTO>>(context.Products.Where(p => p.Brand.Name == brand));
            }

            return products;
        }

        /// <summary>
        /// Returns a product matching the given upc. If no matching product is found an empty product is returned.
        /// </summary>
        /// <param name="upc">String product upc</param>
        /// <returns>ProductDTO</returns>
        public ProductDTO GetByUPC(string upc)
        {
            // Throws an exception for invalid upc value
            if (String.IsNullOrWhiteSpace(upc))
                throw new ArgumentNullException("upc",
                    "upc does not accept a null or empty string as an argument.");

            ProductDTO product;

            using (var context = new openTillEntities())
            {
                product = Mapper.Map<ProductDTO>(context.Products.SingleOrDefault(p => p.UPC == upc));

                // Throws an exception if no matching product is fonud
                if (product == null)
                    throw new InvalidOperationException("No product with the given upc exists.");
            }

            return product;
        }

        /// <summary>
        /// Submits a new product for persistence.
        /// </summary>
        /// <param name="newProduct">New product to save</param>
        public void Insert(ProductDTO newProduct)
        {
            // Throws an exception for a null dto
            if (newProduct == null)
                throw new ArgumentNullException("newProduct",
                    "newProduct does not accept a null dto as an argument.");

            using (var context = new openTillEntities())
            {
                // Throws exception if a product with the given upc already exists
                if (context.Products.SingleOrDefault(p => p.UPC == newProduct.UPC) != null)
                    throw new InvalidOperationException("A product with the given upc already exists.");

                context.Products.Add(Mapper.Map<Product>(newProduct));
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="productUpdate">Product to update</param>
        public void Update(ProductDTO productUpdate)
        {
            // Throws an exception for a null dto
            if (productUpdate == null)
                throw new ArgumentNullException("productUpdate",
                    "productUpdate does not accept a null dto as an argument.");

            using (var context = new openTillEntities())
            {
                var product = context.Products.SingleOrDefault(p => p.UPC == productUpdate.UPC);

                // Throws an exception if no matching product is fonud
                if (product == null)
                    throw new InvalidOperationException("No product with the given upc exists.");

                // Update existing product
                product.BrandId = productUpdate.BrandID;
                product.Description = productUpdate.Description;
                product.Name = productUpdate.Name;
                product.OnHand = productUpdate.OnHand;
                product.MinOnHand = productUpdate.MinOnHand;
                product.HasDeposit = productUpdate.HasDeposit;
                product.IsTaxable = productUpdate.IsTaxable;
                product.StoreCost = productUpdate.StoreCost;
                product.SellingPrice = productUpdate.SellingPrice;
                product.MinimumAge = (byte?)productUpdate.MinimumAge;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="productDel">Product to delete</param>
        public void Delete(ProductDTO productDel)
        {
            // Throws an exception for a null dto
            if (productDel == null)
                throw new ArgumentNullException("productDel",
                    "productDel does not accept a null dto as an argument.");

            using (var context = new openTillEntities())
            {
                var product = context.Products.SingleOrDefault(p => p.UPC == productDel.UPC);

                // Throws an exception if no matching entry is found
                if (product == null)
                    throw new InvalidOperationException("No entry matching the given product was found.");

                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
