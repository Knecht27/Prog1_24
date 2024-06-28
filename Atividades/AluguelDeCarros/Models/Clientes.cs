using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Models
{
    public class Clientes
    {
        public int cpf { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public Carros alugado { get; set; }
    }
}