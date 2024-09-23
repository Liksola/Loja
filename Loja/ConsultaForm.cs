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
                btnBuscar_Click(sender, e); // Atualiza a lista após a exclusão
            }
            else
            {
                MessageBox.Show("Selecione um cliente para Excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Obtém os dados do cliente selecionado no DataGridView
                int id = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["Id"].Value);
                string nome = dataGridViewClientes.SelectedRows[0].Cells["Nome"].Value.ToString();
                string cpf = dataGridViewClientes.SelectedRows[0].Cells["CPF"].Value.ToString();
                string email = dataGridViewClientes.SelectedRows[0].Cells["Email"].Value.ToString();
                string telefone = dataGridViewClientes.SelectedRows[0].Cells["Telefone"].Value.ToString();
                string endereco = dataGridViewClientes.SelectedRows[0].Cells["Endereco"].Value.ToString();

                // Abre o formulário de edição com os dados do cliente selecionado
                CadastroForm editarForm = new CadastroForm(id, nome, cpf, email, telefone, endereco);
                editarForm.ShowDialog();

                // Atualiza a lista de clientes após a edição
                btnBuscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
