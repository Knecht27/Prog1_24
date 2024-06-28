using AluguelDeCarros.Models;
using AluguelDeCarros.Views;

do{
        Console.WriteLine("*******************");
    Console.WriteLine("Alugel de carros");
    Console.WriteLine("*******************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Carros");
    Console.WriteLine("0 - Sair");

    int menu = 0;

    menu = Convert.ToInt32(Console.ReadLine());
    switch(menu) {
        case 1:
            ClientesView clientesView = new ClientesView();
        break;
        case 2:
            CarsView carsView = new CarsView();
        break;
        case 0:
            aux = false;
        break;
        default:
            Console.WriteLine("Opção inválida.");
        break;
    }

    Console.WriteLine("Sistema encerrado!");
        
} while(aux);