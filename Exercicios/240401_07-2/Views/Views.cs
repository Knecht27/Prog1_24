using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace _240401_01.Views
{
    public class Views
    {
        public void Init()
        {
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());

                    switch (menu)
                    {
                        case 0:
                            aux = false;
                        break;

                        case 1:
                        CustomerView customerView = 
                            new CustomerView();
                        break;

                        case 2:
                        break;

                        case 3:
                        break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                        break;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }
            }
        ]
    }
}