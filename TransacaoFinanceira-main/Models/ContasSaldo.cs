using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Models
{
    class ContasSaldo
    {
        public ContasSaldo(long conta, decimal saldo)
        {
            this.conta = conta;
            this.saldo = saldo;
        }
        public long conta { get; set; }
        public decimal saldo { get; set; }
    }
}
