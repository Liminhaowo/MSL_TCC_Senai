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
            dgvPreparando = new DataGridView();
            btnEntregar = new Button();
            labelPreparar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPreparando).BeginInit();
            SuspendLayout();
            // 
            // listBoxInfomaçõesPedido2
            // 
            listBoxInfomaçõesPedido2.FormattingEnabled = true;
            listBoxInfomaçõesPedido2.ItemHeight = 15;
            listBoxInfomaçõesPedido2.Location = new Point(661, 101);
            listBoxInfomaçõesPedido2.Name = "listBoxInfomaçõesPedido2";
            listBoxInfomaçõesPedido2.Size = new Size(229, 379);
            listBoxInfomaçõesPedido2.TabIndex = 7;
            listBoxInfomaçõesPedido2.SelectedIndexChanged += listBoxInfomaçõesPedido2_SelectedIndexChanged_1;
            // 
            // dgvPreparando
            // 
            dgvPreparando.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreparando.Location = new Point(30, 79);
            dgvPreparando.Name = "dgvPreparando";
            dgvPreparando.Size = new Size(247, 424);
            dgvPreparando.TabIndex = 5;
            dgvPreparando.CellContentClick += dgvPreparando_CellContentClick;
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(305, 293);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(90, 23);
            btnEntregar.TabIndex = 4;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // labelPreparar
            // 
            labelPreparar.AutoSize = true;
            labelPreparar.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold);
            labelPreparar.ForeColor = Color.Black;
            labelPreparar.Location = new Point(108, 44);
            labelPreparar.Name = "labelPreparar";
            labelPreparar.Size = new Size(91, 22);
            labelPreparar.TabIndex = 8;
            labelPreparar.Text = "PREPAPAR";
            // 
            // FormCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 590);
            Controls.Add(labelPreparar);
            Controls.Add(listBoxInfomaçõesPedido2);
            Controls.Add(dgvPreparando);
            Controls.Add(btnEntregar);
            Name = "FormCozinha";
            Text = "FormCozinha";
            Load += FormCozinha_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPreparando).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxInfomaçõesPedido2;
        private DataGridView dgvPreparando;
        private Button btnEntregar;
        private Label labelPreparar;
    }
}