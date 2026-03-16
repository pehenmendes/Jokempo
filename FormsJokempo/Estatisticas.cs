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
    public partial class Estatisticas : Form
    {

        public Estatisticas()
        {
            InitializeComponent();
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
            CarregarEstatisticas();
        }

        private void CarregarEstatisticas()
        {
            gridEstatisticas.Rows.Clear();

            foreach (var jogador in GameManager.Jogo.Jogadores)
            {
                gridEstatisticas.Rows.Add(
                    jogador.Nome,
                    jogador.Estatisticas.Vitorias,
                    jogador.Estatisticas.Derrotas,
                    jogador.Estatisticas.Empates
                );
            }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarEstatisticas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu telaMenu = new Menu();
            telaMenu.Show();
            this.Hide();
        }
    }
}
