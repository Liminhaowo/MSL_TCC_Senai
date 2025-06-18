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
    public partial class FormBalcao : Form
    {

        public FormBalcao()
        {
            InitializeComponent();
            DataGridViews();
        }

        public void AtualizarListas()
        {
            dgvEspera.DataSource = null;
            dgvProntos.DataSource = null;
            dgvEspera.DataSource = BalcaoPedidos.PedidosEmEspera;
            dgvProntos.DataSource = BalcaoPedidos.PedidosEntregues;
            dgvEspera.Refresh();
            dgvProntos.Refresh();
            listBoxInfomaçõesPedido.Items.Clear();
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
            dgvEspera.DataSource = BalcaoPedidos.PedidosEmEspera;
            dgvProntos.DataSource = BalcaoPedidos.PedidosEntregues;

            ConfigurarDataGridView(dgvEspera, "EM PREPARO");
            ConfigurarDataGridView(dgvProntos, "PRONTOS");

            dgvEspera.SelectionChanged += DgvEspera_SelectionChanged;
            dgvProntos.SelectionChanged += DgvEntregues_SelectionChanged;
        }

        private void DetalhesPedido(DataGridView dgv)
        {
            if (dgv.CurrentRow != null)
            {
                Pedido pedidoSelecionado = (Pedido)dgv.CurrentRow.DataBoundItem;

                listBoxInfomaçõesPedido.Items.Clear();
                listBoxInfomaçõesPedido.Items.Add($"ID: {pedidoSelecionado.IdPedido} - Cliente: {pedidoSelecionado.NomeCliente}");
                listBoxInfomaçõesPedido.Items.Add("");
                listBoxInfomaçõesPedido.Items.Add($"Status: {pedidoSelecionado.Status}");
                listBoxInfomaçõesPedido.Items.Add("");
                listBoxInfomaçõesPedido.Items.Add("-= Extrato =-");
                foreach (ItemComanda item in pedidoSelecionado.Itens)
                {
                    listBoxInfomaçõesPedido.Items.Add($"{item.Quantidade} x {item.Produto.Nome}");
                    //listBoxInfomaçõesPedido.Items.Add($"   Subtotal: R$ {item.Total:F2}");
                }
                listBoxInfomaçõesPedido.Items.Add("");
                listBoxInfomaçõesPedido.Items.Add($"TOTAL: R$ {pedidoSelecionado.Total:F2}");
                listBoxInfomaçõesPedido.Items.Add("");
                listBoxInfomaçõesPedido.Items.Add($"Para Viagem: {(pedidoSelecionado.ParaViagem ? "Sim" : "Não")}");
                listBoxInfomaçõesPedido.Items.Add("");
                listBoxInfomaçõesPedido.Items.Add($"Data/Hora: {pedidoSelecionado.DataEHora:dd/MM/yyyy HH:mm}");
            }
        }

        private void DgvEspera_SelectionChanged(object sender, EventArgs e)
        {
            DetalhesPedido(dgvEspera);
        }

        private void DgvEntregues_SelectionChanged(object sender, EventArgs e)
        {
            DetalhesPedido(dgvProntos);
        }

        private void FormBalcao_Load(object sender, EventArgs e)
        {

        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            if (dgvEspera.CurrentRow != null)
            {
                Pedido pedidoSelecionado = (Pedido)dgvEspera.CurrentRow.DataBoundItem;
                pedidoSelecionado.Status = "Pronto";

                BalcaoPedidos.PedidosEmEspera.Remove(pedidoSelecionado);
                BalcaoPedidos.PedidosEntregues.Insert(0, pedidoSelecionado);

                while (BalcaoPedidos.PedidosEntregues.Count > 5)
                {
                    BalcaoPedidos.PedidosEntregues.RemoveAt(BalcaoPedidos.PedidosEntregues.Count - 1);
                }

                listBoxInfomaçõesPedido.Items.Clear();
            }
            else
            {
                MessageBox.Show("Selecione um pedido para entregar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvEspera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEntregues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxInfomaçõesPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelEmEspera_Click(object sender, EventArgs e)
        {

        }

        private void labelProntos_Click(object sender, EventArgs e)
        {

        }
    }
}
