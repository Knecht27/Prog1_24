using _240401_07.Models;

Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddres = "jaguara@bundão.yahoo";

// Construtor de Instanciação
Customer c2 = new Customer(2);
c1.Name = "Boca de caçapa";
c1.EmailAddres = "bocadecacapa@bundão.yahoo";

// Construtor  por atribuição 
Customer c3 = new Customer{
    Name = "Teodoro",
    EmailAddres = "teodoro@bundão.yahoo"
};