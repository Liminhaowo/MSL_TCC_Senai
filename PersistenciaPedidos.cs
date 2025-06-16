using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cantina_1._0;

namespace Cantina_1._0
{
    public static class AguardoDePedidos 
    {
        public static List<Pedido> Pedidos = new List<Pedido>();
    }

    public static class BalcaoPedidos
    {
        public static BindingList<Pedido> PedidosEmEspera = new BindingList<Pedido>();
        public static BindingList<Pedido> PedidosEntregues = new BindingList<Pedido>();

        static BalcaoPedidos()
        {
            PedidosEntregues = new BindingList<Pedido>();
            PedidosEmEspera = new BindingList<Pedido>();
        }
    }

    public static class CozinhaPedidos
    {
        public static BindingList<Pedido> PedidosPreparando = new BindingList<Pedido>();
        public static BindingList<Pedido> PedidosProntos = new BindingList<Pedido>();

        static CozinhaPedidos()
        {
            PedidosPreparando = new BindingList<Pedido>();
            PedidosProntos = new BindingList<Pedido>();
        }
    }
}
