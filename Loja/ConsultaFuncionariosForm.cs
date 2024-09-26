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
    public partial class ConsultaFuncionariosForm : Form
    {
        private SQLiteConnectionManager connectionManager;

        public ConsultaFuncionariosForm()
        {
            InitializeComponent();
            string databasePath = "loja.db";
            connectionManager = new SQLiteConnectionManager(databasePath);

            // Carrega a lista de funcionários ao abrir o formulário
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            string query = "SELECT * FROM Funcionarios";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewFuncionarios.DataSource = dt; // Atribui os clientes ao DataGridView
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = txtBuscarFuncionario.Text;
            string query = $"SELECT * FROM Funcionarios WHERE Usuario LIKE '%{searchValue}%' OR Nome LIKE '%{searchValue}%'";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewFuncionarios.DataSource = dt;
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Abre o formulário de cadastro de funcionário para adicionar novo funcionário
            CadastroFuncionarioForm cadastroFuncionarioForm = new CadastroFuncionarioForm();
            cadastroFuncionarioForm.ShowDialog();

            // Recarrega a lista de funcionários após a adição
            CarregarFuncionarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                // Obtém os dados do funcionário selecionado
                 int id = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells["Id"].Value);
                 string nome = dataGridViewFuncionarios.SelectedRows[0].Cells["Nome"].Value?.ToString() ?? "Sem Nome";
                 string usuario = dataGridViewFuncionarios.SelectedRows[0].Cells["Usuario"].Value?.ToString() ?? "Sem Usuário";
                 string senha = dataGridViewFuncionarios.SelectedRows[0].Cells["Senha"].Value?.ToString() ?? "Sem Senha";
                
                // Abre o formulário de edição com os dados do funcionário selecionado
                CadastroFuncionarioForm editarForm = new CadastroFuncionarioForm(id, nome, usuario, senha);
                editarForm.ShowDialog();
              
                // Recarrega a lista de funcionários após a edição
                CarregarFuncionarios();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells["Id"].Value);

                // Confirma a exclusão
                DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir o funcionário?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    string deleteQuery = $"DELETE FROM Funcionarios WHERE Id = @Id";

                    using (var connection = connectionManager.GetConnection())
                    {
                        connectionManager.OpenConnection(connection);

                        using (var command = new SqliteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();
                        }

                        connectionManager.CloseConnection(connection);
                    }

                    MessageBox.Show("Funcionário excluído com sucesso.");
                    CarregarFuncionarios(); // Atualiza a lista de funcionários após a exclusão
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
