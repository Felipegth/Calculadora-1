using System;

namespace Calculadora
{
    public class Soma : IOperacao
    {
        private double _primeiroValor;
        private double _segundoValor;

        public Soma(double primeiroValor, double segundoValor)
        {
            _primeiroValor = primeiroValor;
            _segundoValor = segundoValor;
        }

        public double Resultado()
        {
            return _primeiroValor + _segundoValor;
        }
    }
}
