using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_1._0
{
    public partial class FormCantina : Form
    {
        public FormCantina()
        {
            InitializeComponent();

            listBoxCardapio.DisplayMember = "Nome";
            listBoxCardapio.ValueMember = "Preco";

            listBoxCardapio.Items.Add(new Produtos() { Nome = "Pão de Quiejo - R$ 3,50", Preco = 3.50 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Coxinha - R$ 5,00", Preco = 5.00 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Pastel de Carne - R$ 6,00", Preco = 6.00 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Pastel de Queijo - R$ 5,50", Preco = 5.50 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Hambúrguer Simples - R$ 8,00", Preco = 8.00 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Hambúrguer com Queijo - R$ 9,00", Preco = 9.00 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "X-Tudo - R$ 12,00", Preco = 12.00 });
            //Comidas

            listBoxCardapio.Items.Add(new Produtos() { Nome = "Suco Natural (300ml) - R$ 4,00", Preco = 4.00 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Refrigerante Lata - R$ 4,50", Preco = 4.50 });
            listBoxCardapio.Items.Add(new Produtos() { Nome = "Água Mineral (500ml) - R$ 2,50", Preco = 2.50 });
            //Bebidas

        }

        private void FormCantina_Load(object sender, EventArgs e)
        {

        }

        private void listBoxCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxComanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCardapio_Click(object sender, EventArgs e)
        {

        }

        private void labelComanda_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBoxCardapio.SelectedItem != null)
            {
                var produtoSelecionado = (Produtos)listBoxCardapio.SelectedItem;
                var quantidade = (int)nudQuantidade.Value;
                for (int i = 0; i < quantidade; i++)
                {
                    listBoxComanda.Items.Add(produtoSelecionado);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto do cardápio.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormCantina.ActiveForm.Close();
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
