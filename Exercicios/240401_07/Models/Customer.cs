using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_07.Models
{

    public class Customer
    {
        public int CustomerId {get; set;}
        public string Name {get; set;}
        public string EmailAddres {get; set;}
        public string HomeAddres {get; set;}
        public string WorkAddres {get; set;}
        public List<Address> Addresses { get; set; }

        public Customer()
        {

        }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(Name)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddres)) isValid = false;
            return isValid;
        }

        public Customer Retrive(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }
        public void Save(Customer custumer)
        {

        }
    }
}