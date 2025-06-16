using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_1._0
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public bool Cozinha { get; set; }
        public Produto(string nome, double preco, bool cozinha = true)
        {
            Nome = nome;
            Preco = preco;
            Cozinha = cozinha;
        }

        public override string ToString()
        {
            return $"{Nome} - R$ {Preco:F2}";
        }
    }
}

