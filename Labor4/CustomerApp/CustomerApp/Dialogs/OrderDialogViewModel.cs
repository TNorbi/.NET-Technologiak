using CustomerApp.Model;
using CustomerApp.ViewModel;
using CustomerApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Dialogs
{
    public class OrderDialogViewModel : BaseViewModel, IDataErrorInfo
    {
        private OrderService OrderService { get; }
        public Mode Mode { get; }
        private OrderDialogViewModel originalValue;
        private ViewModelLocator viewModelLocator;
        public int OrderID { get; set; }
        public int? CustomerID { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public RelayCommand UpdateAddCommand { get; }
        public RelayCommand CancelCommand { get; }

        public OrderDialogViewModel(Mode mode, OrderDTO selectedOrder)
        {
            OrderService = new OrderService();
            Mode = mode;
            OrderID = selectedOrder.OrderID;
            CustomerID = selectedOrder.CustomerID;
            Description = selectedOrder.Description;
            Quantity = selectedOrder.Quantity;
            viewModelLocator = new ViewModelLocator();
            UpdateAddCommand = new RelayCommand(update);
            CancelCommand = new RelayCommand(undo);
            originalValue = (OrderDialogViewModel)MemberwiseClone();
        }

        public void update()
        {
            if (Mode == Mode.Add)
            {
                try
                {
                    bool isSaved = OrderService.add(new OrderDTO
                    {
                        CustomerID = CustomerID,
                        Description = Description,
                        Quantity = Quantity
                    });
                    viewModelLocator.CustomerList.SelectedCustomer.Orders = new ObservableCollection<OrderDTO>(OrderService.refreshSelectedOrders(viewModelLocator.CustomerList.SelectedCustomer));
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
                    bool isUpdated = OrderService.update(new OrderDTO
                    {
                        OrderID = OrderID,
                        CustomerID = CustomerID,
                        Description = Description,
                        Quantity = Quantity
                    });
                    viewModelLocator.CustomerList.SelectedCustomer.Orders = new ObservableCollection<OrderDTO>(OrderService.refreshSelectedOrders(viewModelLocator.CustomerList.SelectedCustomer));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void undo()
        {
            Description = originalValue.Description;
            Quantity = originalValue.Quantity;
        }

        public string Error
        {
            get { return null; }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                if (columnName == "Description")
                {
                    if (Description == null)
                        return "Please enter a description";
                    else if (Description.Trim() == string.Empty)
                        return "Description is Required";
                }
                else if (columnName == "Quantity")
                {
                    if (Quantity == null)
                        return "Please enter a Quantity";
                    if (Quantity < 1)
                        return "Quantity must be at least 1";
                }
                return null;
            }
        }
    }
}
