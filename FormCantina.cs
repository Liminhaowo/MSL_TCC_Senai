using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_1._0
{
    public partial class FormCantina : Form
    {
        public double total = 0;
        public int quantidade = 0;

        public FormCantina()
        {
            InitializeComponent();

            nudQuantidade.Minimum = 1;

            listBoxCardapio.DisplayMember = "Nome";

            listBoxCardapio.Items.Add(new Produto() { Nome = "Pão de Quiejo - R$ 3,50", Preco = 3.50 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Coxinha - R$ 5,00", Preco = 5.00 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Pastel de Carne - R$ 6,00", Preco = 6.00 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Pastel de Queijo - R$ 5,50", Preco = 5.50 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Hambúrguer Simples - R$ 8,00", Preco = 8.00 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Hambúrguer com Queijo - R$ 9,00", Preco = 9.00 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "X-Tudo - R$ 12,00", Preco = 12.00 });
            //Comidas

            listBoxCardapio.Items.Add(new Produto() { Nome = "Suco Natural (300ml) - R$ 4,00", Preco = 4.00 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Refrigerante Lata - R$ 4,50", Preco = 4.50 });
            listBoxCardapio.Items.Add(new Produto() { Nome = "Água Mineral (500ml) - R$ 2,50", Preco = 2.50 });
            //Bebidas

            listBoxComanda.DisplayMember = "Nome";
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

        private void labelNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void labelPagamento_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBoxCardapio.SelectedItem != null)
            {
                int quantidade = (int)nudQuantidade.Value;

                Produto produto = (Produto)listBoxCardapio.SelectedItem;

                ItemComanda item = new ItemComanda()
                {
                    Produto = produto,
                    Quantidade = quantidade
                };

                listBoxComanda.Items.Add(item);

                total += item.Total;

                listBoxCardapio.ClearSelected();
            }
            else
            {
                MessageBox.Show("Selecione um produto do cardápio.");
            }

            nudQuantidade.Value = 1;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxComanda.SelectedItem != null)
            {
                ItemComanda itemSelecionado = (ItemComanda)listBoxComanda.SelectedItem;

                int quantidadeRemover = (int)nudQuantidade.Value;

                if (quantidadeRemover >= itemSelecionado.Quantidade)
                {
                    total -= itemSelecionado.Total;
                    listBoxComanda.Items.Remove(itemSelecionado);
                }
                else
                {
                    itemSelecionado.Quantidade -= quantidadeRemover;
                    total -= itemSelecionado.Produto.Preco * quantidadeRemover;

                    int index = listBoxComanda.Items.IndexOf(itemSelecionado);
                    listBoxComanda.Items[index] = itemSelecionado;
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto da comanda.");
            }

            nudQuantidade.Value = 1;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (listBoxComanda.Items.Count == 0)
            {
                MessageBox.Show("Adicione itens à comanda.");
                return;
            }

            if (cboxPagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o método de pagamento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Digite o nome do cliente.");
                return;
            }

            string cliente = txtNomeCliente.Text.Trim();

            if (!string.IsNullOrEmpty(cliente))
            {
                cliente = char.ToUpper(cliente[0]) + cliente.Substring(1).ToLower();
            }

            StringBuilder resumo = new StringBuilder();

            foreach (ItemComanda item in listBoxComanda.Items)
            {
                resumo.AppendLine(item.Nome);
            }

            DateTime dataComanda = dateComandaDia.Value.Date;
            DateTime horaComanda = dateComandaHoras.Value;

            string dataHoraComanda = $"{dataComanda:dd/MM/yyyy} - {horaComanda:HH:mm:ss}";

            switch (cboxPagamento.SelectedIndex)
            {
                case 0:
                    if (checkBoxViagem.Checked)
                    {
                        MessageBox.Show(
                            $"Nome do Cliente: {cliente}\n\n" +
                            $"Extrato:\n{resumo}\n" +
                            $"Total a ser pago: R${total:F2}\n\n" +
                            $"Método de Pagamento: {cboxPagamento.SelectedItem}\n\n" +
                            $"Data e Hora: {dataHoraComanda}" +
                            $"Pedido Para Viagem",
                            "COMANDA"
                            );
                    }
                    else
                    {
                        MessageBox.Show(
                           $"Nome do Cliente: {cliente}\n\n" +
                           $"Extrato:\n{resumo}\n" +
                           $"Total a ser pago: R${total:F2}\n\n" +
                           $"Método de Pagamento: {cboxPagamento.SelectedItem}\n\n" +
                           $"Data e Hora: {dataHoraComanda}",
                           "COMANDA"
                           );
                    }
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor pago:", "PAGAMENTO");
                        if (double.TryParse(input, out double valorPago))
                        {
                            if (valorPago >= total)
                            {
                                double troco = valorPago - total;
                                MessageBox.Show($"Troco: R${troco:F2}", "TROCADO");
                            }
                            else
                            {
                                MessageBox.Show("Valor pago insuficiente.", "ERRO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido.", "ERRO");
                        }
                    
                        break;
                    

                case 1:
                    MessageBox.Show(
                        $"Cliente: {cliente}\n\n" +
                        $"Extrato:\n{resumo}\n" +
                        $"Total a pagar: R${total:F2}\n\n" +
                        $"Pagamento: {cboxPagamento.SelectedItem}\n\n" +
                        $"Data: {dataHoraComanda}",
                        "COMANDA"
                        );
                    break;

                case 2:
                    MessageBox.Show(
                         $"Nome do Cliente: {cliente}\n\n" +
                         $"Extrato:\n{resumo}\n" +
                         $"Total a ser pago: R${total:F2}\n\n" +
                         $"Método de Pagamento: {cboxPagamento.SelectedItem}\n\n" +
                         $"Data e Hora: {dataHoraComanda}",
                         "COMANDA"
                         );
                    break;

                default:
                    break;
            }

            txtNomeCliente.Clear();
            listBoxComanda.Items.Clear();
            cboxPagamento.SelectedIndex = -1;
            total = 0;
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateComandaDia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxViagem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
