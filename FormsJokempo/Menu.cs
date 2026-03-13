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
        public String JogadorAtual { get; set; }

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (!this.JogadorAtual.Equals(""))
            {
                txtJogadorAtual.Text = this.JogadorAtual;
            }
        }
    }
}
