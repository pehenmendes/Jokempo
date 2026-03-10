using JokempoLibrary;

namespace FormsJokempo
{
    public partial class Form1 : Form
    {
        private List<Jogador> jogadorList = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            jogador.Nome = txtNomeJogador.Text;
            jogadorList.Add(jogador);
        }
    }
}
