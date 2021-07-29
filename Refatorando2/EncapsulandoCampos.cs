using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatorando2
{
    partial class Programa
    {
        void Main()
        {
            var conta = new ContaCorrente();
            conta.Depositar(100);
            conta.Sacar(75);

        }
    }

    class ContaCorrente
    {
        private decimal saldo;

        public decimal Saldo { get => saldo;}

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            this.saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }
    }
}
