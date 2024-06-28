using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using AluguelDeCarros.Models;
using AluguelDeCarros.Utils;
using AluguelDeCarros.Repository;

namespace AluguelDeCarros.Controllers
{
    public class ClientesController
    {
        private RepositorioClientes repositorioClientes;

        public ClientesController()
        {
            repositorioClientes = new RepositorioClientes();
        }

        public void Insert(Clientes clientes)
        {
            repositorioClientes.Save(clientes);
        }

        public void Edit(int cpf, string nome, string email)
        {
            repositorioClientes.EditaClientes(cpf, nome, email);
        }

        public bool Remove(int cpf)
        {
            return repositorioClientes.ApagaCliente(cpf);
        }

        public Clientes Get(int cpf)
        {
            return repositorioClientes.Retrieve(cpf);
        }

        public List<Clientes> GetAll()
        {
            return repositorioClientes.RetrieveAll();
        }

        public List<Clientes> GetByName (string nome)
        {
            return repositorioClientes.RetrieveByName(nome);
        }
        
        public void AlugaCarros(int id, int cpf)
        {
            repositorioClientes.AlugaCarros(cpf,id);
        }

        public void DevolveCarros(int id, int cpf)
        {
            repositorioClientes.DevolveCarros(cpf,id);
        }

    }
}