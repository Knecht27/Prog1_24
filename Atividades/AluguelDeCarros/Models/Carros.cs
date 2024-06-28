using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Models
{
    public class Carros
    {
        public int carID { get; set; }
        public string carName { get; set; }
        public int carPrice {get; set; }
        public Clientes rentedBy { get; set; }
    }
}