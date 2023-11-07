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
            this.lblErrorCategoryName = new System.Windows.Forms.Label();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.lblListCategoryName = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnRegisterCategory = new System.Windows.Forms.Button();
            this.lblSubCategoryIcon = new System.Windows.Forms.Label();
            this.lstViewIcon = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblErrorCategoryName
            // 
            this.lblErrorCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCategoryName.AutoSize = true;
            this.lblErrorCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.lblErrorCategoryName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategoryName.Location = new System.Drawing.Point(331, 77);
            this.lblErrorCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblErrorCategoryName.Name = "lblErrorCategoryName";
            this.lblErrorCategoryName.Size = new System.Drawing.Size(29, 13);
            this.lblErrorCategoryName.TabIndex = 11;
            this.lblErrorCategoryName.Text = "Error";
            this.lblErrorCategoryName.Visible = false;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbCategoryName.Location = new System.Drawing.Point(318, 97);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(217, 30);
            this.txbCategoryName.TabIndex = 8;
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
            // btnRegisterCategory
            // 
            this.btnRegisterCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterCategory.Location = new System.Drawing.Point(327, 241);
            this.btnRegisterCategory.Name = "btnRegisterCategory";
            this.btnRegisterCategory.Size = new System.Drawing.Size(181, 48);
            this.btnRegisterCategory.TabIndex = 14;
            this.btnRegisterCategory.Text = "Salvar Categoria";
            this.btnRegisterCategory.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnRegisterCategory);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblListCategoryName);
            this.Controls.Add(this.lblErrorCategoryName);
            this.Controls.Add(this.lstViewIcon);
            this.Controls.Add(this.lblSubCategoryIcon);
            this.Controls.Add(this.txbCategoryName);
            this.Controls.Add(this.lblSubCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddSubCategory";
            this.Text = "FormAddSubCategory";
            this.Load += new System.EventHandler(this.FormAddSubCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorCategoryName;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.Label lblListCategoryName;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnRegisterCategory;
        private System.Windows.Forms.Label lblSubCategoryIcon;
        private System.Windows.Forms.ListView lstViewIcon;
    }
}