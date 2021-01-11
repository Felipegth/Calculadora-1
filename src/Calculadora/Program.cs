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
            var primeiroValor = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o segundo valor:");
            var segundoValor = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Qual operação?");
            Console.WriteLine("1) Adição");
            Console.WriteLine("2) Subtração");
            Console.WriteLine("3) Muliplicação");
            Console.WriteLine("4) Divisão");
            var operacao = Console.ReadLine() ?? string.Empty;

            IOperacao instanciaOperacao = null;
            switch (operacao)
            {
                case "1":
                    instanciaOperacao = new Soma(primeiroValor, segundoValor);
                    break;
                case "2":
                    instanciaOperacao = new Divisao(primeiroValor, segundoValor);
                    break;
                case "3":
                    instanciaOperacao = new Multiplicacao(primeiroValor, segundoValor);
                    break;
                case "4":
                    instanciaOperacao = new Divisao(primeiroValor, segundoValor);
                    break;
            }

            var operacoes = new Operacoes(instanciaOperacao);
            Console.WriteLine("------------------------");
            Console.WriteLine("O resultado é: " + operacoes.Resultado()); // Não usar
            Console.WriteLine("O resultado é: {0}", operacoes.Resultado());
            Console.WriteLine($"O resultado é: {operacoes.Resultado()}");

            StringBuilder sb = new StringBuilder()
                           .Append("O resultado é: ")
                           .Append(operacoes.Resultado());
            Console.WriteLine(sb.ToString());

            Console.WriteLine("========================");
        }
    }
}
