using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderFinanceiro.Screens
{
    public partial class HomepageContainer : Form
    {
        public HomepageContainer()
        {
            InitializeComponent();
        }

        private void AdicionarDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            FormAddExpense formAddExpense = new FormAddExpense();

            // Atribui um titulo ao formulário
            formAddExpense.Text = "Adicionar Despesa";

            // Altera a cor de fundo do formulário
            formAddExpense.BackColor = System.Drawing.Color.Blue;

            // Maximiza o formulário filho
            formAddExpense.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Define quem o pai desta janela
            formAddExpense.MdiParent = this;

            // exibe o formulário
            formAddExpense.Show();
        }
    }
}
