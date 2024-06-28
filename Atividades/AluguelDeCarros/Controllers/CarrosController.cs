using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using AluguelDeCarros.Models;
using AluguelDeCarros.Utils;
using AluguelDeCarros.Repository;
using System.Reflection.Metadata.Ecma335;

namespace AluguelDeCarros.Controllers
{
    public class CarrosController
    {
        private RepositorioCarros repositorioCarros = new RepositorioCarros();
    
    public CarrosController()
    {
        repositorioCarros = new RepositorioCarros();
    }

    public void Insert(Carros carros)
    {
        repositorioCarros.Save(carros);
    }

    public void Edit(int id, string nome, int preco)
    {
        repositorioCarros.EditaCarros(id, nome, preco);
    }

    public void Remove(int id)
    {
        repositorioCarros.RemoveCarros(id);
    }

    public Carros Get(int id)
    {
       return repositorioCarros.Retrieve(id);
    }
    

    public List<Carros> GetAll()
    {
        return repositorioCarros.RetrieveAll();
    }

    public List<Carros> GetByName(string nome)
    {
        return repositorioCarros.RetrieveByName(nome);
    }

    public void AlugaCarros(int id, int cpf)
    {
        repositorioCarros.AlugaCarros(id,cpf);
    }

    public void DevolveCarro(int id, int cpf)
    {
        repositorioCarros.DevolveCarro(id,cpf);
    }
    }
}