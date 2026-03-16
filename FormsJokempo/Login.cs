using JokempoLibrary;

namespace FormsJokempo
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (txtNomeJogador.Text.Length > 0)
            {
                GameManager.Jogo.CriarJogador(txtNomeJogador.Text);

                Menu telaMenu = new Menu();
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
