// Ficha cadastral
Console.WriteLine(" Bem vindo ao cadastro de jaguaras!");
Console.WriteLine("");
Console.WriteLine("Preencha os campos a seguir para realizar o cadastro básico.");

Console.WriteLine("Nome");
string nome = string.Empty;
nome = Console.ReadLine();

Console.WriteLine("E-mail");
string Email = string.Empty;
Email = Console.ReadLine();

Console.WriteLine("Data do seu nascimento");
string DataDeNascimento = string.Empty;
DataDeNascimento = Console.ReadLine();

Console.WriteLine("Sexo e Genero");
string sexo_genero = string.Empty;
sexo_genero = Console.ReadLine();

Console.WriteLine("Agora o cadastro avançado.");

// Campo do endereço

Console.WriteLine("Cep");
string cep = string.Empty;
cep = Console.ReadLine();

Console.WriteLine("Nome da rua");
string rua = string.Empty;
rua = Console.ReadLine();

Console.WriteLine("Número residencial");
string numero = string.Empty;
Console.ReadLine();

Console.WriteLine("Bairro");
string bairro = string.Empty;
Console.ReadLine();

Console.WriteLine("Cidade");
string cidade = string.Empty;
Console.ReadLine();

Console.WriteLine("Estado");
string unidade_federativa = string.Empty;
Console.ReadLine();

Console.WriteLine("País");
string pais = string.Empty;
Console.ReadLine();

// Parte para imprimir os resultados
string cadastro_completo = $"Aqui está seu cadastro completo:\n {nome}\n {Email}\n {DataDeNascimento}\n {sexo_genero}\n {cep}\n {rua}\n {numero}\n {bairro}\n {cidade}\n {unidade_federativa}\n {pais}\n";
Console.WriteLine(cadastro_completo);
