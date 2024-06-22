using _240401_01.Models;

bool aux = true;
do{

Console.WriteLine("***********************");
Console.WriteLine("Meu Programa de Pedidos");
Console.WriteLine("***********************");
Console.WriteLine();

Console.WriteLine("1 - Clientes");
Console.WriteLine("2 - Produtos");
Console.WriteLine("3 - Pedidos");
Console.WriteLine("0 - SAIR DESTA BAGAÇA!");

int menu = 0;

try {
    switch(menu)
    {
        case 1:
        break;
    }
}

catch{
    Console.WriteLine("OPÇÃO INVÁLIDA!");
    aux = true;

}




}while(aux);


/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

// Construtor de Instanciação
Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "bocamole@pixote.net";

// Construtor por atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@pixote.com"
};
*/