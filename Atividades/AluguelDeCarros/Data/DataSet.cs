using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data
{
    public class DataSet
    {
        public static List<Clientes> Clientes { get; set; } = new List<Clientes> ();
        public static List<Carros> Acervo { get; set; } = new List<Carros> ();
    }
}