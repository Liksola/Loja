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
    public partial class CadastroForm : Form
    {
        private int? clienteId; 
        private SQLiteConnectionManager connectionManager;

       
        public CadastroForm()
        {
            InitializeComponent();
            clienteId = null; 
            connectionManager = new SQLiteConnectionManager("loja.db");
        }

        
        public CadastroForm(int id, string nome, string cpf, string email, string telefone, string endereco)
        {
            InitializeComponent();

            
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);

            
            clienteId = id;

            
            txtNome.Text = nome;
            txtCPF.Text = cpf;
            txtEmail.Text = email;
            txtTelefone.Text = telefone;
            txtEndereco.Text = endereco;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefone.Text) || string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (clienteId == null)
            {
                
                string insertQuery = "INSERT INTO Cliente (Nome, CPF, Email, Telefone, Endereco) VALUES (@Nome, @CPF, @Email, @Telefone, @Endereco)";
                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);

                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", txtNome.Text);
                        command.Parameters.AddWithValue("@CPF", txtCPF.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        command.Parameters.AddWithValue("@Endereco", txtEndereco.Text);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }

                MessageBox.Show("Cliente cadastrado com sucesso.");
            }
            else
            {
                
                string updateQuery = @"UPDATE Cliente SET 
                                    Nome = @Nome, 
                                    CPF = @CPF, 
                                    Email = @Email, 
                                    Telefone = @Telefone, 
                                    Endereco = @Endereco 
                                    WHERE Id = @Id";

                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);

                    using (var command = new SqliteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", txtNome.Text);
                        command.Parameters.AddWithValue("@CPF", txtCPF.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        command.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@Id", clienteId); 

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }

                MessageBox.Show("Dados do cliente atualizados com sucesso.");
            }

            this.Close(); 
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }

}
