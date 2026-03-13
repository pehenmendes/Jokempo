using JokempoLibrary;

namespace FormsJokempo
{
    public partial class Login : Form
    {
        private Jogo jogo = new Jogo();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Menu telaMenu = new Menu();
            if (txtNomeJogador.Text.Length > 0)
            {
                jogo.AdicionarJogador(txtNomeJogador.Text);

                telaMenu.JogadorAtual = txtNomeJogador.Text;
                telaMenu.Show();
                this.Hide();
            }
            else
            {
                txtAviso.Text = "Campo vazio\nDigite um nome válido";
                txtAviso.Visible = true;
            }
        }
    }
}
