namespace Loja
{
    partial class ConsultaFuncionariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBuscarFuncionario = new TextBox();
            dataGridViewFuncionarios = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label2 = new Label();
            bntBuscar = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(225, 69);
            label1.TabIndex = 0;
            label1.Text = "Digite o Usuário ou nome do funcionário para buscar : ";
            // 
            // txtBuscarFuncionario
            // 
            txtBuscarFuncionario.Location = new Point(12, 98);
            txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            txtBuscarFuncionario.Size = new Size(225, 23);
            txtBuscarFuncionario.TabIndex = 1;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.AllowUserToOrderColumns = true;
            dataGridViewFuncionarios.BackgroundColor = SystemColors.Info;
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Location = new Point(270, 42);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.Size = new Size(491, 434);
            dataGridViewFuncionarios.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(12, 430);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 46);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(12, 295);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 45);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(130, 295);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 45);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(419, 9);
            label2.Name = "label2";
            label2.Size = new Size(185, 21);
            label2.TabIndex = 6;
            label2.Text = "Tabela de Funcionários";
            // 
            // bntBuscar
            // 
            bntBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntBuscar.Location = new Point(12, 146);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(75, 44);
            bntBuscar.TabIndex = 7;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 208);
            label3.Name = "label3";
            label3.Size = new Size(262, 84);
            label3.TabIndex = 8;
            label3.Text = "Para editar ou excluir um funcionário, selecione na tabela e clique na ação desejada :";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 359);
            label4.Name = "label4";
            label4.Size = new Size(230, 56);
            label4.TabIndex = 9;
            label4.Text = "Clique aqui para adicionar um novo funcionário :";
            // 
            // ConsultaFuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 515);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bntBuscar);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridViewFuncionarios);
            Controls.Add(txtBuscarFuncionario);
            Controls.Add(label1);
            Name = "ConsultaFuncionariosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Consulta Funcionarios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarFuncionario;
        private DataGridView dataGridViewFuncionarios;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label2;
        private Button bntBuscar;
        private Label label3;
        private Label label4;
    }
}