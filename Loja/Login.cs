namespace Loja
{

    using Microsoft.Data.Sqlite;

    public partial class Login : Form
    {
        private SQLiteConnectionManager connectionManager;

        public Login()
        {
            InitializeComponent();
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);
            connectionManager.CriarTabelaFuncionarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

           
            string query = $"SELECT * FROM Funcionarios WHERE Usuario = @Usuario AND Senha = @Senha";
            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);
                using (var command = new SqliteCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            
                            MainForm mainForm = new MainForm();
                            this.Hide();
                            mainForm.Show();
                        }
                        else
                        {
                            
                            MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }

        }
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
          
            string senhaAdm = Microsoft.VisualBasic.Interaction.InputBox("Digite a senha de administrador:", "Acesso Restrito", "");

            
            if (senhaAdm == "123")
            {
                
                ConsultaFuncionariosForm consultaFuncionariosForm = new ConsultaFuncionariosForm();
                consultaFuncionariosForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha incorreta. Acesso negado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
