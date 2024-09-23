namespace Loja
{
    partial class CadastroForm
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
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 170);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(162, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(128, 199);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(162, 23);
            txtCPF.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(128, 257);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(162, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(128, 286);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(162, 23);
            txtEndereco.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 178);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 202);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 228);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 260);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefone ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 294);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 90);
            label6.Name = "label6";
            label6.Size = new Size(228, 15);
            label6.TabIndex = 10;
            label6.Text = "Preencha corretamente os campos abaixo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(53, 350);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(215, 350);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(134, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Name = "CadastroForm";
            Text = "Tela de Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;
    }
}