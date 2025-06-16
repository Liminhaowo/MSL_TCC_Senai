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

        private static int proximoIdPedido = 1;

        public FormCantina()
        {
            InitializeComponent();

            nudQuantidade.Minimum = 1;

            listBoxCardapio.DisplayMember = "Nome";
            listBoxComanda.DisplayMember = "Nome";

            listBoxCardapio.Items.Add(new Produto("Pão de Queijo - R$ 3,50", 3.50, false));
            listBoxCardapio.Items.Add(new Produto("Coxinha - R$ 5,00", 5.00, false));
            //Comidas Prontas

            listBoxCardapio.Items.Add(new Produto("Pastel de Carne - R$ 6,00", 6.00, true));
            listBoxCardapio.Items.Add(new Produto("Pastel de Queijo - R$ 5,50", 5.50, true));
            listBoxCardapio.Items.Add(new Produto("Hambúrguer Simples - R$ 8,00", 8.00, true));
            listBoxCardapio.Items.Add(new Produto("Hambúrguer c/Queijo - R$ 9,00", 9.0, true));
            listBoxCardapio.Items.Add(new Produto("X-Tudo - R$ 12,00", 12.00, true));
            //Comidas não Prontas

            listBoxCardapio.Items.Add(new Produto("Suco Natural (300ml) - R$ 4,00", 4.00, false));
            listBoxCardapio.Items.Add(new Produto("Refrigerante Lata - R$ 4,50", 4.50, false));
            listBoxCardapio.Items.Add(new Produto("Água Mineral (500ml) - R$ 2,50", 2.50, false));
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

        private void labelNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void labelPagamento_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBoxCardapio.SelectedItem != null)
            {
                int quantidade = (int)nudQuantidade.Value;
                Produto produto = (Produto)listBoxCardapio.SelectedItem;

                ItemComanda itemExistente = null;
                foreach (ItemComanda item in listBoxComanda.Items)
                {
                    if (item.Produto.Nome == produto.Nome)
                    {
                        itemExistente = item;
                        break;
                    }
                }

                if (itemExistente != null)
                {
                    double valorAntigo = itemExistente.Total;
                    itemExistente.Quantidade += quantidade;

                    total = total - valorAntigo + itemExistente.Total;

                    int index = listBoxComanda.Items.IndexOf(itemExistente);
                    listBoxComanda.Items[index] = itemExistente;
                    listBoxComanda.SelectedIndex = -1;
                }
                else
                {
                    ItemComanda novoItem = new ItemComanda(produto, quantidade);
                    listBoxComanda.Items.Add(novoItem);
                    total += novoItem.Total;
                }

                labelTotal.Text = $"TOTAL: R$ {total:F2}";
                listBoxComanda.ClearSelected();
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
                    double valorAntigo = itemSelecionado.Total;
                    itemSelecionado.Quantidade -= quantidadeRemover;
                    total -= total - valorAntigo + itemSelecionado.Total;

                    int index = listBoxComanda.Items.IndexOf(itemSelecionado);
                    listBoxComanda.Items[index] = itemSelecionado;
                    listBoxComanda.SelectedIndex = -1;
                }

                labelTotal.Text = $"TOTAL: R$  {total:F2}";

            }
            else
            {
                MessageBox.Show("Selecione um produto da comanda.");
            }

            nudQuantidade.Value = 1;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            double valorPago = total;
            double trocado = 0;

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

            if (cboxPagamento.SelectedIndex == 0)
            {
                bool pagamentoValido = false;

                while (!pagamentoValido)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor pago:", "PAGAMENTO");

                    if (string.IsNullOrEmpty(input))
                    {
                        return;
                    }

                    if (double.TryParse(input, out double valorPagoTotal))
                    {
                        if (valorPagoTotal < total)
                        {
                            MessageBox.Show("Valor pago insuficiente.", "ERRO");
                            return;
                        }
                        else
                        {
                            valorPago = valorPagoTotal;
                            trocado = valorPagoTotal - total;
                            MessageBox.Show($"Troco: R${trocado:F2}", "TROCADO");
                            pagamentoValido = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido.", "ERRO");
                    }
                }
            }
            else
            {
                valorPago = total;
                trocado = 0; 
            }

            string nomeCliente = txtNomeCliente.Text.Trim();
            if (!string.IsNullOrEmpty(nomeCliente))
            {
                nomeCliente = char.ToUpper(nomeCliente[0]) + nomeCliente.Substring(1).ToLower();
            }

            List<ItemComanda> itensDoPedido = new List<ItemComanda>();
            foreach (ItemComanda item in listBoxComanda.Items)
            {
                itensDoPedido.Add(item);
            }

            DateTime dataHoraAtual = DateTime.Now;
            bool paraViagem = checkBoxViagem.Checked;

            Pedido novoPedido = new Pedido(nomeCliente, dataHoraAtual, itensDoPedido, total, paraViagem)
            {
                IdPedido = proximoIdPedido++,
            };

            bool vaiCozinha = itensDoPedido.Any(item => item.Produto.Cozinha);

            if (vaiCozinha)
            {
                novoPedido.Status = "Em Preparo na Cozinha";
                CozinhaPedidos.PedidosPreparando.Add(novoPedido);

                FormCozinha formCozinha = Application.OpenForms.OfType<FormCozinha>().FirstOrDefault();
                if (formCozinha != null)
                {
                    formCozinha = new FormCozinha();
                    formCozinha.Show();
                }

                MessageBox.Show($"Pedido {novoPedido.IdPedido} enviado para a Cozinha.", "PEDIDO ENVIADO");
            }
            else
            {
                novoPedido.Status = "Pronto para Entrega";
                BalcaoPedidos.PedidosEmEspera.Add(novoPedido);

                FormBalcao formBalcao = Application.OpenForms.OfType<FormBalcao>().FirstOrDefault();
                if (formBalcao != null)
                {
                    formBalcao = new FormBalcao();
                    formBalcao.Show();
                }

                MessageBox.Show($"Pedido {novoPedido.IdPedido} enviado para o Balcão.", "PEDIDO PRONTO");
            }

            StringBuilder resumo = new StringBuilder();
            foreach (ItemComanda item in novoPedido.Itens)
            {
                resumo.AppendLine($"{item.Produto.Nome} x {item.Quantidade} - R$ {item.Total:F2}");
            }

            string tipoPedido = novoPedido.ParaViagem ? "Para Viagem" : "Para Consumir no Local";
            string destino = vaiCozinha ? "Cozinha" : "Balcão";

            MessageBox.Show(
                $"ID do Pedido: {novoPedido.IdPedido}\n\n" +
                $"Nome do Cliente: {novoPedido.NomeCliente}\n\n" +
                $"Extrato:\n{resumo}\n" +
                $"Total Cobrado: R$ {novoPedido.Total:F2}\n" +
                $"Total Pago: R$ {valorPago:F2}\n" +
                $"Troco: R$ {trocado:F2}\n\n" +
                $"Método de Pagamento: {cboxPagamento.SelectedItem}\n\n" +
                $"Pedido: {tipoPedido}\n\n" +
                $"Data e Hora: {dataHoraAtual:dd/MM/yyyy HH:mm:ss}\n\n" +
                $"Enviado para: {destino}\n\n",
                "COMANDA"
            );

            txtNomeCliente.Clear();
            listBoxComanda.Items.Clear();
            cboxPagamento.SelectedIndex = -1;
            total = 0;
            labelTotal.Text = $"TOTAL: R$ 0,00";
            checkBoxViagem.Checked = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            FormBalcao formBalcao = new FormBalcao();
            formBalcao.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCozinha formCozinha = new FormCozinha();
            formCozinha.Show();
        }
    }
}
