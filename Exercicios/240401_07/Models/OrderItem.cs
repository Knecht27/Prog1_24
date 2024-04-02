using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_07.Models
{
    public class OrderItem
    {
        public Product Product {get; set;}
        public double Quantity {get; set;}
        public double PurchasePrice {get; set;}

       
          public bool Validate()
        {
            return true;
        }
        
        public OrderItem Retrive()
        {
            return new OrderItem();
        }

        public void Save(OrderItem orderItem)
        {

        }
    }
}