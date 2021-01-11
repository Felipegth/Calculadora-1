using System;

namespace Calculadora
{
    public class Operacoes
    {
        private IOperacao _operacao;

        public Operacoes(IOperacao operacao)
        {
            _operacao = operacao;
        }

        public double Resultado()
        {
            return _operacao.Resultado();
        }
    }
}
