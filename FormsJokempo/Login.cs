using JokempoLibrary;

namespace FormsJokempo
{
    public partial class Login : Form
    {
        private List<Jogador> jogadorList = new();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            if (txtNomeJogador.Text.Length > 0)
            {
                jogador.Nome = txtNomeJogador.Text;
                jogadorList.Add(jogador);
                Menu form = new Menu();
                form.Show();
            }
            else {
                txtAviso.Text = "Campo vazio\nDigite um nome válido";
                txtAviso.Visible = true;
            }
        }
    }
}
