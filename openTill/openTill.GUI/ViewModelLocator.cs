/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:openTill.GUI"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using openTill.Domain.Interface.Repository;
using openTill.Domain.Interface.Service;
using openTill.Domain.Services;
using openTill.GUI.ViewModel;
using openTill.Persistence;

namespace openTill.GUI
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IProductRepository, ProductRepository>();
            SimpleIoc.Default.Register<IBrandRepository, BrandRepository>();
            SimpleIoc.Default.Register<ICategoryRepository, CategoryRepository>();
            SimpleIoc.Default.Register<ISaleRepository, SaleRepository>();
            SimpleIoc.Default.Register<IProductService>(() => new ProductService(SimpleIoc.Default.GetInstance<IProductRepository>()));
            SimpleIoc.Default.Register<IBrandService>(() => new BrandService(SimpleIoc.Default.GetInstance<IBrandRepository>()));
            SimpleIoc.Default.Register<ICategoryService>(() => new CategoryService(SimpleIoc.Default.GetInstance<ICategoryRepository>()));
            SimpleIoc.Default.Register<ISaleService>(() => new SaleService(SimpleIoc.Default.GetInstance<ISaleRepository>()));

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models

            }
            else
            {
                // Create run time view services and models

            }

            SimpleIoc.Default.Register<InventoryViewModel>();
            SimpleIoc.Default.Register<TransactionViewModel>();
        }
        /// <summary>
        /// Gets the InventoryViewModel
        /// </summary>
        public InventoryViewModel Inventory
        {
            get
            {
                return ServiceLocator.Current.GetInstance<InventoryViewModel>();
            }
        }
        /// <summary>
        /// Gets the TransactionViewModel
        /// </summary>
        public TransactionViewModel Transaction
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TransactionViewModel>();
            }
        }
        /// <summary>
        /// A method to clear the ViewModels
        /// </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}