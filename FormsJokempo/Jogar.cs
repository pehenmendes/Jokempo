using JokempoLibrary;
using JokempoLibrary.Enums;
using JokempoLibrary.Models;
using JokempoLibrary.Services;
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
    public partial class Jogar : Form
    {
        

        public Jogar()
        {
            InitializeComponent();
        }

        private void btn_Pedra_Click(object sender, EventArgs e)
        {
            Jogando(Escolha.Pedra);
        }

        private void btn_Papel_Click(object sender, EventArgs e)
        {
            Jogando(Escolha.Papel);
        }

        private void btn_Tesoura_Click(object sender, EventArgs e)
        {
            Jogando(Escolha.Tesoura);
        }

        private void Jogando(Escolha escolha)
        {
            var rodada = GameManager.Jogo.Jogar(escolha);

            var resul = rodada.Resultado;
            var escolhaMaquina = rodada.EscolhaMaquina.ToString();
            if (resul == "Vitória")
                MessageBox.Show($"Eu escolhi {escolhaMaquina}.\nParabéns, você venceu!");
            else if (resul == "Derrota")
                MessageBox.Show($"Eu escolhi {escolhaMaquina}.\nQue pena, você perdeu");
            else
                MessageBox.Show($"Eu escolhi {escolhaMaquina}.\nOlha só, deu empate");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu telaMenu = new Menu();
            telaMenu.Show();
            this.Hide();
        }
    }
}
