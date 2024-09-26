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


        private int? funcionarioId;

        
        public CadastroFuncionarioForm(int id, string nome, string usuario, string senha)
        {
            connectionManager = new SQLiteConnectionManager("loja.db");
            InitializeComponent();

            funcionarioId = id; 

            
            txtNome.Text = nome;
            txtUsuario.Text = usuario;
            txtSenha.Text = senha;
            txtConfirmarSenha.Text = senha; 
        }
        public CadastroFuncionarioForm()
        {
            InitializeComponent();
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
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

            if (funcionarioId == null)
            {
                
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
            }
            else 
            {
                
                string updateQuery = @"UPDATE Funcionarios SET 
                                   Nome = @Nome, 
                                   Usuario = @Usuario, 
                                   Senha = @Senha 
                                   WHERE Id = @Id";
                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);
                    using (var command = new SqliteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", txtNome.Text);
                        command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        command.Parameters.AddWithValue("@Senha", txtSenha.Text);
                        command.Parameters.AddWithValue("@Id", funcionarioId);
                        command.ExecuteNonQuery();
                    }
                    connectionManager.CloseConnection(connection);
                }
                MessageBox.Show("Dados do funcionário atualizados com sucesso.");
            }

            
            this.Close(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }

}
