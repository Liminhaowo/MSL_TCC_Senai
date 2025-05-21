using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_1._0
{
    internal class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }
    }

    internal class  ItemComanda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public double Total => Produto.Preco * Quantidade;

        public string Nome => $"{Produto.Nome} x {Quantidade}";
    }
}
