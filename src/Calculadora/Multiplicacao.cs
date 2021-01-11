using System;

namespace Calculadora
{
    public class Multiplicacao : IOperacao
    {
        private double _primeiroValor;
        private double _segundoValor;

        public Multiplicacao(double primeiroValor, double segundoValor)
        {
            _primeiroValor = primeiroValor;
            _segundoValor = segundoValor;
        }

        public double Resultado()
        {
            return _primeiroValor * _segundoValor;
        }
    }
}
