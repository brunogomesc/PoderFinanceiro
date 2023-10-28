using PoderFinanceiro.Screens;
using PoderFinanceiro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderFinanceiro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Validate user
        private void BtnAccess_Click(object sender, EventArgs e)
        {

            string username = txbLogin.Text.ToString();
            string password = txbPassword.Text.ToString();

            if (username == "" || password == "")
            {
                MessageBox.Show("Usuário ou senha não preenchidos!", "Dados não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            else
            {
                if (!Authentication.IsAuthenticateUser(username, password))
                {
                    MessageBox.Show("Usuário ou senha não válidados! Por favor digitar dados de acesso válidos.", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Usuário autenticado com sucesso!", "Autenticação concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;

                }
            }

        }
        #endregion

        #region Validates filling in the login field
        private void txbLogin_Leave(object sender, EventArgs e)
        {
            string username = txbLogin.Text.ToString();

            if(username == "")
            {
                lblLogin.ForeColor = Color.Red;
            }
            else
            {
                lblLogin.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Validates filling in the password field
        private void txbPassword_Leave(object sender, EventArgs e)
        {

            string password = txbPassword.Text.ToString();

            if (password == "")
            {
                lblPassword.ForeColor = Color.Red;
            }
            else
            {
                lblPassword.ForeColor = Color.Black;
            }

        }
        #endregion

    }
}
