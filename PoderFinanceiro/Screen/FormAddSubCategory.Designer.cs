namespace PoderFinanceiro.Screen
{
    partial class FormAddSubCategory
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
            this.lblErrorSubCategoryName = new System.Windows.Forms.Label();
            this.txbSubCategoryName = new System.Windows.Forms.TextBox();
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.lblListCategoryName = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnRegisterSubCategory = new System.Windows.Forms.Button();
            this.lblSubCategoryIcon = new System.Windows.Forms.Label();
            this.lstViewIcon = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblErrorSubCategoryName
            // 
            this.lblErrorSubCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorSubCategoryName.AutoSize = true;
            this.lblErrorSubCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.lblErrorSubCategoryName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSubCategoryName.Location = new System.Drawing.Point(331, 77);
            this.lblErrorSubCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblErrorSubCategoryName.Name = "lblErrorSubCategoryName";
            this.lblErrorSubCategoryName.Size = new System.Drawing.Size(29, 13);
            this.lblErrorSubCategoryName.TabIndex = 11;
            this.lblErrorSubCategoryName.Text = "Error";
            this.lblErrorSubCategoryName.Visible = false;
            // 
            // txbSubCategoryName
            // 
            this.txbSubCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSubCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbSubCategoryName.Location = new System.Drawing.Point(318, 97);
            this.txbSubCategoryName.Name = "txbSubCategoryName";
            this.txbSubCategoryName.Size = new System.Drawing.Size(217, 30);
            this.txbSubCategoryName.TabIndex = 8;
            this.txbSubCategoryName.Leave += new System.EventHandler(this.TxbSubCategoryName_Leave);
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubCategoryName.AutoSize = true;
            this.lblSubCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoryName.Location = new System.Drawing.Point(315, 55);
            this.lblSubCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(185, 17);
            this.lblSubCategoryName.TabIndex = 7;
            this.lblSubCategoryName.Text = "Nome da Sub Categoria:";
            // 
            // lblListCategoryName
            // 
            this.lblListCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListCategoryName.AutoSize = true;
            this.lblListCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCategoryName.Location = new System.Drawing.Point(43, 26);
            this.lblListCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblListCategoryName.Name = "lblListCategoryName";
            this.lblListCategoryName.Size = new System.Drawing.Size(91, 17);
            this.lblListCategoryName.TabIndex = 12;
            this.lblListCategoryName.Text = "Categorias:";
            // 
            // lstCategories
            // 
            this.lstCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(44, 58);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(217, 69);
            this.lstCategories.TabIndex = 13;
            // 
            // btnRegisterSubCategory
            // 
            this.btnRegisterSubCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterSubCategory.Location = new System.Drawing.Point(327, 241);
            this.btnRegisterSubCategory.Name = "btnRegisterSubCategory";
            this.btnRegisterSubCategory.Size = new System.Drawing.Size(181, 48);
            this.btnRegisterSubCategory.TabIndex = 14;
            this.btnRegisterSubCategory.Text = "Salvar Categoria";
            this.btnRegisterSubCategory.UseVisualStyleBackColor = true;
            this.btnRegisterSubCategory.Click += new System.EventHandler(this.BtnRegisterSubCategory_Click);
            // 
            // lblSubCategoryIcon
            // 
            this.lblSubCategoryIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubCategoryIcon.AutoSize = true;
            this.lblSubCategoryIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoryIcon.Location = new System.Drawing.Point(41, 150);
            this.lblSubCategoryIcon.Name = "lblSubCategoryIcon";
            this.lblSubCategoryIcon.Size = new System.Drawing.Size(178, 17);
            this.lblSubCategoryIcon.TabIndex = 9;
            this.lblSubCategoryIcon.Text = "Icone da Sub Categoria";
            // 
            // lstViewIcon
            // 
            this.lstViewIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstViewIcon.HideSelection = false;
            this.lstViewIcon.Location = new System.Drawing.Point(44, 183);
            this.lstViewIcon.Name = "lstViewIcon";
            this.lstViewIcon.Size = new System.Drawing.Size(217, 135);
            this.lstViewIcon.TabIndex = 10;
            this.lstViewIcon.UseCompatibleStateImageBehavior = false;
            // 
            // FormAddSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 359);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegisterSubCategory);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblListCategoryName);
            this.Controls.Add(this.lblErrorSubCategoryName);
            this.Controls.Add(this.lstViewIcon);
            this.Controls.Add(this.lblSubCategoryIcon);
            this.Controls.Add(this.txbSubCategoryName);
            this.Controls.Add(this.lblSubCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddSubCategory";
            this.Text = "FormAddSubCategory";
            this.Load += new System.EventHandler(this.FormAddSubCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorSubCategoryName;
        private System.Windows.Forms.TextBox txbSubCategoryName;
        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.Label lblListCategoryName;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnRegisterSubCategory;
        private System.Windows.Forms.Label lblSubCategoryIcon;
        private System.Windows.Forms.ListView lstViewIcon;
    }
}