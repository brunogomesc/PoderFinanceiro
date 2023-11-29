namespace PoderFinanceiro.Screens
{
    partial class FormAddExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbValue = new System.Windows.Forms.MaskedTextBox();
            this.lblErrorSubCategories = new System.Windows.Forms.Label();
            this.lblErrorCategories = new System.Windows.Forms.Label();
            this.lblErrorTypeEarning = new System.Windows.Forms.Label();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.lblErrorValue = new System.Windows.Forms.Label();
            this.lblErrorExpense = new System.Windows.Forms.Label();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.txbQuantityInstallments = new System.Windows.Forms.TextBox();
            this.chbInstallments = new System.Windows.Forms.CheckBox();
            this.chbUnique = new System.Windows.Forms.CheckBox();
            this.chbRecorrente = new System.Windows.Forms.CheckBox();
            this.txbObservation = new System.Windows.Forms.TextBox();
            this.lblObservation = new System.Windows.Forms.Label();
            this.mdcDataExpense = new System.Windows.Forms.MonthCalendar();
            this.lblValue = new System.Windows.Forms.Label();
            this.txbExpenseName = new System.Windows.Forms.TextBox();
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.lstSubCategories = new System.Windows.Forms.ListBox();
            this.lblListSubCategoriesName = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lblListCategoryName = new System.Windows.Forms.Label();
            this.gpbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbValue
            // 
            this.mtbValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mtbValue.Location = new System.Drawing.Point(309, 227);
            this.mtbValue.Mask = "R$ 00000.00";
            this.mtbValue.Name = "mtbValue";
            this.mtbValue.Size = new System.Drawing.Size(126, 30);
            this.mtbValue.TabIndex = 53;
            this.mtbValue.Leave += new System.EventHandler(this.MtbValue_Leave);
            // 
            // lblErrorSubCategories
            // 
            this.lblErrorSubCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorSubCategories.AutoSize = true;
            this.lblErrorSubCategories.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSubCategories.Location = new System.Drawing.Point(312, 69);
            this.lblErrorSubCategories.Name = "lblErrorSubCategories";
            this.lblErrorSubCategories.Size = new System.Drawing.Size(29, 13);
            this.lblErrorSubCategories.TabIndex = 52;
            this.lblErrorSubCategories.Text = "Error";
            this.lblErrorSubCategories.Visible = false;
            // 
            // lblErrorCategories
            // 
            this.lblErrorCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCategories.AutoSize = true;
            this.lblErrorCategories.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategories.Location = new System.Drawing.Point(43, 69);
            this.lblErrorCategories.Name = "lblErrorCategories";
            this.lblErrorCategories.Size = new System.Drawing.Size(29, 13);
            this.lblErrorCategories.TabIndex = 51;
            this.lblErrorCategories.Text = "Error";
            this.lblErrorCategories.Visible = false;
            // 
            // lblErrorTypeEarning
            // 
            this.lblErrorTypeEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTypeEarning.AutoSize = true;
            this.lblErrorTypeEarning.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTypeEarning.Location = new System.Drawing.Point(633, 56);
            this.lblErrorTypeEarning.Name = "lblErrorTypeEarning";
            this.lblErrorTypeEarning.Size = new System.Drawing.Size(29, 13);
            this.lblErrorTypeEarning.TabIndex = 50;
            this.lblErrorTypeEarning.Text = "Error";
            this.lblErrorTypeEarning.Visible = false;
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorDate.AutoSize = true;
            this.lblErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDate.Location = new System.Drawing.Point(629, 169);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(29, 13);
            this.lblErrorDate.TabIndex = 49;
            this.lblErrorDate.Text = "Error";
            this.lblErrorDate.Visible = false;
            // 
            // lblErrorValue
            // 
            this.lblErrorValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorValue.AutoSize = true;
            this.lblErrorValue.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValue.Location = new System.Drawing.Point(313, 208);
            this.lblErrorValue.Name = "lblErrorValue";
            this.lblErrorValue.Size = new System.Drawing.Size(29, 13);
            this.lblErrorValue.TabIndex = 48;
            this.lblErrorValue.Text = "Error";
            this.lblErrorValue.Visible = false;
            // 
            // lblErrorExpense
            // 
            this.lblErrorExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorExpense.AutoSize = true;
            this.lblErrorExpense.ForeColor = System.Drawing.Color.Red;
            this.lblErrorExpense.Location = new System.Drawing.Point(42, 208);
            this.lblErrorExpense.Name = "lblErrorExpense";
            this.lblErrorExpense.Size = new System.Drawing.Size(29, 13);
            this.lblErrorExpense.TabIndex = 47;
            this.lblErrorExpense.Text = "Error";
            this.lblErrorExpense.Visible = false;
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveExpense.Location = new System.Drawing.Point(380, 378);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(187, 61);
            this.btnSaveExpense.TabIndex = 46;
            this.btnSaveExpense.Text = "Salvar";
            this.btnSaveExpense.UseVisualStyleBackColor = true;
            this.btnSaveExpense.Click += new System.EventHandler(this.BtnSaveExpense_Click);
            // 
            // gpbOptions
            // 
            this.gpbOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbOptions.Controls.Add(this.txbQuantityInstallments);
            this.gpbOptions.Controls.Add(this.chbInstallments);
            this.gpbOptions.Controls.Add(this.chbUnique);
            this.gpbOptions.Controls.Add(this.chbRecorrente);
            this.gpbOptions.Location = new System.Drawing.Point(630, 74);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(227, 83);
            this.gpbOptions.TabIndex = 45;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Tipo Recebimento";
            // 
            // txbQuantityInstallments
            // 
            this.txbQuantityInstallments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbQuantityInstallments.Enabled = false;
            this.txbQuantityInstallments.Location = new System.Drawing.Point(84, 59);
            this.txbQuantityInstallments.Name = "txbQuantityInstallments";
            this.txbQuantityInstallments.Size = new System.Drawing.Size(29, 20);
            this.txbQuantityInstallments.TabIndex = 30;
            // 
            // chbInstallments
            // 
            this.chbInstallments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbInstallments.AutoSize = true;
            this.chbInstallments.Location = new System.Drawing.Point(7, 63);
            this.chbInstallments.Name = "chbInstallments";
            this.chbInstallments.Size = new System.Drawing.Size(67, 17);
            this.chbInstallments.TabIndex = 29;
            this.chbInstallments.Text = "Parcelas";
            this.chbInstallments.UseVisualStyleBackColor = true;
            this.chbInstallments.CheckedChanged += new System.EventHandler(this.ChbInstallments_CheckedChanged);
            // 
            // chbUnique
            // 
            this.chbUnique.AutoSize = true;
            this.chbUnique.Location = new System.Drawing.Point(7, 41);
            this.chbUnique.Name = "chbUnique";
            this.chbUnique.Size = new System.Drawing.Size(54, 17);
            this.chbUnique.TabIndex = 28;
            this.chbUnique.Text = "Unico";
            this.chbUnique.UseVisualStyleBackColor = true;
            this.chbUnique.CheckedChanged += new System.EventHandler(this.ChbUnique_CheckedChanged);
            // 
            // chbRecorrente
            // 
            this.chbRecorrente.AutoSize = true;
            this.chbRecorrente.Location = new System.Drawing.Point(7, 20);
            this.chbRecorrente.Name = "chbRecorrente";
            this.chbRecorrente.Size = new System.Drawing.Size(79, 17);
            this.chbRecorrente.TabIndex = 0;
            this.chbRecorrente.Text = "Recorrente";
            this.chbRecorrente.UseVisualStyleBackColor = true;
            this.chbRecorrente.CheckedChanged += new System.EventHandler(this.ChbRecorrente_CheckedChanged);
            // 
            // txbObservation
            // 
            this.txbObservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbObservation.Location = new System.Drawing.Point(38, 310);
            this.txbObservation.Multiline = true;
            this.txbObservation.Name = "txbObservation";
            this.txbObservation.Size = new System.Drawing.Size(489, 39);
            this.txbObservation.TabIndex = 44;
            // 
            // lblObservation
            // 
            this.lblObservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservation.AutoSize = true;
            this.lblObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservation.Location = new System.Drawing.Point(37, 277);
            this.lblObservation.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(100, 17);
            this.lblObservation.TabIndex = 43;
            this.lblObservation.Text = "Observação:";
            // 
            // mdcDataExpense
            // 
            this.mdcDataExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mdcDataExpense.Location = new System.Drawing.Point(621, 230);
            this.mdcDataExpense.MaxSelectionCount = 1;
            this.mdcDataExpense.Name = "mdcDataExpense";
            this.mdcDataExpense.TabIndex = 42;
            this.mdcDataExpense.TodayDate = new System.DateTime(2023, 11, 24, 0, 0, 0, 0);
            // 
            // lblValue
            // 
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(309, 187);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(88, 17);
            this.lblValue.TabIndex = 41;
            this.lblValue.Text = "Valor (R$):";
            // 
            // txbExpenseName
            // 
            this.txbExpenseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbExpenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbExpenseName.Location = new System.Drawing.Point(40, 226);
            this.txbExpenseName.Name = "txbExpenseName";
            this.txbExpenseName.Size = new System.Drawing.Size(217, 30);
            this.txbExpenseName.TabIndex = 40;
            this.txbExpenseName.Leave += new System.EventHandler(this.TxbExpenseName_Leave);
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseName.Location = new System.Drawing.Point(39, 187);
            this.lblExpenseName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(76, 17);
            this.lblExpenseName.TabIndex = 39;
            this.lblExpenseName.Text = "Despesa:";
            // 
            // lstSubCategories
            // 
            this.lstSubCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSubCategories.FormattingEnabled = true;
            this.lstSubCategories.Location = new System.Drawing.Point(309, 88);
            this.lstSubCategories.Name = "lstSubCategories";
            this.lstSubCategories.Size = new System.Drawing.Size(217, 69);
            this.lstSubCategories.TabIndex = 38;
            // 
            // lblListSubCategoriesName
            // 
            this.lblListSubCategoriesName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListSubCategoriesName.AutoSize = true;
            this.lblListSubCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSubCategoriesName.Location = new System.Drawing.Point(309, 48);
            this.lblListSubCategoriesName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblListSubCategoriesName.Name = "lblListSubCategoriesName";
            this.lblListSubCategoriesName.Size = new System.Drawing.Size(125, 17);
            this.lblListSubCategoriesName.TabIndex = 37;
            this.lblListSubCategoriesName.Text = "Sub-Categorias:";
            // 
            // lstCategories
            // 
            this.lstCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(40, 88);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(217, 69);
            this.lstCategories.TabIndex = 36;
            // 
            // lblListCategoryName
            // 
            this.lblListCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListCategoryName.AutoSize = true;
            this.lblListCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCategoryName.Location = new System.Drawing.Point(39, 48);
            this.lblListCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblListCategoryName.Name = "lblListCategoryName";
            this.lblListCategoryName.Size = new System.Drawing.Size(91, 17);
            this.lblListCategoryName.TabIndex = 35;
            this.lblListCategoryName.Text = "Categorias:";
            // 
            // FormAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 486);
            this.ControlBox = false;
            this.Controls.Add(this.mtbValue);
            this.Controls.Add(this.lblErrorSubCategories);
            this.Controls.Add(this.lblErrorCategories);
            this.Controls.Add(this.lblErrorTypeEarning);
            this.Controls.Add(this.lblErrorDate);
            this.Controls.Add(this.lblErrorValue);
            this.Controls.Add(this.lblErrorExpense);
            this.Controls.Add(this.btnSaveExpense);
            this.Controls.Add(this.gpbOptions);
            this.Controls.Add(this.txbObservation);
            this.Controls.Add(this.lblObservation);
            this.Controls.Add(this.mdcDataExpense);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txbExpenseName);
            this.Controls.Add(this.lblExpenseName);
            this.Controls.Add(this.lstSubCategories);
            this.Controls.Add(this.lblListSubCategoriesName);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblListCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddExpense";
            this.Load += new System.EventHandler(this.FormAddExpense_Load);
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbValue;
        private System.Windows.Forms.Label lblErrorSubCategories;
        private System.Windows.Forms.Label lblErrorCategories;
        private System.Windows.Forms.Label lblErrorTypeEarning;
        private System.Windows.Forms.Label lblErrorDate;
        private System.Windows.Forms.Label lblErrorValue;
        private System.Windows.Forms.Label lblErrorExpense;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.CheckBox chbUnique;
        private System.Windows.Forms.CheckBox chbRecorrente;
        private System.Windows.Forms.TextBox txbObservation;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.MonthCalendar mdcDataExpense;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txbExpenseName;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.ListBox lstSubCategories;
        private System.Windows.Forms.Label lblListSubCategoriesName;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label lblListCategoryName;
        private System.Windows.Forms.CheckBox chbInstallments;
        private System.Windows.Forms.TextBox txbQuantityInstallments;
    }
}