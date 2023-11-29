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
    public partial class FormAddExpense : Form
    {

        private List<Model.Category> _categories;
        private List<Model.SubCategory> _subCategories;

        public FormAddExpense()
        {
            InitializeComponent();
        }

        private void FormAddExpense_Load(object sender, EventArgs e)
        {

            LoadCategories();
            LoadSubcategories();

        }

        private void LoadSubcategories()
        {
            _subCategories = new List<Model.SubCategory>();
            _subCategories = SubCategories.GetAllSubCategories();

            foreach (var subc in _subCategories)
            {
                lstSubCategories.Items.Add(subc.NameSubCategory);
            }

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

        private void ChbRecorrente_CheckedChanged(object sender, EventArgs e)
        {

            if (chbRecorrente.Checked)
            {
                chbUnique.Checked = false;
                chbInstallments.Checked = false;
                txbQuantityInstallments.Enabled = false;
            }

        }

        private void ChbUnique_CheckedChanged(object sender, EventArgs e)
        {

            if (chbUnique.Checked)
            {
                chbRecorrente.Checked = false;
                chbInstallments.Checked = false;
                txbQuantityInstallments.Enabled = false;
            }

        }

        private void ChbInstallments_CheckedChanged(object sender, EventArgs e)
        {

            if (chbInstallments.Checked)
            {
                chbRecorrente.Checked = false;
                chbUnique.Checked = false;
                txbQuantityInstallments.Enabled = true;
            }

        }

        private void TxbExpenseName_Leave(object sender, EventArgs e)
        {

            string expenseName = txbExpenseName.Text == "" ? string.Empty : txbExpenseName.Text;

            if (string.IsNullOrEmpty(expenseName))
            {
                lblErrorExpense.Text = "Nome do ganho não pode estar vazio";
                lblErrorExpense.ForeColor = Color.Red;
                lblErrorExpense.Visible = true;
            }
            else
            {
                lblErrorExpense.ForeColor = Color.Black;
                lblErrorExpense.Visible = false;
            }

        }

        private void MtbValue_Leave(object sender, EventArgs e)
        {

            string value = Clear.ClearMaskValue(mtbValue.Text) == "." ? string.Empty : Clear.ClearMaskValue(mtbValue.Text);

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

        private bool ValidateSaveExpense()
        {

            bool isValid = true;

            if (!chbRecorrente.Checked && !chbUnique.Checked && !chbInstallments.Checked)
            {

                lblErrorTypeEarning.Text = "Por favor selecionar o tipo de ganhos";
                lblErrorTypeEarning.ForeColor = Color.Red;
                lblErrorTypeEarning.Visible = true;

                isValid = false;

            }

            if (Clear.ClearMaskValue(mtbValue.Text) == ".")
            {

                lblErrorValue.Text = "O valor do ganho não pode estar vazio";
                lblErrorValue.ForeColor = Color.Red;
                lblErrorValue.Visible = true;

                isValid = false;


            }

            if (txbExpenseName.Text == "")
            {

                lblErrorExpense.Text = "Nome do ganho não pode estar vazio";
                lblErrorExpense.ForeColor = Color.Red;
                lblErrorExpense.Visible = true;

                isValid = false;

            }

            if (mdcDataExpense.SelectionEnd == null)
            {

                lblErrorDate.Text = "Data do ganho não pode estar vazia";
                lblErrorDate.ForeColor = Color.Red;
                lblErrorDate.Visible = true;

                isValid = false;

            }

            if (lstCategories.SelectedIndex == -1)
            {

                lblErrorCategories.Text = "A categoria não foi selecionada";
                lblErrorCategories.ForeColor = Color.Red;
                lblErrorCategories.Visible = true;

                isValid = false;

            }

            if (lstSubCategories.SelectedIndex == -1)
            {

                lblErrorSubCategories.Text = "A subcategoria não foi selecionada";
                lblErrorSubCategories.ForeColor = Color.Red;
                lblErrorSubCategories.Visible = true;

                isValid = false;

            }

            return isValid;

        }

        private string SelectTypeExpense()
        {

            string typeExpense = string.Empty;

            if(chbRecorrente.Checked)
            {
                typeExpense = chbRecorrente.Text;
            }
            else if(chbUnique.Checked)
            {
                typeExpense = chbUnique.Text;
            }
            else if(chbInstallments.Checked)
            {
                typeExpense = chbInstallments.Text;
            }

            return typeExpense;

        }

        private void BtnSaveExpense_Click(object sender, EventArgs e)
        {

            bool validateEarningType = ValidateSaveExpense();

            if (validateEarningType)
            {

                string CategorySelected = lstCategories.SelectedItems.Count > 0 ? lstCategories.SelectedItems[0].ToString() : string.Empty;
                string SubCategorySelected = lstSubCategories.SelectedItems.Count > 0 ? lstSubCategories.SelectedItems[0].ToString() : string.Empty;
                string TypeExpense = SelectTypeExpense();
                int QuantityInstallments = TypeExpense == "Parcelas" ? Convert.ToInt32(txbQuantityInstallments.Text) : 0;
                string NameExpense = txbExpenseName.Text;
                decimal ValueExpense = Convert.ToDecimal(Clear.ClearMaskValue(mtbValue.Text));
                DateTime ExpenseDate = mdcDataExpense.SelectionEnd;
                string Observation = txbObservation.Text;

                Guid idCategory = _categories.Where(c => c.NameCategory == CategorySelected).Select(i => i.Id).First();
                Guid idSubCategory = _subCategories.Where(c => c.NameSubCategory == SubCategorySelected).Select(i => i.Id).First();

                Expenses.SaveExpense(idCategory, idSubCategory, TypeExpense, QuantityInstallments, NameExpense, ValueExpense, ExpenseDate, Observation);

                GoToHomepage();

            }
            else
            {

                MessageBox.Show("Por favor verificar, pois existem campos que foram preenchidos incorretamente", "Dados incorretos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

    }
}
