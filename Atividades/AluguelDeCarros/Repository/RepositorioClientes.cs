using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using AluguelDeCarros.Models;
using AluguelDeCarros.Data;
using System.Security;

namespace AluguelDeCarros.Repository
{
    public class RepositorioClientes
    {
        //Adiciona novo cliente
        public void Save(Clientes clientes)
        {
            DataSet.Clientes.Add(clientes);
        }
        // pesquisa por cpf
        public Clientes? Retrieve(int cpf)
        {
            foreach (var p in DataSet.Clientes)
            {
                if (p.cpf == cpf)
                {
                    return p;
                }
            }
            return null;
        }
        //Pesquisa por nome
        public List<Clientes> RetrieveByName(string name)
        {
            List<Clientes> retorno = new List<Clientes>();
            foreach (var p in DataSet.Clientes)
            {
                if (p.nome.Contains(name))  
                {
                    retorno.Add(p);
                }
            }
            return retorno;
        }
        //Pesquisa a lista inteira
        public List<Clientes> RetrieveAll()
        {
            return DataSet.Clientes;
        }
        //edita informações Clientes
        public void EditaClientes(int cpf, string nome, string email)
        {
            foreach (var p in DataSet.Clientes)
            {
                if (p.cpf == cpf)
                {
                    p.nome = nome;
                    p.email = email;
                }
            }
        }
        //Apaga clientes
        public bool ApagaCliente(int cpf)
        {
            return DataSet.Clientes.Remove(this.Retrieve(cpf));
        }
        //Aluga carros
        public void AlugaCarros(int cpf, int id)
        {
            foreach (Carros c in DataSet.Acervo)
            {
                if (c.carID == id)
                {
                    foreach (var p in DataSet.Clientes)
                    {
                        if (p.cpf == cpf)
                        {
                            p.alugado = c;
                            c.rentedBy = p;
                        }
                    }
                }
            }
        }
        //Devolve carros
        public void DevolveCarros(int cpf, int id)
        {
            foreach (Carros c in DataSet.Acervo)
            {
                if (c.carID == id)
                {
                    Carros carros = c;
                    foreach (var p in DataSet.Clientes)
                    {
                        if (p.cpf == cpf)
                        {
                            p.alugado = null;
                            c.rentedBy = null;
                        }
                    }
                }
            }
        }

        //
    }
}