using JokempoLibrary;
using JokempoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsJokempo
{
    public partial class Menu : Form
    {
        
        private Login telaLogin = new Login();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            txtJogadorAtual.Text = GameManager.Jogo.JogadorAtual.Nome;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Jogar telaJogar = new Jogar();
            telaJogar.Show();
            this.Hide();
        }

        private void btnEstatistica_Click(object sender, EventArgs e)
        {
            Estatisticas telaEstatisticas = new Estatisticas();
            telaEstatisticas.Show();
            this.Hide();
        }

        private void btnTrocarJogador_Click(object sender, EventArgs e)
        {
            telaLogin.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            telaLogin.Close();
            this.Close();
        }
    }
}
