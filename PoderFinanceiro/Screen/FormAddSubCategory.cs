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

    }
}
