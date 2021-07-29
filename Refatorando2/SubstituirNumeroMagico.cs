using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatorando2
{
    partial class Program
    {
        private const decimal ALIQUOTA_ICMS_PADRAO = 0.15m;
        private const decimal ALIQUOTA_ICMS_SP = 0.18m;
        private const string UF_SP = "SP";

        public static decimal CalcularValor(decimal valorProdutos, string uf)
        {
            if (valorProdutos < 0)
            {
                throw new ArgumentOutOfRangeException("Valor não pode ser negativo ");
            }
            if (uf == UF_SP)
            {
                return valorProdutos * ALIQUOTA_ICMS_SP;
            }
            return valorProdutos * ALIQUOTA_ICMS_PADRAO;
        }
    }
}
