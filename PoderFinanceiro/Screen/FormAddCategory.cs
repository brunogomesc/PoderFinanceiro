using PoderFinanceiro.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoderFinanceiro.DataCommands;
using PoderFinanceiro.Model;

namespace PoderFinanceiro.Screens
{
    public partial class FormAddCategory : Form
    {

        private List<Model.Category> _categories;

        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {

            LoadIcons();
            LoadCategories();

        }

        private void LoadIcons()
        {

            lstViewIcon.View = View.LargeIcon;
            lstViewIcon.LargeImageList = Icons.ListIconsImageList();
            lstViewIcon.Items.AddRange(Icons.ListIconsViewItem());

        }

        private void LoadCategories()
        {

            _categories = new List<Model.Category>();
            _categories = Categories.GetAllCategories();

        }

        private void LstViewIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbViewIcon.Image = Properties.Resources.wallet_add;
        }

        private void TxbCategoryName_Leave(object sender, EventArgs e)
        {

            string CategoryName = txbCategoryName.Text;

            if(_categories.Where(cn => cn.NameCategory == CategoryName).Count() > 0)
            {
                lblErrorCategoryName.ForeColor = Color.Red;
                lblErrorCategoryName.Text = "Nome da categoria já existe!";
                lblErrorCategoryName.Visible = true;
            }
            else
            {
                lblErrorCategoryName.ForeColor = Color.Black;
                lblErrorCategoryName.Visible = false;
            }

        }

        private void BtnRegisterCategory_Click(object sender, EventArgs e)
        {

            string NameCategory = txbCategoryName.Text;
            string NameIconCategory = lstViewIcon.SelectedItems.Count > 0 ? lstViewIcon.SelectedItems[0].Text : string.Empty;

            if(String.IsNullOrEmpty(NameCategory))
                MessageBox.Show("Nome da categoria não preenchido!", "Dados não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if(String.IsNullOrEmpty(NameIconCategory))
                MessageBox.Show("Icone da categoria não selecionado", "Dados não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                Categories.SaveCategory(NameCategory, NameIconCategory);
                MessageBox.Show("Categoria criada com sucesso!", "Informação salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GoToHomepage();

        }


        private void GoToHomepage()
        {
            this.Dispose();
        }

    }
}
