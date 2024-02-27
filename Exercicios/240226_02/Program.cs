// Trabalhando com váriaveis em C#

//Strings
//declarando váriavel sem inicialização
string message1 = null; 

//Inicializar a variavel com nulo
string message2 = null;

//Inicializar a string vazia
string message3 = System.String.Empty; // ""; 

//declarar uma string com valor implicito
var message4 = "Uma mensagem aleatória"; 

Console.WriteLine( message4 ); 

//Concatenando strings
string concat = (message1 == null ? "" : message1) +
                "." + message2 + "." +
                message3 + "." + message4;
Console.WriteLine("\n" + concat);

Console.WriteLine( 
    "A temperatura do hoje {0:D} é {1}°C"
     ,DateTime.Now
      ,23 
);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Aoba bão, {nome}! Bão que um mé?";
Console.WriteLine(resultado);

