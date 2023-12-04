using PoderFinanceiro.Screen;
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

        #region Events

        #region Render homepage content (HomepageContainer_Load)
        private void HomepageContainer_Load(object sender, EventArgs e)
        {
            HomepageContent homepageContent = new HomepageContent();

            homepageContent.Text = "Homepage";

            homepageContent.WindowState = FormWindowState.Maximized;

            homepageContent.MdiParent = this;

            homepageContent.Show();
        }
        #endregion

        #region Render Add Expense content (SmiAddExpense_Click)
        private void SmiAddExpense_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            FormAddExpense formAddExpense = new FormAddExpense();

            // Atribui um titulo ao formulário
            formAddExpense.Text = "Adicionar Despesas";

            // Maximiza o formulário filho
            formAddExpense.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Define quem o pai desta janela
            formAddExpense.MdiParent = this;

            // exibe o formulário
            formAddExpense.Show();
        }
        #endregion

        #region Render Add Esarnings content (SmiAddEarnings_Click)
        private void SmiAddEarnings_Click(object sender, EventArgs e)
        {
            FormAddEarnings formAddEarnings = new FormAddEarnings();

            formAddEarnings.Text = "Adicionar Ganhos";

            formAddEarnings.WindowState = FormWindowState.Maximized;

            formAddEarnings.MdiParent = this;

            formAddEarnings.Show();
        }
        #endregion


        #region Render Add Category content (SmiCategory_Click)
        private void SmiCategory_Click(object sender, EventArgs e)
        {

            FormAddCategory formAddCategory = new FormAddCategory();

            formAddCategory.Text = "Adicionar Categoria";

            formAddCategory.StartPosition = FormStartPosition.CenterScreen;

            formAddCategory.MdiParent = this;

            formAddCategory.Show();

        }
        #endregion

        #region Render Add SubCategory content (SmiSubCategory_Click)
        private void SmiSubCategory_Click(object sender, EventArgs e)
        {

            FormAddSubCategory formAddSubCategory = new FormAddSubCategory();

            formAddSubCategory.Text = "Adicionar Sub Categoria";

            formAddSubCategory.StartPosition = FormStartPosition.CenterScreen;

            formAddSubCategory.MdiParent = this;

            formAddSubCategory.Show();

        }
        #endregion

        private void MniHome_Click(object sender, EventArgs e)
        {

            HomepageContent homepageContent = new HomepageContent();

            homepageContent.Text = "Homepage";

            homepageContent.WindowState = FormWindowState.Maximized;

            homepageContent.MdiParent = this;

            homepageContent.Show();

        }

        #endregion

        private void SmiViewCategory_Click(object sender, EventArgs e)
        {

            ViewCategory viewCategory = new ViewCategory();

            viewCategory.Text = "Visualizar Categorias";

            viewCategory.StartPosition = FormStartPosition.CenterScreen;

            viewCategory.MdiParent = this;

            viewCategory.Show();

        }
    }
}
