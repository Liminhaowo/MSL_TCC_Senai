namespace Cantina_1._0
{
    partial class FormBalcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPronto = new Button();
            dgvEspera = new DataGridView();
            dgvEntregues = new DataGridView();
            listBoxInfomaçõesPedido = new ListBox();
            labelProntos = new Label();
            labelEmEspera = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEspera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntregues).BeginInit();
            SuspendLayout();
            // 
            // btnPronto
            // 
            btnPronto.Location = new Point(306, 151);
            btnPronto.Name = "btnPronto";
            btnPronto.Size = new Size(90, 23);
            btnPronto.TabIndex = 0;
            btnPronto.Text = "Pronto";
            btnPronto.UseVisualStyleBackColor = true;
            btnPronto.Click += btnPronto_Click;
            // 
            // dgvEspera
            // 
            dgvEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspera.Location = new Point(29, 58);
            dgvEspera.Name = "dgvEspera";
            dgvEspera.Size = new Size(247, 209);
            dgvEspera.TabIndex = 1;
            dgvEspera.CellContentClick += dgvEspera_CellContentClick;
            // 
            // dgvEntregues
            // 
            dgvEntregues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntregues.Location = new Point(29, 337);
            dgvEntregues.Name = "dgvEntregues";
            dgvEntregues.Size = new Size(247, 211);
            dgvEntregues.TabIndex = 2;
            dgvEntregues.CellContentClick += dgvEntregues_CellContentClick;
            // 
            // listBoxInfomaçõesPedido
            // 
            listBoxInfomaçõesPedido.FormattingEnabled = true;
            listBoxInfomaçõesPedido.ItemHeight = 15;
            listBoxInfomaçõesPedido.Location = new Point(660, 107);
            listBoxInfomaçõesPedido.Name = "listBoxInfomaçõesPedido";
            listBoxInfomaçõesPedido.Size = new Size(229, 379);
            listBoxInfomaçõesPedido.TabIndex = 3;
            listBoxInfomaçõesPedido.SelectedIndexChanged += listBoxInfomaçõesPedido_SelectedIndexChanged;
            // 
            // labelProntos
            // 
            labelProntos.AutoSize = true;
            labelProntos.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold);
            labelProntos.ForeColor = Color.Black;
            labelProntos.Location = new Point(106, 312);
            labelProntos.Name = "labelProntos";
            labelProntos.Size = new Size(88, 22);
            labelProntos.TabIndex = 5;
            labelProntos.Text = "PRONTOS";
            labelProntos.Click += labelProntos_Click;
            // 
            // labelEmEspera
            // 
            labelEmEspera.AutoSize = true;
            labelEmEspera.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold);
            labelEmEspera.ForeColor = Color.Black;
            labelEmEspera.Location = new Point(106, 33);
            labelEmEspera.Name = "labelEmEspera";
            labelEmEspera.Size = new Size(97, 22);
            labelEmEspera.TabIndex = 4;
            labelEmEspera.Text = "EM ESPERA";
            labelEmEspera.Click += labelEmEspera_Click;
            // 
            // FormBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 589);
            Controls.Add(labelProntos);
            Controls.Add(labelEmEspera);
            Controls.Add(listBoxInfomaçõesPedido);
            Controls.Add(dgvEntregues);
            Controls.Add(dgvEspera);
            Controls.Add(btnPronto);
            Name = "FormBalcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBalcao";
            Load += FormBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntregues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPronto;
        private DataGridView dgvEspera;
        private DataGridView dgvEntregues;
        private ListBox listBoxInfomaçõesPedido;
        private Label labelProntos;
        private Label labelEmEspera;
    }
}