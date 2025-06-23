namespace Cantina_1._0
{
    partial class FormIntroducao
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
            lblTitulo = new Label();
            btnInicializar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bauhaus 93", 90F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(201, 172);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(540, 136);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CANTINA";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnInicializar
            // 
            btnInicializar.BackColor = Color.Black;
            btnInicializar.BackgroundImageLayout = ImageLayout.None;
            btnInicializar.FlatStyle = FlatStyle.Flat;
            btnInicializar.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicializar.ForeColor = Color.FromArgb(230, 255, 0);
            btnInicializar.Location = new Point(404, 370);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(136, 62);
            btnInicializar.TabIndex = 1;
            btnInicializar.Text = "ADENTRAR";
            btnInicializar.UseVisualStyleBackColor = false;
            btnInicializar.Click += btnInicializar_Click;
            // 
            // FormIntroducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(938, 595);
            Controls.Add(btnInicializar);
            Controls.Add(lblTitulo);
            Name = "FormIntroducao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIntroducao";
            Load += FormIntroducao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnInicializar;
    }
}