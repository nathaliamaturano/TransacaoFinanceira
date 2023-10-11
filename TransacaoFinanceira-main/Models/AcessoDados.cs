using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoFinanceira.Models
{
    class AcessoDados
    {
        Dictionary<int, decimal> Saldos { get; set; }
        private List<ContasSaldo> TabelaSaldos;

        public AcessoDados()
        {
            TabelaSaldos = new List<ContasSaldo>
            {
                new ContasSaldo(938485762, 180),
                new ContasSaldo(347586970, 1200),
                new ContasSaldo(2147483649, 0),
                new ContasSaldo(675869708, 4900),
                new ContasSaldo(238596054, 478),
                new ContasSaldo(573659065, 787),
                new ContasSaldo(210385733, 10),
                new ContasSaldo(674038564, 400),
                new ContasSaldo(563856300, 1200)
            };

            Saldos = new Dictionary<int, decimal>();
            this.Saldos.Add(938485762, 180);
        }

        public T getSaldo<T>(long id)
        {
            return (T)Convert.ChangeType(TabelaSaldos.Find(x => x.conta == id), typeof(T));
        }

        public bool atualizar<T>(T dado)
        {
            try
            {
                ContasSaldo item = (dado as ContasSaldo);
                TabelaSaldos.RemoveAll(x => x.conta == item.conta);
                TabelaSaldos.Add(dado as ContasSaldo);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
