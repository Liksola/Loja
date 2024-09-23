namespace Loja
{
    partial class CadastroFuncionarioForm
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
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtConfirmarSenha = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 124);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(126, 156);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(126, 217);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(126, 185);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 132);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 159);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 220);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 6;
            label3.Text = "Confirmar Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 188);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 69);
            label6.Name = "label6";
            label6.Size = new Size(228, 15);
            label6.TabIndex = 11;
            label6.Text = "Preencha corretamente os campos abaixo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(25, 283);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 43);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(178, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 43);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastroFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 394);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Name = "CadastroFuncionarioForm";
            Text = "Tela de Cadastro de Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtConfirmarSenha;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}