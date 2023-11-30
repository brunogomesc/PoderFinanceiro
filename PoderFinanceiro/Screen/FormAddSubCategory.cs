using PoderFinanceiro.DataCommands;
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

namespace PoderFinanceiro.Screen
{
    public partial class FormAddSubCategory : Form
    {

        private List<Model.Category> _categories;
        private List<Model.SubCategory> _subCategories;

        public FormAddSubCategory()
        {
            InitializeComponent();
        }

        private void FormAddSubCategory_Load(object sender, EventArgs e)
        {

            LoadIcons();
            LoadCategories();
            LoadSubCategories();

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

            foreach (var category in _categories)
            {

                lstCategories.Items.Add(category.NameCategory);

            }

        }

        private void LoadSubCategories()
        {

            _subCategories = new List<Model.SubCategory>();
            _subCategories = SubCategories.GetAllSubCategories();

        }

        private void BtnRegisterSubCategory_Click(object sender, EventArgs e)
        {
            string NameSubCategory = txbSubCategoryName.Text;
            string NameIconSubCategory = lstViewIcon.SelectedItems.Count > 0 ? lstViewIcon.SelectedItems[0].Text : string.Empty;
            string CategorySelected = lstCategories.SelectedItems.Count > 0 ? lstCategories.SelectedItems[0].ToString() : string.Empty;

            if (String.IsNullOrEmpty(NameSubCategory))
                MessageBox.Show("Nome da categoria não preenchido!", "Dados não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (String.IsNullOrEmpty(NameIconSubCategory))
                MessageBox.Show("Icone da categoria não selecionado", "Dados não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (String.IsNullOrEmpty(CategorySelected))
                MessageBox.Show("Categoria não selecionada", "Dados não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                Guid idCategory = _categories.Where(c => c.NameCategory == CategorySelected).Select(i => i.Id).First();

                SubCategories.SaveCategory(NameSubCategory, NameIconSubCategory, idCategory);
                MessageBox.Show("Subcategoria criada com sucesso!", "Informação salva com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GoToHomepage();
        }

        private void TxbSubCategoryName_Leave(object sender, EventArgs e)
        {

            string SubCategoryName = txbSubCategoryName.Text;

            if (_subCategories.Where(scn => scn.NameSubCategory == SubCategoryName).Count() > 0)
            {
                lblErrorSubCategoryName.ForeColor = Color.Red;
                lblErrorSubCategoryName.Text = "Nome da Sub categoria já existe!";
                lblErrorSubCategoryName.Visible = true;
            }
            else
            {
                lblErrorSubCategoryName.ForeColor = Color.Black;
                lblErrorSubCategoryName.Visible = false;
            }

        }

        private void GoToHomepage()
        {
            this.Dispose();
        }
    }
}
