using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    public class CustomerService
    {
        private CustomerEntities customerEntities;
        public CustomerService()
        {
            customerEntities = new CustomerEntities();
        }

        public List<CustomerDTO> getAll()
        {
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            try
            {
                var customers = from customer in customerEntities.Customers
                                select customer;
                foreach (var customer in customers)
                    customerDTOs.Add(new CustomerDTO
                    {
                        CustomerID = customer.CustomerID
                    ,
                        CompanyName = customer.CompanyName,
                        ContactName = customer.ContactName,
                        Orders = convertOrderToOrderDTO(customer.Orders)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerDTOs;
        }

        private ObservableCollection<OrderDTO> convertOrderToOrderDTO(ObservableCollection<Orders> orders)
        {
            ObservableCollection<OrderDTO> orderDTOs = new ObservableCollection<OrderDTO>();

            foreach (var order in orders)
            {
                orderDTOs.Add(new OrderDTO
                {
                    OrderID = order.OrderID,
                    CustomerID = order.CustomerID,
                    Description = order.Description,
                    Quantity = order.Quantity,
                    Customers = order.Customers
                });
            }
            return orderDTOs;
        }

        public bool add(CustomerDTO newCustomer)
        {
            bool isAdded;
            try
            {
                var customer = new Customers();
                customer.CustomerID = newCustomer.CustomerID;
                customer.CompanyName = newCustomer.CompanyName;
                customer.ContactName = newCustomer.ContactName;
                customerEntities.Customers.Add(customer);
                var numberOfRowsAffected = customerEntities.SaveChanges();
                isAdded = numberOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isAdded;
        }

        public bool update(CustomerDTO customerToUpdate)
        {
            bool isUpdated;
            try
            {
                var customer = customerEntities.Customers.Find(customerToUpdate.CustomerID);

                customer.CompanyName = customerToUpdate.CompanyName;
                customer.ContactName = customerToUpdate.ContactName;
                var numberOfRowsAffected = customerEntities.SaveChanges();
                isUpdated = numberOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isUpdated;
        }

        public bool delete(int id)
        {
            bool isDeleted;
            try
            {
                var customer = customerEntities.Customers.Find(id);
                customerEntities.Customers.Remove(customer);
                var numberOfRowsEffected = customerEntities.SaveChanges();
                isDeleted = numberOfRowsEffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isDeleted;
        }

    }
}