using System;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Calculadora!");

            Console.WriteLine("========================");

            Console.WriteLine("Digite o primeiro valor:");
            var primeiroValor = Console.ReadLine() ?? "0";

            Console.WriteLine("Digite o segundo valor:");
            var segundoValor = Console.ReadLine() ?? "0";

            Console.WriteLine("Qual operação?");
            Console.WriteLine("1) Adição");
            Console.WriteLine("2) Subtração");
            Console.WriteLine("3) Muliplicação");
            Console.WriteLine("4) Divisão");
            var operacao = Console.ReadLine() ?? string.Empty;

            var resultado = 0.0;
            switch (operacao)
            {
                case "1":
                    resultado = Convert.ToDouble(primeiroValor) + Convert.ToDouble(segundoValor);
                    break;
                case "2":
                    resultado = Convert.ToDouble(primeiroValor) - Convert.ToDouble(segundoValor);
                    break;
                case "3":
                    resultado = Convert.ToDouble(primeiroValor) * Convert.ToDouble(segundoValor);
                    break;
                case "4":
                    resultado = Convert.ToDouble(primeiroValor) / Convert.ToDouble(segundoValor);
                    break;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("O resultado é: " + resultado); // Não usar
            Console.WriteLine("O resultado é: {0}", resultado);
            Console.WriteLine($"O resultado é: {resultado}");

            StringBuilder sb = new StringBuilder()
                           .Append("O resultado é: ")
                           .Append(resultado);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("========================");
        }
    }
}
