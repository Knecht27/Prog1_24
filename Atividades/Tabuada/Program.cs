using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o operador aritmético (+, -, *, /): ");
            char operador = Console.ReadKey().KeyChar;
            Console.WriteLine();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    double resultado = 0;

                    switch (operador)
                    {
                        case '+':
                            resultado = i + j;
                            break;
                        case '-':
                            resultado = i - j;
                            break;
                        case '*':
                            resultado = i * j;
                            break;
                        case '/':
                            resultado = (double)i / j;
                            break;
                        default:
                            Console.WriteLine("Operador inválido. Use +, -, *, ou /.");
                            return;
                    }

                    Console.WriteLine($"{i} {operador} {j} = {resultado}");
                }
            }
        }
    }
}
