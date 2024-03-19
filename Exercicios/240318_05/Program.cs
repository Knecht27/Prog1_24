using _240318_05.Models;


Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Alex";
c1.LastName = "Kophal Knecht";
c1.BirthDate = new DateTime();
c1.EmailAddress = "alexkknecht@gmail.com";


Console.WriteLine($"Nome : {c1.FirstName} {c1.LastName}");
Console.WriteLine($"Email : {c1.EmailAddress}");


Address address1 = new Address();
address1.AddresId = 1;
address1.Street = "Cachoeira";
address1.District = "Interior";
address1.City = "Rio das Antas";
address1.Number = 00;
address1.FederalState = "SC";
address1.Country = "Brazil";
address1.ZipCode = "8955000";

c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS:");

foreach(var ad in c1.Addresses)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Rua {ad.Street}");
    Console.WriteLine($"Bairro; {ad.District}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"Cidade; {ad.City}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"País: {ad.Country}");
}