using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Repository;


namespace _240401_01.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;




        public  void Insert(Customer customer);
        {
            customerRepository.Save(customer);
        }
    }
}