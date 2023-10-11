using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TransacaoFinanceira.Models;
using TransacaoFinanceira.Service;


//Obs: Voce é livre para implementar na linguagem de sua preferência, desde que respeite as funcionalidades e saídas existentes, além de aplicar os conceitos solicitados.

namespace TransacaoFinanceira
{
    class Program
    {
        public static void Main(string[] args)
        {
            var transacoes = new List<Transacao>() {
                new Transacao(1, DateTime.Parse("09/09/2023 14:15:00"), 938485762, 2147483649, 150),
                new Transacao(2, DateTime.Parse("09/09/2023 14:15:05"), 2147483649, 210385733, 149),
                new Transacao(3, DateTime.Parse("09/09/2023 14:15:29"), 347586970, 238596054, 1100),
                new Transacao(4, DateTime.Parse("09/09/2023 14:17:00"), 675869708, 210385733, 5300),
                new Transacao(5, DateTime.Parse("09/09/2023 14:18:00"), 238596054, 674038564, 1489),
                new Transacao(6, DateTime.Parse("09/09/2023 14:18:20"), 573659065, 563856300, 49),
                new Transacao(7, DateTime.Parse("09/09/2023 14:19:00"), 938485762, 2147483649, 44),
                new Transacao(8, DateTime.Parse("09/09/2023 14:19:01"), 573659065, 675869708, 150)
            };

            TransacaoFinanceiraService service = new TransacaoFinanceiraService();
            foreach (var item in transacoes)
            {
                service.Transferencia(item);
            }
        }
    }
}
