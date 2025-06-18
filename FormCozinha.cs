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
    public partial class FormCozinha : Form
    {
        public FormCozinha()
        {
            InitializeComponent();
            DataGridViews();
        }

        private void ConfigurarDataGridView(DataGridView dgv, string titulo)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdPedido",
                HeaderText = "ID",
                Name = "IdPedido",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCliente",
                HeaderText = "Cliente",
                Name = "NomeCliente",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "Total",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "C2"
                }
            });

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.Fixed3D;

            dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgv.RowTemplate.Height = 35;
        }

        private void DataGridViews()
        {
            dgvPreparando.DataSource = CozinhaPedidos.PedidosPreparando;
            ConfigurarDataGridView(dgvPreparando, "EM PREPARO - COZINHA");
            dgvPreparando.SelectionChanged += DgvPreparando_SelectionChanged;
        }

        private void DetalhesPedido(DataGridView dgv)
        {
            if (dgv.CurrentRow != null)
            {
                Pedido pedidoSelecionado = (Pedido)dgv.CurrentRow.DataBoundItem;

                listBoxInfomaçõesPedido2.Items.Clear();
                listBoxInfomaçõesPedido2.Items.Add($"ID: {pedidoSelecionado.IdPedido} - Cliente: {pedidoSelecionado.NomeCliente}");
                listBoxInfomaçõesPedido2.Items.Add("");
                listBoxInfomaçõesPedido2.Items.Add($"Status: {pedidoSelecionado.Status}");
                listBoxInfomaçõesPedido2.Items.Add("");
                listBoxInfomaçõesPedido2.Items.Add("-= Extrato =-");
                foreach (ItemComanda item in pedidoSelecionado.Itens)
                {
                    listBoxInfomaçõesPedido2.Items.Add($"{item.Quantidade} x {item.Produto.Nome}");

                }
                listBoxInfomaçõesPedido2.Items.Add("");
                listBoxInfomaçõesPedido2.Items.Add($"TOTAL: R$ {pedidoSelecionado.Total:F2}");
                listBoxInfomaçõesPedido2.Items.Add("");
                listBoxInfomaçõesPedido2.Items.Add($"Para Viagem: {(pedidoSelecionado.ParaViagem ? "Sim" : "Não")}");
                listBoxInfomaçõesPedido2.Items.Add("");
                listBoxInfomaçõesPedido2.Items.Add($"Data/Hora: {pedidoSelecionado.DataEHora:dd/MM/yyyy HH:mm}");
            }
        }

        private void DgvPreparando_SelectionChanged(object sender, EventArgs e)
        {
            DetalhesPedido(dgvPreparando);
        }

        private void dgvPreparando_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCozinha_Load(object sender, EventArgs e)
        {

        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Debug 1: Verificar se há linha selecionada
            //    MessageBox.Show($"Linhas no DataGridView: {dgvPreparando.Rows.Count}", "Debug 1");

            //    if (dgvPreparando.CurrentRow != null)
            //    {
            //        // Debug 2: Verificar se conseguiu pegar o pedido
            //        MessageBox.Show($"Linha selecionada: {dgvPreparando.CurrentRow.Index}", "Debug 2");

            //        Pedido pedidoSelecionado = (Pedido)dgvPreparando.CurrentRow.DataBoundItem;

            //        if (pedidoSelecionado != null)
            //        {
            //            // Debug 3: Mostrar dados do pedido
            //            MessageBox.Show($"Pedido ID: {pedidoSelecionado.IdPedido}\nCliente: {pedidoSelecionado.NomeCliente}", "Debug 3");

            //            // Debug 4: Verificar listas antes da operação
            //            MessageBox.Show($"Pedidos Preparando ANTES: {CozinhaPedidos.PedidosPreparando.Count}\nPedidos Espera ANTES: {BalcaoPedidos.PedidosEmEspera.Count}", "Debug 4");

            //            pedidoSelecionado.Status = "Pronto para Entrega";

            //            // Remove da lista de preparando
            //            bool removido = CozinhaPedidos.PedidosPreparando.Remove(pedidoSelecionado);
            //            MessageBox.Show($"Pedido removido da cozinha: {removido}", "Debug 5");

            //            // Adiciona na lista de espera do balcão
            //            BalcaoPedidos.PedidosEmEspera.Insert(0, pedidoSelecionado);

            //            // Debug 6: Verificar listas depois da operação
            //            MessageBox.Show($"Pedidos Preparando DEPOIS: {CozinhaPedidos.PedidosPreparando.Count}\nPedidos Espera DEPOIS: {BalcaoPedidos.PedidosEmEspera.Count}", "Debug 6");

            //            // Limpa a lista de informações
            //            listBoxInfomaçõesPedido2.Items.Clear();

            //            // Atualiza o DataGridView local FORÇADAMENTE
            //            dgvPreparando.DataSource = null;
            //            dgvPreparando.DataSource = CozinhaPedidos.PedidosPreparando;
            //            dgvPreparando.Refresh();

            //            // Debug 7: Verificar se encontra o FormBalcao
            //            FormBalcao formBalcao = Application.OpenForms.OfType<FormBalcao>().FirstOrDefault();
            //            MessageBox.Show($"FormBalcao encontrado: {formBalcao != null}", "Debug 7");

            //            if (formBalcao != null)
            //            {
            //                try
            //                {
            //                    formBalcao.AtualizarListas();
            //                    MessageBox.Show("FormBalcao atualizado com sucesso!", "Debug 8");
            //                }
            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show($"Erro ao atualizar FormBalcao: {ex.Message}", "Erro Debug 8");
            //                }
            //            }

            //            MessageBox.Show($"Pedido {pedidoSelecionado.IdPedido} enviado para o Balcão!", "Sucesso");
            //        }
            //        else
            //        {
            //            MessageBox.Show("pedidoSelecionado é NULL!", "Erro Debug");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nenhuma linha selecionada no DataGridView!", "Erro Debug");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Erro geral: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Erro Geral");
            //}

            if (dgvPreparando.CurrentRow != null)
            {
                Pedido pedidoSelecionado = (Pedido)dgvPreparando.CurrentRow.DataBoundItem;
                pedidoSelecionado.Status = "Pronto para Entrega";

                CozinhaPedidos.PedidosPreparando.Remove(pedidoSelecionado);

                BalcaoPedidos.PedidosEmEspera.Insert(0, pedidoSelecionado);

                listBoxInfomaçõesPedido2.Items.Clear();

                dgvPreparando.DataSource = null;
                dgvPreparando.DataSource = CozinhaPedidos.PedidosPreparando;

                FormBalcao formBalcao = Application.OpenForms.OfType<FormBalcao>().FirstOrDefault();
                if (formBalcao != null)
                {
                    formBalcao.Invoke(new Action(() =>
                    {
                        formBalcao.AtualizarListas();
                    }));
                }
                else
                {
                    formBalcao = new FormBalcao();
                    formBalcao.Show();
                }

                MessageBox.Show($"Pedido {pedidoSelecionado.IdPedido} enviado para o Balcão!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Selecione um pedido para entregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxInfomaçõesPedido2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxInfomaçõesPedido2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
