namespace PoderFinanceiro.Screens
{
    partial class HomepageContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageContainer));
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.mniAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddEarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSubCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mniView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAdd,
            this.mniView,
            this.mniReport,
            this.mniDashboard});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsMainMenu.TabIndex = 2;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // mniAdd
            // 
            this.mniAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddExpense,
            this.smiAddEarnings,
            this.smiCategory,
            this.smiSubCategory});
            this.mniAdd.Image = global::PoderFinanceiro.Properties.Resources.add;
            this.mniAdd.Name = "mniAdd";
            this.mniAdd.Size = new System.Drawing.Size(86, 20);
            this.mniAdd.Text = "Adicionar";
            // 
            // smiAddExpense
            // 
            this.smiAddExpense.Image = global::PoderFinanceiro.Properties.Resources.wallet_minus;
            this.smiAddExpense.Name = "smiAddExpense";
            this.smiAddExpense.Size = new System.Drawing.Size(180, 22);
            this.smiAddExpense.Text = "Despesas";
            this.smiAddExpense.Click += new System.EventHandler(this.SmiAddExpense_Click);
            // 
            // smiAddEarnings
            // 
            this.smiAddEarnings.Image = global::PoderFinanceiro.Properties.Resources.wallet_add;
            this.smiAddEarnings.Name = "smiAddEarnings";
            this.smiAddEarnings.Size = new System.Drawing.Size(180, 22);
            this.smiAddEarnings.Text = "Ganhos";
            this.smiAddEarnings.Click += new System.EventHandler(this.SmiAddEarnings_Click);
            // 
            // smiCategory
            // 
            this.smiCategory.Image = global::PoderFinanceiro.Properties.Resources.categories;
            this.smiCategory.Name = "smiCategory";
            this.smiCategory.Size = new System.Drawing.Size(180, 22);
            this.smiCategory.Text = "Categorias";
            this.smiCategory.Click += new System.EventHandler(this.SmiCategory_Click);
            // 
            // smiSubCategory
            // 
            this.smiSubCategory.Image = global::PoderFinanceiro.Properties.Resources.sub;
            this.smiSubCategory.Name = "smiSubCategory";
            this.smiSubCategory.Size = new System.Drawing.Size(180, 22);
            this.smiSubCategory.Text = "Subcategorias";
            this.smiSubCategory.Click += new System.EventHandler(this.SmiSubCategory_Click);
            // 
            // mniReport
            // 
            this.mniReport.Name = "mniReport";
            this.mniReport.Size = new System.Drawing.Size(71, 20);
            this.mniReport.Text = "Relatórios";
            // 
            // mniDashboard
            // 
            this.mniDashboard.Name = "mniDashboard";
            this.mniDashboard.Size = new System.Drawing.Size(76, 20);
            this.mniDashboard.Text = "Dashboard";
            // 
            // mniView
            // 
            this.mniView.Name = "mniView";
            this.mniView.Size = new System.Drawing.Size(68, 20);
            this.mniView.Text = "Visualizar";
            // 
            // HomepageContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMainMenu;
            this.Name = "HomepageContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poder Financeiro";
            this.Load += new System.EventHandler(this.HomepageContainer_Load);
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mniAdd;
        private System.Windows.Forms.ToolStripMenuItem mniReport;
        private System.Windows.Forms.ToolStripMenuItem mniDashboard;
        private System.Windows.Forms.ToolStripMenuItem smiAddExpense;
        private System.Windows.Forms.ToolStripMenuItem smiAddEarnings;
        private System.Windows.Forms.ToolStripMenuItem smiCategory;
        private System.Windows.Forms.ToolStripMenuItem smiSubCategory;
        private System.Windows.Forms.ToolStripMenuItem mniView;
    }
}