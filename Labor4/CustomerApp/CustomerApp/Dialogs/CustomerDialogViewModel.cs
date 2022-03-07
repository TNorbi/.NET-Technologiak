using CustomerApp.Model;
using CustomerApp.ViewModel;
using CustomerApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Dialogs
{
    class CustomerDialogViewModel : BaseViewModel
    {
        private CustomerService CustomerService { get; }
        public Mode Mode { get; }
        private CustomerDialogViewModel originalValue;
        private ViewModelLocator viewModelLocator;
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public RelayCommand UpdateAddCommand { get; }
        public RelayCommand CancelCommand { get; }

        public CustomerDialogViewModel(Mode mode, CustomerDTO selectedCustomer)
        {
            CustomerService = new CustomerService();
            Mode = mode;
            CustomerID = selectedCustomer.CustomerID;
            CompanyName = selectedCustomer.CompanyName;
            ContactName = selectedCustomer.ContactName;
            viewModelLocator = new ViewModelLocator();
            CancelCommand = new RelayCommand(undo);
            UpdateAddCommand = new RelayCommand(update);
            originalValue = (CustomerDialogViewModel)MemberwiseClone();
        }

        public void update()
        {
            if (Mode == Mode.Add)
            {
                try
                {
                    bool isSaved = CustomerService.add(new CustomerDTO
                    {
                        CompanyName = CompanyName,
                        ContactName = ContactName
                    });
                    viewModelLocator.CustomerList.Customers = new ObservableCollection<CustomerDTO>(CustomerService.getAll());

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (Mode == Mode.Edit)
            {
                try
                {
                    bool isUpdated = CustomerService.update(new CustomerDTO
                    {
                        CustomerID = CustomerID,
                        CompanyName = CompanyName,
                        ContactName = ContactName
                    });
                    viewModelLocator.CustomerList.Customers = new ObservableCollection<
                    CustomerDTO>(CustomerService.getAll());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void undo()
        {
            CompanyName = originalValue.CompanyName;
            ContactName = originalValue.ContactName;
        }
    }
}
