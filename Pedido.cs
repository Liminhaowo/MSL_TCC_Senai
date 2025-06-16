using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_1._0
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataEHora { get; set; }
        public List<ItemComanda> Itens { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        public bool ParaViagem { get; set; }
        public Pedido (string nomeCliente, DateTime dataEHora, List<ItemComanda> itens, double total, bool paraViagem)
        {
            NomeCliente = nomeCliente;
            DataEHora = dataEHora;
            Itens = itens;
            Total = total;
            Status = "Em Preparo";
            ParaViagem = paraViagem;
            //DataEHora = dataEhora;
        }
        public override string ToString()
        {
            return $"Pedido {IdPedido} - {NomeCliente} - Total: R$ {Total:F2} - Status: {Status}";
        }
    }
}
