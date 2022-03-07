using CustomerApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    public class CustomerDTO:BaseViewModel
    {
        public virtual ObservableCollection<OrderDTO> Orders { get; set; }
        public CustomerDTO()
        {
            Orders = new ObservableCollection<OrderDTO>();
        }
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
