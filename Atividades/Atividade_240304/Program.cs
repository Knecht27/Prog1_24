using System;

namespace CalculadoraAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o operador (+, -, *, /):");
            char operador = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case '/':
                    if (segundoNumero != 0)
                        resultado = primeiroNumero / segundoNumero;
                    else
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    break;
                default:
                    Console.WriteLine("Operador inválido. Use +, -, *, ou /.");
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
