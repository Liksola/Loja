namespace Loja
{
    partial class MainForm
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
            btnCadastrarCliente = new Button();
            btnConsultarCliente = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 83);
            label1.Name = "label1";
            label1.Size = new Size(212, 21);
            label1.TabIndex = 0;
            label1.Text = "Escolha a opção desejada :";
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarCliente.Location = new Point(116, 149);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(128, 49);
            btnCadastrarCliente.TabIndex = 1;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarCliente.Location = new Point(116, 218);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(128, 49);
            btnConsultarCliente.TabIndex = 2;
            btnConsultarCliente.Text = "Consultar Cliente";
            btnConsultarCliente.UseVisualStyleBackColor = true;
            btnConsultarCliente.Click += btnConsultarCliente_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(143, 372);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(74, 44);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 450);
            Controls.Add(btnSair);
            Controls.Add(btnConsultarCliente);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de escolha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastrarCliente;
        private Button btnConsultarCliente;
        private Button btnSair;
    }
}