namespace Cantina_1._0
{
    partial class FormCantina
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
            listBoxCardapio = new ListBox();
            listBoxComanda = new ListBox();
            labelCardapio = new Label();
            labelComanda = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFinalizar = new Button();
            nudQuantidade = new NumericUpDown();
            txtNomeCliente = new TextBox();
            labelNomeCliente = new Label();
            dateComandaDia = new DateTimePicker();
            dateComandaHoras = new DateTimePicker();
            cboxPagamento = new ComboBox();
            labelPagamento = new Label();
            picBoxLogo = new PictureBox();
            checkBoxViagem = new CheckBox();
            labelTotal = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // listBoxCardapio
            // 
            listBoxCardapio.BackColor = Color.Silver;
            listBoxCardapio.BorderStyle = BorderStyle.FixedSingle;
            listBoxCardapio.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCardapio.FormattingEnabled = true;
            listBoxCardapio.Location = new Point(37, 158);
            listBoxCardapio.Name = "listBoxCardapio";
            listBoxCardapio.Size = new Size(244, 290);
            listBoxCardapio.TabIndex = 0;
            listBoxCardapio.SelectedIndexChanged += listBoxCardapio_SelectedIndexChanged;
            // 
            // listBoxComanda
            // 
            listBoxComanda.BackColor = Color.Silver;
            listBoxComanda.BorderStyle = BorderStyle.FixedSingle;
            listBoxComanda.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.Location = new Point(672, 158);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(230, 290);
            listBoxComanda.TabIndex = 1;
            listBoxComanda.SelectedIndexChanged += listBoxComanda_SelectedIndexChanged;
            // 
            // labelCardapio
            // 
            labelCardapio.AutoSize = true;
            labelCardapio.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold);
            labelCardapio.ForeColor = Color.Black;
            labelCardapio.Location = new Point(109, 122);
            labelCardapio.Name = "labelCardapio";
            labelCardapio.Size = new Size(91, 22);
            labelCardapio.TabIndex = 2;
            labelCardapio.Text = "CARDAPIO";
            labelCardapio.Click += labelCardapio_Click;
            // 
            // labelComanda
            // 
            labelComanda.AutoSize = true;
            labelComanda.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold);
            labelComanda.ForeColor = Color.Black;
            labelComanda.Location = new Point(738, 122);
            labelComanda.Name = "labelComanda";
            labelComanda.Size = new Size(94, 22);
            labelComanda.TabIndex = 3;
            labelComanda.Text = "COMANDA";
            labelComanda.Click += labelComanda_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatStyle = FlatStyle.System;
            btnAdicionar.Font = new Font("Agrandir Semi Narrow", 9.75F, FontStyle.Bold);
            btnAdicionar.Location = new Point(352, 176);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(93, 29);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Agrandir Semi Narrow", 9.75F, FontStyle.Bold);
            btnRemover.Location = new Point(507, 176);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(93, 29);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Agrandir Semi Narrow", 9.75F, FontStyle.Bold);
            btnFinalizar.Location = new Point(432, 434);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(86, 29);
            btnFinalizar.TabIndex = 6;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(416, 225);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 7;
            nudQuantidade.ValueChanged += nudQuantidade_ValueChanged;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(416, 359);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(120, 23);
            txtNomeCliente.TabIndex = 8;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Font = new Font("Agrandir Semi Narrow", 9.75F, FontStyle.Bold);
            labelNomeCliente.Location = new Point(452, 338);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(49, 18);
            labelNomeCliente.TabIndex = 9;
            labelNomeCliente.Text = "NOME:";
            labelNomeCliente.Click += labelNomeCliente_Click;
            // 
            // dateComandaDia
            // 
            dateComandaDia.CalendarFont = new Font("Bahnschrift", 9F);
            dateComandaDia.Format = DateTimePickerFormat.Short;
            dateComandaDia.Location = new Point(829, 41);
            dateComandaDia.Name = "dateComandaDia";
            dateComandaDia.Size = new Size(95, 23);
            dateComandaDia.TabIndex = 10;
            dateComandaDia.ValueChanged += dateComandaDia_ValueChanged;
            // 
            // dateComandaHoras
            // 
            dateComandaHoras.CalendarFont = new Font("Bahnschrift", 9F);
            dateComandaHoras.Format = DateTimePickerFormat.Time;
            dateComandaHoras.Location = new Point(844, 12);
            dateComandaHoras.Name = "dateComandaHoras";
            dateComandaHoras.Size = new Size(80, 23);
            dateComandaHoras.TabIndex = 11;
            // 
            // cboxPagamento
            // 
            cboxPagamento.FormattingEnabled = true;
            cboxPagamento.Items.AddRange(new object[] { "Pix Fisíco", "Pix Digital", "Boleto", "VR", "VA", "Escambo" });
            cboxPagamento.Location = new Point(414, 296);
            cboxPagamento.Name = "cboxPagamento";
            cboxPagamento.Size = new Size(121, 23);
            cboxPagamento.TabIndex = 12;
            cboxPagamento.SelectedIndexChanged += cboxPagamento_SelectedIndexChanged;
            // 
            // labelPagamento
            // 
            labelPagamento.AutoSize = true;
            labelPagamento.Font = new Font("Agrandir Semi Narrow", 9.75F, FontStyle.Bold);
            labelPagamento.Location = new Point(432, 275);
            labelPagamento.Name = "labelPagamento";
            labelPagamento.Size = new Size(91, 18);
            labelPagamento.TabIndex = 13;
            labelPagamento.Text = "PAGAMENTO:";
            labelPagamento.Click += labelPagamento_Click;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = Properties.Resources.Captura_de_tela_2025_05_21_085355;
            picBoxLogo.InitialImage = Properties.Resources.download;
            picBoxLogo.Location = new Point(392, 25);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(172, 52);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 14;
            picBoxLogo.TabStop = false;
            picBoxLogo.Click += picBoxLogo_Click;
            // 
            // checkBoxViagem
            // 
            checkBoxViagem.AutoSize = true;
            checkBoxViagem.Location = new Point(431, 400);
            checkBoxViagem.Name = "checkBoxViagem";
            checkBoxViagem.Size = new Size(92, 19);
            checkBoxViagem.TabIndex = 15;
            checkBoxViagem.Text = "Para Viagem";
            checkBoxViagem.UseVisualStyleBackColor = true;
            checkBoxViagem.CheckedChanged += checkBoxViagem_CheckedChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(714, 462);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(66, 22);
            labelTotal.TabIndex = 16;
            labelTotal.Text = "TOTAL: ";
            labelTotal.Click += labelTotal_Click;
            // 
            // button1
            // 
            button1.Location = new Point(805, 542);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "BALCÃO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 542);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "COZINHA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormCantina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 590);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTotal);
            Controls.Add(checkBoxViagem);
            Controls.Add(picBoxLogo);
            Controls.Add(labelPagamento);
            Controls.Add(cboxPagamento);
            Controls.Add(dateComandaHoras);
            Controls.Add(dateComandaDia);
            Controls.Add(labelNomeCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(nudQuantidade);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(labelComanda);
            Controls.Add(labelCardapio);
            Controls.Add(listBoxComanda);
            Controls.Add(listBoxCardapio);
            Name = "FormCantina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantina";
            Load += FormCantina_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCardapio;
        private ListBox listBoxComanda;
        private Label labelCardapio;
        private Label labelComanda;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFinalizar;
        private NumericUpDown nudQuantidade;
        private TextBox txtNomeCliente;
        private Label labelNomeCliente;
        private DateTimePicker dateComandaDia;
        private DateTimePicker dateComandaHoras;
        private ComboBox cboxPagamento;
        private Label labelPagamento;
        private PictureBox picBoxLogo;
        private CheckBox checkBoxViagem;
        private Label labelTotal;
        private Button button1;
        private Button button2;
    }
}