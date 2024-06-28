using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using AluguelDeCarros.Models;
using AluguelDeCarros.Data;

namespace AluguelDeCarros.Repository
{
    public class RepositorioCarros
    {
        //Adiciona novo carro
        public void Save(Carros carros)
        {
            DataSet.Acervo.Add(carros);
        }

        //Pesquisa por ID
        public Carros? Retrieve(int id)
        {
            foreach (Carros c in DataSet.Acervo)
            {
                if (c.carID == id)
                {
                    return c;
                }
            }
            return null;
        }
        //Pesquisa por nome
        public List<Carros> RetrieveByName(string nome)
        {
            List<Carros> retorno = new List<Carros>();
            foreach (var c in DataSet.Acervo)
            {
                if(c.carName.Contains(nome))
                {
                    retorno.Add(c);
                }
            }
            return retorno;
        }
        //Pesquisa pela lista
        public List<Carros> RetrieveAll()
        {
            return DataSet.Acervo;
        }
        //edita carros
        public void EditaCarros(int id, string nome, int preco)
        {
            foreach (var c in DataSet.Acervo)
            {
                if (c.carID == id)
                {
                    c.carPrice = preco;
                    c.carName = nome;
                }
            }
        }
        //Remove carros
        public void RemoveCarros(int id)
        {
            List<Carros> deleteList = new List<Carros>();
            foreach (var c in DataSet.Acervo)
            {
                if (c.carID == id)
                {
                    deleteList.Add(c);
                }
            }
            foreach (var c in deleteList)
            {
                DataSet.Acervo.Remove(c);
            }
        }
        //Aluga Carros
        public void AlugaCarros(int id, int cpf)
        {
            foreach (Carros c in DataSet.Acervo)
            {
                if (c.carID == id )
                {
                    foreach (Clientes p in DataSet.Clientes)
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
        public void DevolveCarro(int id, int cpf)
        {
            foreach (Carros c in DataSet.Acervo)
            {
                if (c.carID == id)
                {
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