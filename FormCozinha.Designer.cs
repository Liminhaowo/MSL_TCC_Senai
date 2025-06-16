namespace Cantina_1._0
{
    partial class FormCozinha
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
            listBoxInfomaçõesPedido2 = new ListBox();
            dgvProntos = new DataGridView();
            dgvPreparando = new DataGridView();
            btnEntregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPreparando).BeginInit();
            SuspendLayout();
            // 
            // listBoxInfomaçõesPedido2
            // 
            listBoxInfomaçõesPedido2.FormattingEnabled = true;
            listBoxInfomaçõesPedido2.ItemHeight = 15;
            listBoxInfomaçõesPedido2.Location = new Point(660, 109);
            listBoxInfomaçõesPedido2.Name = "listBoxInfomaçõesPedido2";
            listBoxInfomaçõesPedido2.Size = new Size(229, 379);
            listBoxInfomaçõesPedido2.TabIndex = 7;
            // 
            // dgvProntos
            // 
            dgvProntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProntos.Location = new Point(30, 353);
            dgvProntos.Name = "dgvProntos";
            dgvProntos.Size = new Size(247, 211);
            dgvProntos.TabIndex = 6;
            // 
            // dgvPreparando
            // 
            dgvPreparando.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreparando.Location = new Point(30, 24);
            dgvPreparando.Name = "dgvPreparando";
            dgvPreparando.Size = new Size(247, 209);
            dgvPreparando.TabIndex = 5;
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(106, 281);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(90, 23);
            btnEntregar.TabIndex = 4;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            // 
            // FormCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 590);
            Controls.Add(listBoxInfomaçõesPedido2);
            Controls.Add(dgvProntos);
            Controls.Add(dgvPreparando);
            Controls.Add(btnEntregar);
            Name = "FormCozinha";
            Text = "FormCozinha";
            Load += FormCozinha_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPreparando).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxInfomaçõesPedido2;
        private DataGridView dgvProntos;
        private DataGridView dgvPreparando;
        private Button btnEntregar;
    }
}