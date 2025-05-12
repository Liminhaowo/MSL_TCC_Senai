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
            lblTitulo.Font = new Font("Bauhaus 93", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(184, 116);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(433, 108);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CANTINA";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnInicializar
            // 
            btnInicializar.BackColor = Color.Black;
            btnInicializar.BackgroundImageLayout = ImageLayout.None;
            btnInicializar.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicializar.ForeColor = SystemColors.ControlLightLight;
            btnInicializar.Location = new Point(358, 258);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(86, 42);
            btnInicializar.TabIndex = 1;
            btnInicializar.Text = "JOGAR";
            btnInicializar.UseVisualStyleBackColor = false;
            // 
            // FormIntroducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInicializar);
            Controls.Add(lblTitulo);
            Name = "FormIntroducao";
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