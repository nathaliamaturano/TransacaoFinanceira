using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransacaoFinanceira.Models;

namespace TransacaoFinanceira.Service
{
    class TransacaoFinanceiraService : AcessoDados
    {
        public void Transferencia(Transacao transacao)
        {
            ContasSaldo contaSaldoOrigem = getSaldo<ContasSaldo>(transacao.contaOrigem);
            Console.WriteLine("Conta Origem  {0}   Saldo Origem {1} Valor {2}", contaSaldoOrigem.conta, contaSaldoOrigem.saldo, transacao.valor);
            if (contaSaldoOrigem.saldo < transacao.valor)
                Console.WriteLine("Transacao numero {0 } foi cancelada por falta de saldo", transacao.correlationId);
            else
            {
                ContasSaldo contaSaldoDestino = getSaldo<ContasSaldo>(transacao.contaDestino);
                Console.WriteLine("Conta Destino   {0}     Saldo Destino {1}", contaSaldoDestino.conta, contaSaldoDestino.saldo);
                contaSaldoOrigem.saldo -= transacao.valor;
                contaSaldoDestino.saldo += transacao.valor;
                Console.WriteLine("Transacao numero {0} foi efetivada com sucesso! Novos saldos: Conta Origem:{1} | Conta Destino: {2}", transacao.correlationId, contaSaldoOrigem.saldo, contaSaldoDestino.saldo);
            }
        }
    }
}
