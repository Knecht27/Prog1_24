using System;

namespace Imobiliaria
{
    class Program
    {
        static void Main()
        {
            var imovel = new Imovel
            {
                Id = 1,
                Nome = "Sitio Rio Das Antas",
                Descricao = "Localidade no interior de Rio das Antas com 50000m²",
                Valor = 100.000,
                NroComodos = 6,
                TipoImovel = "Colonia",
                Localidade = "Rural",
                TipoNegocio = "Venda"
            };

            Console.WriteLine($"ID: {imovel.Id}");
            Console.WriteLine($"Nome: {imovel.Nome}");
            Console.WriteLine($"Descrição: {imovel.Descricao}");
            Console.WriteLine($"Valor: {imovel.Valor:C}");
            Console.WriteLine($"Cômodos: {imovel.NroComodos}");
            Console.WriteLine($"Tipo: {imovel.TipoImovel}");
            Console.WriteLine($"Local: {imovel.Localidade}");
            Console.WriteLine($"Negócio: {imovel.TipoNegocio}");
        }
    }

    class Imovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int NroComodos { get; set; }
        public string TipoImovel { get; set; }
        public string Localidade { get; set; }
        public string TipoNegocio { get; set; }
    }
}
