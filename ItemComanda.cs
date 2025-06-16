using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_1._0
{
    public class ItemComanda : INotifyPropertyChanged
    {
        private int _quantidade;
        public Produto Produto { get; set; }
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
                OnProperityCharged(nameof(Quantidade));
                OnProperityCharged(nameof(Total));
            }
        }

        public double Total
        {
            get { return Produto.Preco * Quantidade; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ItemComanda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        protected virtual void OnProperityCharged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"{Quantidade} x {Produto.Nome}";
        }
    }
}
