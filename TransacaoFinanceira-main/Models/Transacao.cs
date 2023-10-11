using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Models
{
    class Transacao
    {
        public Transacao(int correlationId, DateTime datetime, long contaOrigem, long contaDestino, decimal valor)
        {
            this.correlationId = correlationId;
            this.datetime = datetime;
            this.contaOrigem = contaOrigem;
            this.contaDestino = contaDestino;
            this.valor = valor;
        }
        public int correlationId { get; set; }
        public DateTime datetime { get; set; }
        public long contaOrigem { get; set; }
        public long contaDestino { get; set; }
        public decimal valor { get; set; }
    }
}
