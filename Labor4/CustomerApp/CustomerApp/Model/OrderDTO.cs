using CustomerApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    public class OrderDTO:BaseViewModel
    {
        public int OrderID { get; set; }
        public int? CustomerID { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public virtual Customers Customers { get; set; }
    }
}
