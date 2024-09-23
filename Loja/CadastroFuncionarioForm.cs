using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class CadastroFuncionarioForm : Form
    {
        private SQLiteConnectionManager connectionManager;

        public CadastroFuncionarioForm()
        {
            InitializeComponent();
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validações
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não correspondem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insere o novo funcionário no banco de dados
            string query = "INSERT INTO Funcionarios (Nome, Usuario, Senha) VALUES (@Nome, @Usuario, @Senha)";
            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", txtNome.Text);
                    command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    command.Parameters.AddWithValue("@Senha", txtSenha.Text);

                    command.ExecuteNonQuery();
                }

                connectionManager.CloseConnection(connection);
            }

            MessageBox.Show("Funcionário cadastrado com sucesso.");
            this.Close(); // Fecha a tela de cadastro após a inserção
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem salvar
        }
    }

}
