namespace FormsJokempo
{
    partial class Jogar
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_Pedra = new Button();
            btn_Papel = new Button();
            btn_Tesoura = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(715, 39);
            label1.TabIndex = 1;
            label1.Text = "JOKENPÓ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 49);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 5;
            label3.Text = "Jogando";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 84);
            label2.Name = "label2";
            label2.Size = new Size(224, 14);
            label2.TabIndex = 6;
            label2.Text = "Já fiz a minha escolha. Faça a sua:";
            // 
            // btn_Pedra
            // 
            btn_Pedra.Location = new Point(220, 131);
            btn_Pedra.Name = "btn_Pedra";
            btn_Pedra.Size = new Size(86, 87);
            btn_Pedra.TabIndex = 7;
            btn_Pedra.Text = "Pedra ✊";
            btn_Pedra.UseVisualStyleBackColor = true;
            btn_Pedra.Click += btn_Pedra_Click;
            // 
            // btn_Papel
            // 
            btn_Papel.Location = new Point(335, 131);
            btn_Papel.Name = "btn_Papel";
            btn_Papel.Size = new Size(86, 87);
            btn_Papel.TabIndex = 8;
            btn_Papel.Text = "Papel 🖐️";
            btn_Papel.UseVisualStyleBackColor = true;
            btn_Papel.Click += btn_Papel_Click;
            // 
            // btn_Tesoura
            // 
            btn_Tesoura.Location = new Point(451, 131);
            btn_Tesoura.Name = "btn_Tesoura";
            btn_Tesoura.Size = new Size(86, 87);
            btn_Tesoura.TabIndex = 9;
            btn_Tesoura.Text = "Tesoura ✌️";
            btn_Tesoura.UseVisualStyleBackColor = true;
            btn_Tesoura.Click += btn_Tesoura_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(71, 353);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(119, 42);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Jogar
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 420);
            Controls.Add(btnVoltar);
            Controls.Add(btn_Tesoura);
            Controls.Add(btn_Papel);
            Controls.Add(btn_Pedra);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Jogar";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button btn_Pedra;
        private Button btn_Papel;
        private Button btn_Tesoura;
        private Button btnVoltar;
    }
}