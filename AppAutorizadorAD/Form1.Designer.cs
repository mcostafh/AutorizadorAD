using System;

namespace AppAutorizadorAD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_usuario = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_dominio = new System.Windows.Forms.TextBox();
            this.edit_senha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // edit_usuario
            // 
            this.edit_usuario.Location = new System.Drawing.Point(15, 40);
            this.edit_usuario.Name = "edit_usuario";
            this.edit_usuario.Size = new System.Drawing.Size(100, 20);
            this.edit_usuario.TabIndex = 3;
            this.edit_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(269, 40);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Domínio:porta";
            // 
            // edit_dominio
            // 
            this.edit_dominio.Location = new System.Drawing.Point(15, 88);
            this.edit_dominio.Name = "edit_dominio";
            this.edit_dominio.Size = new System.Drawing.Size(216, 20);
            this.edit_dominio.TabIndex = 7;
            // 
            // edit_senha
            // 
            this.edit_senha.Location = new System.Drawing.Point(131, 40);
            this.edit_senha.Name = "edit_senha";
            this.edit_senha.PasswordChar = '*';
            this.edit_senha.Size = new System.Drawing.Size(100, 20);
            this.edit_senha.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 129);
            this.Controls.Add(this.edit_senha);
            this.Controls.Add(this.edit_dominio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.edit_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autenticar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void o_Click(object sender, EventArgs e)
        {


            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_usuario;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_dominio;
        private System.Windows.Forms.MaskedTextBox edit_senha;
    }
}

