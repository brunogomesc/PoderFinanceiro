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
using System.IO;
using PoderFinanceiro.Properties;

namespace PoderFinanceiro.Screens
{
    public partial class ViewCategory : Form
    {

        private List<Model.Category> _categories;

        public ViewCategory()
        {
            InitializeComponent();
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {

            LoadCategories();

            dgvCategories.DataSource = _categories;

        }

        private void LoadCategories()
        {

            _categories = Categories.GetAllCategories();

        }

    }
}
