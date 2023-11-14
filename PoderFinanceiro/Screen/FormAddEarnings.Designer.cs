namespace PoderFinanceiro.Screens
{
    partial class FormAddEarnings
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
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lblListCategoryName = new System.Windows.Forms.Label();
            this.lstSubCategories = new System.Windows.Forms.ListBox();
            this.lblListSubCategoriesName = new System.Windows.Forms.Label();
            this.txbEarningName = new System.Windows.Forms.TextBox();
            this.lblEarningName = new System.Windows.Forms.Label();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.mdcDataEarning = new System.Windows.Forms.MonthCalendar();
            this.txbObservation = new System.Windows.Forms.TextBox();
            this.lblObservation = new System.Windows.Forms.Label();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.chbRecorrente = new System.Windows.Forms.CheckBox();
            this.chbUnique = new System.Windows.Forms.CheckBox();
            this.btnSaveEarning = new System.Windows.Forms.Button();
            this.lblErrorEarning = new System.Windows.Forms.Label();
            this.lblErrorValue = new System.Windows.Forms.Label();
            this.lblErrorDate = new System.Windows.Forms.Label();
            this.lblErrorTypeEarning = new System.Windows.Forms.Label();
            this.lblErrorCategories = new System.Windows.Forms.Label();
            this.lblSubCategories = new System.Windows.Forms.Label();
            this.gpbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(27, 56);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(217, 69);
            this.lstCategories.TabIndex = 15;
            // 
            // lblListCategoryName
            // 
            this.lblListCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListCategoryName.AutoSize = true;
            this.lblListCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCategoryName.Location = new System.Drawing.Point(26, 16);
            this.lblListCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblListCategoryName.Name = "lblListCategoryName";
            this.lblListCategoryName.Size = new System.Drawing.Size(91, 17);
            this.lblListCategoryName.TabIndex = 14;
            this.lblListCategoryName.Text = "Categorias:";
            // 
            // lstSubCategories
            // 
            this.lstSubCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSubCategories.FormattingEnabled = true;
            this.lstSubCategories.Location = new System.Drawing.Point(296, 56);
            this.lstSubCategories.Name = "lstSubCategories";
            this.lstSubCategories.Size = new System.Drawing.Size(217, 69);
            this.lstSubCategories.TabIndex = 17;
            // 
            // lblListSubCategoriesName
            // 
            this.lblListSubCategoriesName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListSubCategoriesName.AutoSize = true;
            this.lblListSubCategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSubCategoriesName.Location = new System.Drawing.Point(296, 16);
            this.lblListSubCategoriesName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblListSubCategoriesName.Name = "lblListSubCategoriesName";
            this.lblListSubCategoriesName.Size = new System.Drawing.Size(125, 17);
            this.lblListSubCategoriesName.TabIndex = 16;
            this.lblListSubCategoriesName.Text = "Sub-Categorias:";
            // 
            // txbEarningName
            // 
            this.txbEarningName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEarningName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbEarningName.Location = new System.Drawing.Point(27, 194);
            this.txbEarningName.Name = "txbEarningName";
            this.txbEarningName.Size = new System.Drawing.Size(217, 30);
            this.txbEarningName.TabIndex = 19;
            // 
            // lblEarningName
            // 
            this.lblEarningName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEarningName.AutoSize = true;
            this.lblEarningName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarningName.Location = new System.Drawing.Point(26, 155);
            this.lblEarningName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblEarningName.Name = "lblEarningName";
            this.lblEarningName.Size = new System.Drawing.Size(61, 17);
            this.lblEarningName.TabIndex = 18;
            this.lblEarningName.Text = "Ganho:";
            // 
            // txbValue
            // 
            this.txbValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbValue.Location = new System.Drawing.Point(296, 194);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(126, 30);
            this.txbValue.TabIndex = 21;
            // 
            // lblValue
            // 
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(296, 155);
            this.lblValue.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(88, 17);
            this.lblValue.TabIndex = 20;
            this.lblValue.Text = "Valor (R$):";
            // 
            // mdcDataEarning
            // 
            this.mdcDataEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mdcDataEarning.Location = new System.Drawing.Point(608, 198);
            this.mdcDataEarning.Name = "mdcDataEarning";
            this.mdcDataEarning.TabIndex = 23;
            // 
            // txbObservation
            // 
            this.txbObservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbObservation.Location = new System.Drawing.Point(25, 278);
            this.txbObservation.Multiline = true;
            this.txbObservation.Name = "txbObservation";
            this.txbObservation.Size = new System.Drawing.Size(489, 39);
            this.txbObservation.TabIndex = 25;
            // 
            // lblObservation
            // 
            this.lblObservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservation.AutoSize = true;
            this.lblObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservation.Location = new System.Drawing.Point(24, 245);
            this.lblObservation.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(100, 17);
            this.lblObservation.TabIndex = 24;
            this.lblObservation.Text = "Observação:";
            // 
            // gpbOptions
            // 
            this.gpbOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbOptions.Controls.Add(this.chbUnique);
            this.gpbOptions.Controls.Add(this.chbRecorrente);
            this.gpbOptions.Location = new System.Drawing.Point(617, 42);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(227, 75);
            this.gpbOptions.TabIndex = 26;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Tipo Recebimento";
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
            // 
            // chbUnique
            // 
            this.chbUnique.AutoSize = true;
            this.chbUnique.Location = new System.Drawing.Point(7, 43);
            this.chbUnique.Name = "chbUnique";
            this.chbUnique.Size = new System.Drawing.Size(54, 17);
            this.chbUnique.TabIndex = 28;
            this.chbUnique.Text = "Unico";
            this.chbUnique.UseVisualStyleBackColor = true;
            // 
            // btnSaveEarning
            // 
            this.btnSaveEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveEarning.Location = new System.Drawing.Point(367, 346);
            this.btnSaveEarning.Name = "btnSaveEarning";
            this.btnSaveEarning.Size = new System.Drawing.Size(187, 61);
            this.btnSaveEarning.TabIndex = 27;
            this.btnSaveEarning.Text = "Salvar";
            this.btnSaveEarning.UseVisualStyleBackColor = true;
            // 
            // lblErrorEarning
            // 
            this.lblErrorEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorEarning.AutoSize = true;
            this.lblErrorEarning.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEarning.Location = new System.Drawing.Point(29, 176);
            this.lblErrorEarning.Name = "lblErrorEarning";
            this.lblErrorEarning.Size = new System.Drawing.Size(29, 13);
            this.lblErrorEarning.TabIndex = 28;
            this.lblErrorEarning.Text = "Error";
            // 
            // lblErrorValue
            // 
            this.lblErrorValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorValue.AutoSize = true;
            this.lblErrorValue.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValue.Location = new System.Drawing.Point(300, 176);
            this.lblErrorValue.Name = "lblErrorValue";
            this.lblErrorValue.Size = new System.Drawing.Size(29, 13);
            this.lblErrorValue.TabIndex = 29;
            this.lblErrorValue.Text = "Error";
            // 
            // lblErrorDate
            // 
            this.lblErrorDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorDate.AutoSize = true;
            this.lblErrorDate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDate.Location = new System.Drawing.Point(616, 137);
            this.lblErrorDate.Name = "lblErrorDate";
            this.lblErrorDate.Size = new System.Drawing.Size(29, 13);
            this.lblErrorDate.TabIndex = 30;
            this.lblErrorDate.Text = "Error";
            // 
            // lblErrorTypeEarning
            // 
            this.lblErrorTypeEarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTypeEarning.AutoSize = true;
            this.lblErrorTypeEarning.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTypeEarning.Location = new System.Drawing.Point(620, 24);
            this.lblErrorTypeEarning.Name = "lblErrorTypeEarning";
            this.lblErrorTypeEarning.Size = new System.Drawing.Size(29, 13);
            this.lblErrorTypeEarning.TabIndex = 31;
            this.lblErrorTypeEarning.Text = "Error";
            // 
            // lblErrorCategories
            // 
            this.lblErrorCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCategories.AutoSize = true;
            this.lblErrorCategories.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategories.Location = new System.Drawing.Point(30, 37);
            this.lblErrorCategories.Name = "lblErrorCategories";
            this.lblErrorCategories.Size = new System.Drawing.Size(29, 13);
            this.lblErrorCategories.TabIndex = 32;
            this.lblErrorCategories.Text = "Error";
            // 
            // lblSubCategories
            // 
            this.lblSubCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubCategories.AutoSize = true;
            this.lblSubCategories.ForeColor = System.Drawing.Color.Red;
            this.lblSubCategories.Location = new System.Drawing.Point(299, 37);
            this.lblSubCategories.Name = "lblSubCategories";
            this.lblSubCategories.Size = new System.Drawing.Size(29, 13);
            this.lblSubCategories.TabIndex = 33;
            this.lblSubCategories.Text = "Error";
            // 
            // FormAddEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 419);
            this.ControlBox = false;
            this.Controls.Add(this.lblSubCategories);
            this.Controls.Add(this.lblErrorCategories);
            this.Controls.Add(this.lblErrorTypeEarning);
            this.Controls.Add(this.lblErrorDate);
            this.Controls.Add(this.lblErrorValue);
            this.Controls.Add(this.lblErrorEarning);
            this.Controls.Add(this.btnSaveEarning);
            this.Controls.Add(this.gpbOptions);
            this.Controls.Add(this.txbObservation);
            this.Controls.Add(this.lblObservation);
            this.Controls.Add(this.mdcDataEarning);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txbEarningName);
            this.Controls.Add(this.lblEarningName);
            this.Controls.Add(this.lstSubCategories);
            this.Controls.Add(this.lblListSubCategoriesName);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblListCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEarnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEarnings";
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label lblListCategoryName;
        private System.Windows.Forms.ListBox lstSubCategories;
        private System.Windows.Forms.Label lblListSubCategoriesName;
        private System.Windows.Forms.TextBox txbEarningName;
        private System.Windows.Forms.Label lblEarningName;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.MonthCalendar mdcDataEarning;
        private System.Windows.Forms.TextBox txbObservation;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.CheckBox chbUnique;
        private System.Windows.Forms.CheckBox chbRecorrente;
        private System.Windows.Forms.Button btnSaveEarning;
        private System.Windows.Forms.Label lblErrorEarning;
        private System.Windows.Forms.Label lblErrorValue;
        private System.Windows.Forms.Label lblErrorDate;
        private System.Windows.Forms.Label lblErrorTypeEarning;
        private System.Windows.Forms.Label lblErrorCategories;
        private System.Windows.Forms.Label lblSubCategories;
    }
}