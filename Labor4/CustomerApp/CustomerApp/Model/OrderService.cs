using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    public class OrderService
    {
        private CustomerEntities customerEntities;
        public OrderService()
        {
            customerEntities = new CustomerEntities();
        }

        public List<OrderDTO> refreshSelectedOrders(CustomerDTO customerDTO)
        {
            List<OrderDTO> orderDTOs = new List<OrderDTO>();
            try
            {
                var orders = from order in customerEntities.Orders
                             join cust in customerEntities.Customers on order.CustomerID equals cust.CustomerID
                             where cust.CustomerID == customerDTO.CustomerID
                             select order;


                foreach (var order in orders)
                    orderDTOs.Add(new OrderDTO
                    {
                        OrderID = order.OrderID,
                        CustomerID =
                    order.CustomerID,
                        Description = order.Description,
                        Quantity = order.Quantity,
                        Customers
                    = order.Customers
                    });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return orderDTOs;
        }

        public bool add(OrderDTO newOrder)
        {
            bool isAdded;
            try
            {
                var order = new Orders();
                order.OrderID = newOrder.OrderID;
                order.CustomerID = newOrder.CustomerID;
                order.Description = newOrder.Description;
                order.Quantity = newOrder.Quantity;
                order.Customers = newOrder.Customers;
                customerEntities.Orders.Add(order);
                var numberOfRowsAffected = customerEntities.SaveChanges();
                isAdded = numberOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isAdded;
        }

        public bool update(OrderDTO orderToUpdate)
        {
            bool isUpdated;
            try
            {
                var order = customerEntities.Orders.Find(orderToUpdate.OrderID);
                order.CustomerID = orderToUpdate.CustomerID;
                order.Description = orderToUpdate.Description;
                order.Quantity = orderToUpdate.Quantity;
                order.Customers = orderToUpdate.Customers;
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
                var order = customerEntities.Orders.Find(id);
                customerEntities.Orders.Remove(order);
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
