using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAutorizadorAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(edit_usuario.Text) && !string.IsNullOrWhiteSpace(edit_senha.Text) &&
                !string.IsNullOrWhiteSpace(edit_dominio.Text))
            {

                try
                {
                    DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://"+ edit_dominio.Text, edit_usuario.Text, edit_senha.Text);
                    DirectorySearcher directorySearcher = new DirectorySearcher(directoryEntry);
                    directorySearcher.Filter = "(SAMAccountName=" + edit_usuario.Text + ")";
                    SearchResult searchResult = directorySearcher.FindOne();
                    if ((Int32)searchResult.Properties["userAccountControl"][0] == 512)
                    {
                        MessageBox.Show("Usuário Autenticado!");
                    }
                    else
                    {
                        MessageBox.Show("ERRO: Usuário/Senha Inválido!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
            }


        }
    }
}
