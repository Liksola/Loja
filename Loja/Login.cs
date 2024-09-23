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

            // Valida o login no banco de dados
            string query = $"SELECT * FROM Funcionarios WHERE Usuario = @Usuario AND Senha = @Senha";
            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);
                using (var command = new SqliteCommand(query, connection))
                {
                    // Usando par�metros para evitar SQL Injection
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Login v�lido, abre a tela principal
                            MainForm mainForm = new MainForm();
                            this.Hide();
                            mainForm.Show();
                        }
                        else
                        {
                            // Exibe uma mensagem de erro se o login for incorreto
                            MessageBox.Show("Usu�rio ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            // Abre o formul�rio de cadastro de funcion�rio
            CadastroFuncionarioForm cadastroFuncionarioForm = new CadastroFuncionarioForm();
            cadastroFuncionarioForm.Show();
        }
    }

}
