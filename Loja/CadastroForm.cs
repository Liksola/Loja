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
        private int? clienteId; // Usamos "int?" para permitir null, caso não seja uma edição
        private SQLiteConnectionManager connectionManager;

        // Construtor para cadastro de um novo cliente (sem parâmetros)
        public CadastroForm()
        {
            InitializeComponent();
            clienteId = null; // Não está editando nenhum cliente
            connectionManager = new SQLiteConnectionManager("loja.db");
        }

        // Construtor para edição de cliente (com parâmetros)
        public CadastroForm(int id, string nome, string cpf, string email, string telefone, string endereco)
        {
            InitializeComponent();

            // Inicializa a conexão com o banco de dados
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);

            // Armazena o ID do cliente que será editado
            clienteId = id;

            // Preenche os campos com os dados recebidos
            txtNome.Text = nome;
            txtCPF.Text = cpf;
            txtEmail.Text = email;
            txtTelefone.Text = telefone;
            txtEndereco.Text = endereco;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validações
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefone.Text) || string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se clienteId for null, significa que é um novo cadastro
            if (clienteId == null)
            {
                // Insere novo cliente no banco de dados
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
                // Atualiza o cliente existente
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
                        command.Parameters.AddWithValue("@Id", clienteId); // Atualiza o cliente pelo ID

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }

                MessageBox.Show("Dados do cliente atualizados com sucesso.");
            }

            this.Close(); // Fecha o formulário após salvar
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
            this.Close(); // Fecha o formulário sem salvar
        }
    }

}
