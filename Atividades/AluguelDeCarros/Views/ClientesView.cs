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
using System.Runtime.InteropServices;

namespace AluguelDeCarros.Views
{
    public class ClientesView
    {
        private ClientesController clientesController;

        public ClientesView()
        {
            clientesController = new ClientesController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("Menu do Cliente");
            Console.WriteLine("***************");
            Console.WriteLine("");

            bool aux = true;
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir Cliente");
                Console.WriteLine("2 - Pesquisar Cliente");
                Console.WriteLine("3 - Editar Cliente");
                Console.WriteLine("4 - Remover Cliente");
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
                            InsertCliente();
                            break;
                        case 2:
                            SearchCliente();
                            break;
                        case 3:
                            EditbyCPF();
                            break;
                        case 4:
                            RemovebyCPF();
                            break;
                        default:
                            Console.WriteLine("Opção Inválida.");
                        break;
                    
                
                    catch (Exception ex)
                    {
                        Console.WriteLine("Opção Inválida");
                        menu =-1;
                    }
                
            }
            while(aux);
        }

        private void InsertCliente()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Inserir novo cliente");
            Console.WriteLine("***********************");

                Clientes clientes = new Clientes();
                Console.Write("Nome: ");
                clientes.nome = Console.ReadLine();
                Console.Write("CPF: ");
                clientes.cpf = Convert.ToInt32(Console.ReadLine());
                Console.Write("Email: ");
                clientes.email = Console.ReadLine();
                Console.WriteLine("");

                
                try {
                    ClientesController.Insert(clientes);
                    Console.WriteLine("Cliente inserido com sucesso!");
                }   

                catch {
                    Console.WriteLine("Ops! Ocorreu um erro.");
                }
        }

        private void SearchCliente() {

            int aux = -1;
            do {
                Console.WriteLine("Buscar Clientes");
                Console.WriteLine("*****************");
                Console.WriteLine("1 - Buscar por CPF");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("3 - Listar Todos");
                Console.WriteLine("0 - Sair");

                string? menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);
                switch(aux) {
                    case 1:
                        Console.WriteLine("Informe o CPF: ");
                        int cpf = Convert.ToInt32(Console.ReadLine());
                        ShowClienteByCPF(cpf);
                    break;
                    case 2:
                        Console.WriteLine("Informe o nome: ");
                        string? name = Console.ReadLine();
                        ShowClienteBynome(nome);
                    break;
                    case 3:
                        ShowAll();
                    break;
                    case 0:
                    break;
                    default:
                        aux = -1;
                        Console.WriteLine("Opção Inválida!");
                    break;
                }
            }
            while (aux != 0);
        }

      private void ShowAll()
        {
            List<Clientes> result = clientesController.GetAll();
            foreach (Clientes cliente in result) {
                Console.WriteLine("Nome do Cliente: " + cliente?.nome?.ToString());
                Console.WriteLine("CPF do Cliente: " + cliente?.cpf.ToString());
                Console.WriteLine("Email do Cliente: " + cliente?.email?.ToString());
                if(cliente?.alugado != null)
                {
                    Console.WriteLine("Livro locado: " + cliente?.alugado.carName);
                }                
            }
        }

        private void ShowCustomerByCPF(int cpf) {
                Clientes clientes = clientesController.Get(cpf);
                if (clientes != null) {
                    Console.WriteLine("Nome do Cliente: " + clientes?.nome?.ToString());
                    Console.WriteLine("CPF do Cliente: " + clientes?.cpf.ToString());
                    Console.WriteLine("Email do Cliente: " + clientes?.email?.ToString());
                    if(clientes?.locado != null)
                    {
                        Console.WriteLine("Livro locado: " + clientes?.alugado.carName);
                    }
                }
                else {
                    Console.WriteLine($"Cliente de CPF {cpf} não encontrado!");
                }
    }
            
        public void EditbyCPF(){
            Console.WriteLine("Informe o CPF: ");
            int cpf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o NOVO nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o NOVO email: ");
            string email = Console.ReadLine();

            clientesController.Edit(cpf, nome, email);
        }



       private void ShowCustomerByName(string name) {
            List<Clientes> result = clientesController.GetByName(nome);
            if (result == null) {
                Console.WriteLine("Não encontrado!");
                return;
            }

            if (result.Count == 0) {
                Console.WriteLine("Não encontrado!");
                return;
            }

            foreach (Clientes clientes in result) {
                Console.WriteLine("Nome do Cliente: " + clientes?.nome?.ToString());
                Console.WriteLine("CPF do Cliente: " + clientes?.cpf.ToString());
                Console.WriteLine("Email do Cliente: " + clientes?.email?.ToString());
                if(clientes?.alugado != null)
                {
                    Console.WriteLine("Livro locado: " + clientes?.alugado.carName);
                }       
                }
            }
        }
    }