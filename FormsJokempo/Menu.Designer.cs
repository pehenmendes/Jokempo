namespace FormsJokempo
{
    partial class Menu
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
            label2 = new Label();
            btnJogar = new Button();
            btnEstatistica = new Button();
            btnTrocarJogador = new Button();
            label3 = new Label();
            txtJogadorAtual = new Label();
            label4 = new Label();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 42);
            label1.TabIndex = 0;
            label1.Text = "JOKENPÓ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 51);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 1;
            label2.Text = "Menu Principal";
            // 
            // btnJogar
            // 
            btnJogar.Location = new Point(159, 167);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(114, 59);
            btnJogar.TabIndex = 2;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnEstatistica
            // 
            btnEstatistica.Location = new Point(159, 232);
            btnEstatistica.Name = "btnEstatistica";
            btnEstatistica.Size = new Size(114, 59);
            btnEstatistica.TabIndex = 3;
            btnEstatistica.Text = "Estatísticas";
            btnEstatistica.UseVisualStyleBackColor = true;
            btnEstatistica.Click += btnEstatistica_Click;
            // 
            // btnTrocarJogador
            // 
            btnTrocarJogador.Location = new Point(159, 297);
            btnTrocarJogador.Name = "btnTrocarJogador";
            btnTrocarJogador.Size = new Size(114, 59);
            btnTrocarJogador.TabIndex = 4;
            btnTrocarJogador.Text = "Trocar Jogador";
            btnTrocarJogador.UseVisualStyleBackColor = true;
            btnTrocarJogador.Click += btnTrocarJogador_Click;
            // 
            // label3
            // 
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(419, 14);
            label3.TabIndex = 5;
            label3.Text = "Bem vindo/a, ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtJogadorAtual
            // 
            txtJogadorAtual.Location = new Point(12, 102);
            txtJogadorAtual.Name = "txtJogadorAtual";
            txtJogadorAtual.Size = new Size(419, 14);
            txtJogadorAtual.TabIndex = 6;
            txtJogadorAtual.Text = "jogador";
            txtJogadorAtual.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(419, 15);
            label4.TabIndex = 7;
            label4.Text = "Escolha uma das opções abaixo:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(356, 385);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 420);
            Controls.Add(btnSair);
            Controls.Add(label4);
            Controls.Add(txtJogadorAtual);
            Controls.Add(label3);
            Controls.Add(btnTrocarJogador);
            Controls.Add(btnEstatistica);
            Controls.Add(btnJogar);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnJogar;
        private Button btnEstatistica;
        private Button btnTrocarJogador;
        private Label label3;
        private Label txtJogadorAtual;
        private Label label4;
        private Button btnSair;
    }
}