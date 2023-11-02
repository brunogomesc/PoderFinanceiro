namespace PoderFinanceiro.Screens
{
    partial class FormAddCategory
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryIcon = new System.Windows.Forms.Label();
            this.lstViewIcon = new System.Windows.Forms.ListView();
            this.btnRegisterCategory = new System.Windows.Forms.Button();
            this.lblErrorCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(29, 30);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(152, 17);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Nome da Categoria:";
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbCategoryName.Location = new System.Drawing.Point(32, 72);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(217, 30);
            this.txbCategoryName.TabIndex = 1;
            this.txbCategoryName.Leave += new System.EventHandler(this.TxbCategoryName_Leave);
            // 
            // lblCategoryIcon
            // 
            this.lblCategoryIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryIcon.AutoSize = true;
            this.lblCategoryIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryIcon.Location = new System.Drawing.Point(29, 151);
            this.lblCategoryIcon.Name = "lblCategoryIcon";
            this.lblCategoryIcon.Size = new System.Drawing.Size(145, 17);
            this.lblCategoryIcon.TabIndex = 2;
            this.lblCategoryIcon.Text = "Icone da Categoria";
            // 
            // lstViewIcon
            // 
            this.lstViewIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstViewIcon.HideSelection = false;
            this.lstViewIcon.Location = new System.Drawing.Point(32, 184);
            this.lstViewIcon.Name = "lstViewIcon";
            this.lstViewIcon.Size = new System.Drawing.Size(217, 135);
            this.lstViewIcon.TabIndex = 3;
            this.lstViewIcon.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegisterCategory
            // 
            this.btnRegisterCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterCategory.Location = new System.Drawing.Point(320, 271);
            this.btnRegisterCategory.Name = "btnRegisterCategory";
            this.btnRegisterCategory.Size = new System.Drawing.Size(181, 48);
            this.btnRegisterCategory.TabIndex = 5;
            this.btnRegisterCategory.Text = "Salvar Categoria";
            this.btnRegisterCategory.UseVisualStyleBackColor = true;
            this.btnRegisterCategory.Click += new System.EventHandler(this.BtnRegisterCategory_Click);
            // 
            // lblErrorCategoryName
            // 
            this.lblErrorCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCategoryName.AutoSize = true;
            this.lblErrorCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.lblErrorCategoryName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategoryName.Location = new System.Drawing.Point(45, 52);
            this.lblErrorCategoryName.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblErrorCategoryName.Name = "lblErrorCategoryName";
            this.lblErrorCategoryName.Size = new System.Drawing.Size(29, 13);
            this.lblErrorCategoryName.TabIndex = 6;
            this.lblErrorCategoryName.Text = "Error";
            this.lblErrorCategoryName.Visible = false;
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 357);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorCategoryName);
            this.Controls.Add(this.btnRegisterCategory);
            this.Controls.Add(this.lstViewIcon);
            this.Controls.Add(this.lblCategoryIcon);
            this.Controls.Add(this.txbCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCategory";
            this.Text = "FormAddCategory";
            this.Load += new System.EventHandler(this.FormAddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label lblCategoryIcon;
        private System.Windows.Forms.ListView lstViewIcon;
        private System.Windows.Forms.Button btnRegisterCategory;
        private System.Windows.Forms.Label lblErrorCategoryName;
    }
}