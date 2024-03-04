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


// Aula 240304

// Substituindo conteudo de strings

string nomeCompleto = "Alex Kophal Knecht";
nomeCompleto = nomeCompleto.Replace("Kopahl", "Jaguara" );
Console.WriteLine(nomeCompleto);

// Comparação de Strings
bool isNomeEqual = (nomeCompleto == "Alex Kophal Knecht");

bool isNomeEqual2 = string.Equals(nomeCompleto, "Alex Jaguara Knecht");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo Resultado: {isNomeEqual2}");

