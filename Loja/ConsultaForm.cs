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
    public partial class ConsultaForm : Form
    {
        private SQLiteConnectionManager connectionManager;

        public ConsultaForm()
        {
            InitializeComponent();
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);

            // Carrega todos os clientes ao abrir o formulário
            CarregarTodosClientes();
        }

        // Método para carregar todos os clientes
        private void CarregarTodosClientes()
        {
            string query = "SELECT * FROM Cliente";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewClientes.DataSource = dt; // Atribui os clientes ao DataGridView
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = txtBuscar.Text;
            string query = $"SELECT * FROM Cliente WHERE Nome LIKE '%{searchValue}%' OR CPF LIKE '%{searchValue}%'";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewClientes.DataSource = dt;
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);

                string deleteQuery = $"DELETE FROM Cliente WHERE Id = {id}";
                connectionManager.ExecuteNonQuery(deleteQuery);

                MessageBox.Show("Cliente excluído com sucesso.");
                CarregarTodosClientes(); // Atualiza a lista após a exclusão
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);
                string nome = dataGridViewClientes.SelectedRows[0].Cells["Nome"].Value?.ToString() ?? "Sem nome";
                string cpf = dataGridViewClientes.SelectedRows[0].Cells["CPF"].Value?.ToString() ?? "Sem cpf";
                string email = dataGridViewClientes.SelectedRows[0].Cells["Email"].Value?.ToString() ?? "Sem email";
                string telefone = dataGridViewClientes.SelectedRows[0].Cells["Telefone"].Value?.ToString() ?? "Sem telefone";
                string endereco = dataGridViewClientes.SelectedRows[0].Cells["Endereco"].Value?.ToString() ?? "Sem endereco";

                // Abre o formulário de edição com os dados do cliente selecionado
                CadastroForm editarForm = new CadastroForm(id, nome, cpf, email, telefone, endereco);
                editarForm.ShowDialog();

                // Atualiza a lista de clientes após a edição
                CarregarTodosClientes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
