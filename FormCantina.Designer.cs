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
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // listBoxCardapio
            // 
            listBoxCardapio.BackColor = Color.Silver;
            listBoxCardapio.BorderStyle = BorderStyle.FixedSingle;
            listBoxCardapio.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCardapio.FormattingEnabled = true;
            listBoxCardapio.Location = new Point(54, 127);
            listBoxCardapio.Name = "listBoxCardapio";
            listBoxCardapio.Size = new Size(205, 194);
            listBoxCardapio.TabIndex = 0;
            listBoxCardapio.SelectedIndexChanged += listBoxCardapio_SelectedIndexChanged;
            // 
            // listBoxComanda
            // 
            listBoxComanda.BackColor = Color.Silver;
            listBoxComanda.BorderStyle = BorderStyle.FixedSingle;
            listBoxComanda.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxComanda.FormattingEnabled = true;
            listBoxComanda.Location = new Point(538, 127);
            listBoxComanda.Name = "listBoxComanda";
            listBoxComanda.Size = new Size(210, 194);
            listBoxComanda.TabIndex = 1;
            listBoxComanda.SelectedIndexChanged += listBoxComanda_SelectedIndexChanged;
            // 
            // labelCardapio
            // 
            labelCardapio.AutoSize = true;
            labelCardapio.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCardapio.ForeColor = Color.Black;
            labelCardapio.Location = new Point(106, 87);
            labelCardapio.Name = "labelCardapio";
            labelCardapio.Size = new Size(102, 21);
            labelCardapio.TabIndex = 2;
            labelCardapio.Text = "CARDAPIO";
            labelCardapio.Click += labelCardapio_Click;
            // 
            // labelComanda
            // 
            labelComanda.AutoSize = true;
            labelComanda.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelComanda.ForeColor = Color.Black;
            labelComanda.Location = new Point(592, 87);
            labelComanda.Name = "labelComanda";
            labelComanda.Size = new Size(100, 21);
            labelComanda.TabIndex = 3;
            labelComanda.Text = "COMANDA";
            labelComanda.Click += labelComanda_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Bahnschrift", 11.25F);
            btnAdicionar.Location = new Point(358, 127);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 29);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Bahnschrift", 11.25F);
            btnRemover.Location = new Point(358, 221);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(86, 29);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Bahnschrift", 11.25F);
            btnFinalizar.Location = new Point(358, 266);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(86, 29);
            btnFinalizar.TabIndex = 6;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(341, 162);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 7;
            nudQuantidade.Visible = false;
            nudQuantidade.ValueChanged += nudQuantidade_ValueChanged;
            // 
            // FormCantina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(nudQuantidade);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(labelComanda);
            Controls.Add(labelCardapio);
            Controls.Add(listBoxComanda);
            Controls.Add(listBoxCardapio);
            Name = "FormCantina";
            Text = "FormCantina";
            Load += FormCantina_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
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
    }
}