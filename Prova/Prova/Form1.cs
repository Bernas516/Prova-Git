namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            bool credenciaisValidas = false;

            
            if (usuario.Equals("ADMIN", StringComparison.OrdinalIgnoreCase) && senha == "123")
            {
                credenciaisValidas = true;
            }
            else
            {
                
                string caminhoArquivo = "Usu.csv";

                if (File.Exists(caminhoArquivo))
                {
                    var linhas = File.ReadAllLines(caminhoArquivo);

                    foreach (string linha in linhas)
                    {
                        string[] partes = linha.Split(',');
                        if (partes.Length == 2)
                        {
                            string usuarioArquivo = partes[0].Trim();
                            string senhaArquivo = partes[1].Trim();

                            if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase) && senha == senhaArquivo)
                            {
                                credenciaisValidas = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo de usuários não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (credenciaisValidas)
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                FormularioP princ = new FormularioP();
                princ.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
