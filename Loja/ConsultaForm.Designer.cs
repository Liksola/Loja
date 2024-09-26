namespace Loja
{
    partial class ConsultaForm
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            dataGridViewClientes = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(8, 113);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(203, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(8, 155);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 49);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(123, 352);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 48);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(12, 352);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 48);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 80);
            label1.Name = "label1";
            label1.Size = new Size(200, 21);
            label1.TabIndex = 4;
            label1.Tag = " ";
            label1.Text = "nome ou CPF do Cliente :";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(253, 63);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(646, 337);
            dataGridViewClientes.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 59);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 6;
            label2.Text = "Para buscar, digite o";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(478, 27);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 7;
            label3.Text = "Tabela de clientes ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 258);
            label4.Name = "label4";
            label4.Size = new Size(239, 76);
            label4.TabIndex = 8;
            label4.Text = "Para editar ou excluir um cliente, selecione na tabela e clique na ação desejada :";
            // 
            // ConsultaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewClientes);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "ConsultaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Consulta";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
        private DataGridView dataGridViewClientes;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}