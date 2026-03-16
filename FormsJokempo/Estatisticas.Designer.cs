namespace FormsJokempo
{
    partial class Estatisticas
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
            btnAtualizar = new Button();
            btnVoltar = new Button();
            gridEstatisticas = new DataGridView();
            colJogadores = new DataGridViewTextBoxColumn();
            colVitorias = new DataGridViewTextBoxColumn();
            colDerrotas = new DataGridViewTextBoxColumn();
            colEmpates = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridEstatisticas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(778, 36);
            label1.TabIndex = 2;
            label1.Text = "JOKENPÓ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 44);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 5;
            label3.Text = "Estatísticas";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(83, 451);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(128, 47);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(598, 451);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(128, 47);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // gridEstatisticas
            // 
            gridEstatisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEstatisticas.Columns.AddRange(new DataGridViewColumn[] { colJogadores, colVitorias, colDerrotas, colEmpates });
            gridEstatisticas.Location = new Point(191, 124);
            gridEstatisticas.Name = "gridEstatisticas";
            gridEstatisticas.Size = new Size(443, 236);
            gridEstatisticas.TabIndex = 12;
            // 
            // colJogadores
            // 
            colJogadores.HeaderText = "Jogadores";
            colJogadores.Name = "colJogadores";
            // 
            // colVitorias
            // 
            colVitorias.HeaderText = "Vitórias";
            colVitorias.Name = "colVitorias";
            // 
            // colDerrotas
            // 
            colDerrotas.HeaderText = "Derrotas";
            colDerrotas.Name = "colDerrotas";
            // 
            // colEmpates
            // 
            colEmpates.HeaderText = "Empates";
            colEmpates.Name = "colEmpates";
            // 
            // Estatisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 510);
            Controls.Add(gridEstatisticas);
            Controls.Add(btnVoltar);
            Controls.Add(btnAtualizar);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Estatisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Estatisticas_Load;
            ((System.ComponentModel.ISupportInitialize)gridEstatisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btnAtualizar;
        private Button btnVoltar;
        private DataGridView gridEstatisticas;
        private DataGridViewTextBoxColumn colJogadores;
        private DataGridViewTextBoxColumn colVitorias;
        private DataGridViewTextBoxColumn colDerrotas;
        private DataGridViewTextBoxColumn colEmpates;
    }
}