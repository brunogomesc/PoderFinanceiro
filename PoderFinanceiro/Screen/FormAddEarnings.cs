using PoderFinanceiro.Service;
using PoderFinanceiro.Utils;
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
    public partial class FormAddEarnings : Form
    {

        private List<Model.Category> _categories;
        private List<Model.SubCategory> _subCategories;

        public FormAddEarnings()
        {
            InitializeComponent();
        }

        private void FormAddEarnings_Load(object sender, EventArgs e)
        {

            LoadCategories();
            LoadSubcategories();

        }

        private void LoadSubcategories()
        {
            _subCategories = new List<Model.SubCategory>();
            _subCategories = SubCategories.GetAllSubCategories();

            foreach(var subc in _subCategories)
            {
                lstSubCategories.Items.Add(subc.NameSubCategory);
            }

        }

        private void LoadCategories()
        {
            
            _categories = new List<Model.Category>();
            _categories = Categories.GetAllCategories();

            foreach(var category in _categories)
            {
                lstCategories.Items.Add(category.NameCategory);
            }

        }

        private void ChbRecorrente_CheckedChanged(object sender, EventArgs e)
        {

            if(chbRecorrente.Checked)
            {
                chbUnique.Checked = false;
            }

        }

        private void ChbUnique_CheckedChanged(object sender, EventArgs e)
        {

            if (chbUnique.Checked)
            {
                chbRecorrente.Checked = false;
            }

        }

        private void TxbEarningName_Leave(object sender, EventArgs e)
        {

            string earningName = txbEarningName.Text == "" ? string.Empty : txbEarningName.Text;

            if(string.IsNullOrEmpty(earningName))
            {
                lblErrorEarning.Text = "Nome do ganho não pode estar vazio";
                lblErrorEarning.ForeColor = Color.Red;
                lblErrorEarning.Visible = true;
            }
            else
            {
                lblErrorEarning.ForeColor = Color.Black;
                lblErrorEarning.Visible = false;
            }

        }

        private void MtbValue_Leave(object sender, EventArgs e)
        {

            string value = Clear.ClearMaskValue(mtbValue.Text) == "," ? string.Empty : Clear.ClearMaskValue(mtbValue.Text);

            if (string.IsNullOrEmpty(value))
            {
                lblErrorValue.Text = "O valor do ganho não pode estar vazio";
                lblErrorValue.ForeColor = Color.Red;
                lblErrorValue.Visible = true;
            }
            else
            {
                lblErrorValue.ForeColor = Color.Black;
                lblErrorValue.Visible = false;
            }

        }

        private void GoToHomepage()
        {
            this.Dispose();
        }

        private bool ValidateEarningType()
        {

            if(!chbRecorrente.Checked && !chbUnique.Checked)
            {

                lblErrorTypeEarning.Text = "Por favor selecionar o tipo de ganhos";
                lblErrorTypeEarning.ForeColor = Color.Red;
                lblErrorTypeEarning.Visible = true;

                return false;

            }

            return true;

        }

        private void BtnSaveEarning_Click(object sender, EventArgs e)
        {

            bool validateEarningType = ValidateEarningType();

            if(!validateEarningType)
            {

            }
            else
            {

                GoToHomepage();
            }

            
        }
    }
}
