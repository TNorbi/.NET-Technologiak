using CustomerApp.Dialogs;
using CustomerApp.Model;
using CustomerApp.ViewModel.Base;
using MvvmDialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.ViewModel
{
    public class CustomerListViewModel : BaseViewModel
    {
        public ObservableCollection<CustomerDTO> Customers { get; set; }
        public CustomerDTO SelectedCustomer { get; set; }
        public OrderDTO SelectedOrder { get; set; }
        public string CustomerMessage { get; set; }
        public string OrderMessage { get; set; }
        public RelayCommand ShowCustomerEditCommand { get; }
        public RelayCommand ShowCustomerAddCommand { get; }
        public RelayCommand DeleteCustomerCommand { get; }
        public RelayCommand ShowOrderEditCommand { get; }
        public RelayCommand ShowOrderAddCommand { get; }
        public RelayCommand DeleteOrderCommand { get; }
        public Mode Mode { get; set; }
        private CustomerService CustomerService;
        private OrderService OrderService;
        private readonly IDialogService dialogService;

        public CustomerListViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            CustomerService = new CustomerService();
            OrderService = new OrderService();
            SelectedCustomer = new CustomerDTO();
            SelectedOrder = new OrderDTO();
            loadCustomers();
            ShowCustomerEditCommand = new RelayCommand(showCustomerEdit);
            ShowCustomerAddCommand = new RelayCommand(showCustomerAdd);
            ShowOrderEditCommand = new RelayCommand(showOrderEdit);
            ShowOrderAddCommand = new RelayCommand(showOrderAdd);
            DeleteOrderCommand = new RelayCommand(deleteCustomer);
            DeleteOrderCommand = new RelayCommand(deleteOrder);
        }

        public void loadCustomers()
        {
            Customers = new ObservableCollection<CustomerDTO>(CustomerService.getAll());
        }

        public void loadOrders()
        {
            SelectedCustomer.Orders = new ObservableCollection<OrderDTO>(OrderService.refreshSelectedOrders(SelectedCustomer));

        }

        public void showCustomerEdit()
        {
            if (SelectedCustomer != null)
            {
                Mode = Mode.Edit;
                dialogService.Show(this, new CustomerDialogViewModel(Mode, SelectedCustomer));

            }
            else
                CustomerMessage = "Edit operation failed! User is not selected!";
        }
        public void showOrderEdit()
        {
            if (SelectedOrder != null)
            {
                Mode = Mode.Edit;
                dialogService.Show(this, new OrderDialogViewModel(Mode, SelectedOrder));

            }
            else
            {
                OrderMessage = "Edit operation failed! Order is not selected!";
            }

        }

        public void showCustomerAdd()
        {
            Mode = Mode.Add;
            dialogService.Show(this, new CustomerDialogViewModel(Mode, new CustomerDTO()));

        }

        public void showOrderAdd()
        {
            Mode = Mode.Add;
            OrderDTO orderDTO = new OrderDTO();
            orderDTO.CustomerID = SelectedCustomer.CustomerID;
            dialogService.Show(this, new OrderDialogViewModel(Mode, orderDTO));
        }

        public void deleteCustomer()
        {
            if (SelectedCustomer != null)
            {
                try
                {
                    bool isDeleted = CustomerService.delete(SelectedCustomer.CustomerID
                    );
                    if (isDeleted)
                    {
                        CustomerMessage = $"{SelectedCustomer.CompanyName} company has been deleted successfully.";
                        loadCustomers();
                    }
                    else
                    {
                        CustomerMessage = $"Delete operation failed.";
                    }
                }
                catch (Exception ex)
                {
                    CustomerMessage = $"Delete operation failed: {ex.Message}";
                }
            }
            else
            {
                CustomerMessage = "Delete operation failed! User is not selected!";
            }
        }

        public void deleteOrder()
        {
            if (SelectedOrder != null)
            {
                try
                {
                    bool isDeleted = OrderService.delete(SelectedOrder.OrderID);
                    if (isDeleted)
                    {
                        OrderMessage = $"{SelectedOrder.Description} described order has been deleted successfully.";

                        loadOrders();
                    }
                    else
                    {
                        OrderMessage = $"Delete operation failed.";
                    }
                        
                }
                catch (Exception ex)
                {
                    OrderMessage = $"Delete operation failed: {ex.Message}";
                }
            }
            else
            {
                OrderMessage = "Delete operation failed! User is not selected!";
            }
                
        }
    }
}
