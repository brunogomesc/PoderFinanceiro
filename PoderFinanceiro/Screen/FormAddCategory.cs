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

namespace PoderFinanceiro.Screens
{
    public partial class FormAddCategory : Form
    {
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

        }

        private void LstViewIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbViewIcon.Image = Properties.Resources.wallet_add;
        }

        private void TxbCategoryName_Leave(object sender, EventArgs e)
        {

            lblErrorCategoryName.ForeColor = Color.Red;
            lblErrorCategoryName.Text = "Nome da categoria já existe!";
            lblErrorCategoryName.Visible = true;

        }
    }
}
