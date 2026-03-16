namespace FormsJokempo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNomeJogador = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            label3 = new Label();
            txtAviso = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 42);
            label1.TabIndex = 0;
            label1.Text = "JOKENPÓ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNomeJogador
            // 
            txtNomeJogador.Location = new Point(65, 116);
            txtNomeJogador.Name = "txtNomeJogador";
            txtNomeJogador.Size = new Size(204, 22);
            txtNomeJogador.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 99);
            label2.Name = "label2";
            label2.Size = new Size(126, 14);
            label2.TabIndex = 2;
            label2.Text = "Digite o seu nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(134, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 51);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // txtAviso
            // 
            txtAviso.Anchor = AnchorStyles.Top;
            txtAviso.Location = new Point(0, 170);
            txtAviso.Name = "txtAviso";
            txtAviso.Size = new Size(342, 45);
            txtAviso.TabIndex = 5;
            txtAviso.Text = "label4";
            txtAviso.TextAlign = ContentAlignment.TopCenter;
            txtAviso.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 306);
            Controls.Add(txtAviso);
            Controls.Add(label3);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtNomeJogador);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeJogador;
        private Label label2;
        private Button btnSalvar;
        private Label label3;
        private Label txtAviso;
    }
}
