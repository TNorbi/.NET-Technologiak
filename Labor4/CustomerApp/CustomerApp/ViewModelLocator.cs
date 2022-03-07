using CommonServiceLocator;
using CustomerApp.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<CustomerListViewModel>();
        }
        public CustomerListViewModel CustomerList => ServiceLocator.Current.GetInstance<CustomerListViewModel>();
    }
}
