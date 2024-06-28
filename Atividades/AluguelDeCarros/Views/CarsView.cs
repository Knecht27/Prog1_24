using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;
using AluguelDeCarros.Models;
using AluguelDeCarros.Data;
using AluguelDeCarros.Controllers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AluguelDeCarros.Views
{
    public class CarsView
    {
        private CarrosController carrosController;

        public CarsView()
        {
            carrosController = new CarrosController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("MENU DE CARROS");
            Console.WriteLine("******************");
            Console.WriteLine();

            bool aux = true;
            do
            {
                Console.WriteLine("Escolha uma ação: ");
                Console.WriteLine("1 - Inserir novo carro");
                Console.WriteLine("2 - Pesquisar por carro");
                Console.WriteLine("3 - Editar informações de carros");
                Console.WriteLine("4 - Remover carros");
                Console.WriteLine("5 - Alugar Carro");
                Console.WriteLine("6 - Devolver Carro");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        aux = false;
                    break;
                    case 1:
                        InsertCar();
                    break;
                    case 2:
                        SearchCar();
                    break;
                    case 3:
                        EditByID();
                    break;
                    case 4:
                        removeByID();
                    break;
                    case 5:
                        AlugaCarro();
                    break;
                    case 6:
                        DevolveCarro();
                    break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        aux = true;
                    break;
                }

            }
            while (aux);
        }

            private void InsertCar()
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Inserir Novo Carro: ");
                Console.WriteLine("******************************");
        
                Carros carros = new Carros();
            
                Console.WriteLine("Nome: ");
                carros.carName = Console.ReadLine();

                Console.Write("ID: ");
                carros.carID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Preço: ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());
                carros.carPrice = (int)preco; 

                Console.WriteLine("");

                carrosController.Insert(carros);
                Console.WriteLine("Carro adicionado com sucesso!");
            }
        
            private void AlugaCarro()
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Alugando Carro: ");
                Console.WriteLine("******************************");

                Console.WriteLine("ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("CPF: ");
                int CPF = Convert.ToInt32(Console.ReadLine());

                bool clienteEncontrado = false;

                foreach (Clientes clientes in DataSet.Clientes)
                {
                    if (clientes.cpf == CPF)
                    {
                        carrosController.AlugaCarros(ID, CPF);
                        clienteEncontrado = true;
                        break;
                    }
                }
                if (clienteEncontrado)
                {
                    Console.WriteLine("Alugado");
                    Console.WriteLine("");
                }
                else 
                {
                    Console.WriteLine("Cliente não cadastrado");
                    Console.WriteLine("");
                }
            }

            private void DevolveCarro()
            {
                Console.WriteLine("***********************");
                    Console.WriteLine("Devolução do Carro");
                    Console.WriteLine("***********************");

                Console.WriteLine("ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("CPF: ");
                int CPF = Convert.ToInt32(Console.ReadLine());

                bool clienteEncontrado = false;

                foreach (Clientes clientes in DataSet.Clientes)
                {
                    if (clienteEncontrado.cpf == CPF)
                    {
                        carrosController.AlugaCarros(ID, CPF);
                        clienteEncontrado = true;
                        break;
                    }

                    if (clienteEncontrado)
                    {
                        carrosController.DevolveCarro(ID, CPF);
                        Console.WriteLine("Devolvido");
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado");
                    }
                }
            }

            private void SearchCar()
            {
                int aux2 = -1;
                do
                {
                    Console.WriteLine("Pesquisar Carro");
                    Console.WriteLine("******************");
                    Console.WriteLine("1 - Buscar por ID");
                    Console.WriteLine("2 - Buscar por Nome");
                    Console.WriteLine("3 - Listar Tudo");
                    Console.WriteLine("0 - Sair");
            
                    string menuOpt = Console.ReadLine();
                    aux2 = Convert.ToInt16(menuOpt);
                    Console.WriteLine(aux2);
                    switch(aux2)
                    {
                        case 1:
                            Console.WriteLine("Informe o ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                           ShowCarID(id);
                            break;
                         case 2:
                            Console.WriteLine("Informe o nome: ");
                            string nome = Console.ReadLine();
                            ShowCarname(nome);
                            break;
                        case 3:
                            ShowALL();
                            break;
                        case 0:
                        break;
                        default:
                            aux2 = -1;
                            Console.WriteLine("Opção inválida");
                    break;
                }
        
            }

            while (aux2 != 0);

            private void ShowALL()
            {
            List<Carros> result = carrosController.GetAll();
            foreach (Carros c in result)
            {
                Console.WriteLine("ID do Carro: " + c.carID.ToString());
                Console.WriteLine("Nome do Carro: " + c.carName.ToString());
                Console.WriteLine("Preço: " + c.carPrice.ToString());

                if(c.rentedBy != null)
                    Console.WriteLine($"Alugado pelo cliente: {l?.rentedBy?.nome}");
            }
            }

            private void ShowCarID(int id)
            {
            Carros c = carrosController.GetByID(id);
            if (id != null)
            {
                Console.WriteLine("ID do Livro: " + c.carID.ToString());
                Console.WriteLine("Nome do Livro: " + c.carName.ToString());
                Console.WriteLine("Preço: " + c.carPrice.ToString());
                try {Console.WriteLine("Locado pelo cliente: " + c.rentedBy.nome.ToString());} catch { Console.WriteLine(""); }
            }
            else
            {
                Console.WriteLine($"Pessoa de id {id} não encontrado");
            }
            }

            public void EditByID()
            {
            Console.WriteLine("Informe o Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o nome novo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o preço novo: ");
            int preco = Convert.ToInt32(Console.ReadLine());
            carrosController.Edit(id, nome, preco);
            }

            public void removeByID()
            {
            Console.WriteLine("Informe o ID");
            int id = Convert.ToInt32(Console.ReadLine());

            carrosController.Remove(id);
            }
        }

        private void removeByID()
        {
            Console.WriteLine("Informe o ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            carrosController.Remove(id);
        }

        private void ShowCarname(string nome)
        {
            List<Carros> result = carrosController.GetByName(nome);
            if (result == null)
            {
                Console.WriteLine("Não encontrado");
                return;
            }
            if (result.Count == 0)
            {
                Console.WriteLine("Não encontrado!");
                return;
            }
            foreach (Carros c in result)
            {
                   Console.WriteLine("ID do Livro: " + c.carID.ToString());
                Console.WriteLine("Nome do Livro: " + c.carName.ToString());
                Console.WriteLine("Preço: " + c.carPrice.ToString());
                try {Console.WriteLine("Locado pelo cliente: " + c.rentedBy.nome.ToString());} catch { Console.WriteLine(""); }
            }
        }

    }
}