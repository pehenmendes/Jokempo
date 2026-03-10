namespace FormsJokempo
{
    partial class Form1
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(204, 42);
            label1.TabIndex = 0;
            label1.Text = "JOKENPÓ";
            // 
            // txtNomeJogador
            // 
            txtNomeJogador.Location = new Point(22, 107);
            txtNomeJogador.Name = "txtNomeJogador";
            txtNomeJogador.Size = new Size(156, 22);
            txtNomeJogador.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 90);
            label2.Name = "label2";
            label2.Size = new Size(126, 14);
            label2.TabIndex = 2;
            label2.Text = "Digite o seu nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(184, 106);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 420);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtNomeJogador);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeJogador;
        private Label label2;
        private Button btnSalvar;
    }
}
