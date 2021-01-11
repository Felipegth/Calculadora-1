using System;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static double primeiroValor;
        static double segundoValor;
        static int operacao;
        static IOperacao tipoOperacao;

        static void Main(string[] args)
        {
            CriaTelaEMenuOperacoes();

            ExecutaOperacao();

            ExibeResultado();
        }

        static void CriaTelaEMenuOperacoes()
        {
            Console.WriteLine("Bem vindo a Calculadora!");

            Console.WriteLine("========================");

            Console.WriteLine("Digite o primeiro valor:");
            primeiroValor = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o segundo valor:");
            segundoValor = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Qual operação?");
            Console.WriteLine("1) Adição");
            Console.WriteLine("2) Subtração");
            Console.WriteLine("3) Muliplicação");
            Console.WriteLine("4) Divisão");
            operacao = Convert.ToInt32(Console.ReadLine() ?? "0");
        }

        static void ExecutaOperacao()
        {
            switch ((OperacaoEnum)operacao)
            {
                case OperacaoEnum.SOMA:
                    tipoOperacao = new Soma(primeiroValor, segundoValor);
                    break;

                case OperacaoEnum.SUBTRACAO:
                    tipoOperacao = new Divisao(primeiroValor, segundoValor);
                    break;

                case OperacaoEnum.MULTIPLICACAO:
                    tipoOperacao = new Multiplicacao(primeiroValor, segundoValor);
                    break;

                case OperacaoEnum.DIVISAO:
                    tipoOperacao = new Divisao(primeiroValor, segundoValor);
                    break;
            }
        }

        static void ExibeResultado()
        {
            var operacoes = new Operacoes(tipoOperacao);

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