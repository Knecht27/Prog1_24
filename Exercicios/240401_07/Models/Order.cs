using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_07.Models
{
    public class Order
    {
        public Customer customer {get; set;}
        public DateTime OrderDate {get; set;}
        public string ShippingAddres {get; set;}
        public List<OrderItem> orderItems {get; set;}
        
          public bool Validate()
        {
            return true;
        }
        
        public Order Retrive()
        {
            return new Order();
        }

        public void Save(Order order)
        {

        }
    }
}