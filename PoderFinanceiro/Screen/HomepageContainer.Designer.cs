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
            this.mniHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddEarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSubCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mniView = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.smiViewExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.smiViewEarning = new System.Windows.Forms.ToolStripMenuItem();
            this.smiViewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.smiViewSubcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.smiReportMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.smiReportYear = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDeGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiReportCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tendênciasGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHome,
            this.mniAdd,
            this.mniView,
            this.mniReport,
            this.mniDashboard});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Size = new System.Drawing.Size(885, 24);
            this.mnsMainMenu.TabIndex = 2;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // mniHome
            // 
            this.mniHome.Image = global::PoderFinanceiro.Properties.Resources.home;
            this.mniHome.Name = "mniHome";
            this.mniHome.Size = new System.Drawing.Size(28, 20);
            this.mniHome.Click += new System.EventHandler(this.MniHome_Click);
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
            // mniView
            // 
            this.mniView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiViewExpense,
            this.smiViewEarning,
            this.smiViewCategory,
            this.smiViewSubcategory});
            this.mniView.Name = "mniView";
            this.mniView.Size = new System.Drawing.Size(68, 20);
            this.mniView.Text = "Visualizar";
            // 
            // mniReport
            // 
            this.mniReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiReportMonth,
            this.smiReportYear,
            this.smiReportCustom});
            this.mniReport.Name = "mniReport";
            this.mniReport.Size = new System.Drawing.Size(71, 20);
            this.mniReport.Text = "Relatórios";
            // 
            // mniDashboard
            // 
            this.mniDashboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoDeGastosToolStripMenuItem,
            this.balançoGeralToolStripMenuItem,
            this.tendênciasGeraisToolStripMenuItem});
            this.mniDashboard.Name = "mniDashboard";
            this.mniDashboard.Size = new System.Drawing.Size(76, 20);
            this.mniDashboard.Text = "Dashboard";
            // 
            // smiViewExpense
            // 
            this.smiViewExpense.Name = "smiViewExpense";
            this.smiViewExpense.Size = new System.Drawing.Size(180, 22);
            this.smiViewExpense.Text = "Despesas";
            // 
            // smiViewEarning
            // 
            this.smiViewEarning.Name = "smiViewEarning";
            this.smiViewEarning.Size = new System.Drawing.Size(180, 22);
            this.smiViewEarning.Text = "Ganhos";
            // 
            // smiViewCategory
            // 
            this.smiViewCategory.Name = "smiViewCategory";
            this.smiViewCategory.Size = new System.Drawing.Size(180, 22);
            this.smiViewCategory.Text = "Categorias";
            // 
            // smiViewSubcategory
            // 
            this.smiViewSubcategory.Name = "smiViewSubcategory";
            this.smiViewSubcategory.Size = new System.Drawing.Size(180, 22);
            this.smiViewSubcategory.Text = "Subcategorias";
            // 
            // smiReportMonth
            // 
            this.smiReportMonth.Name = "smiReportMonth";
            this.smiReportMonth.Size = new System.Drawing.Size(180, 22);
            this.smiReportMonth.Text = "Mensal";
            // 
            // smiReportYear
            // 
            this.smiReportYear.Name = "smiReportYear";
            this.smiReportYear.Size = new System.Drawing.Size(180, 22);
            this.smiReportYear.Text = "Anual";
            // 
            // gráficoDeGastosToolStripMenuItem
            // 
            this.gráficoDeGastosToolStripMenuItem.Name = "gráficoDeGastosToolStripMenuItem";
            this.gráficoDeGastosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gráficoDeGastosToolStripMenuItem.Text = "Gráfico de gastos";
            // 
            // smiReportCustom
            // 
            this.smiReportCustom.Name = "smiReportCustom";
            this.smiReportCustom.Size = new System.Drawing.Size(180, 22);
            this.smiReportCustom.Text = "Personalizado";
            // 
            // balançoGeralToolStripMenuItem
            // 
            this.balançoGeralToolStripMenuItem.Name = "balançoGeralToolStripMenuItem";
            this.balançoGeralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.balançoGeralToolStripMenuItem.Text = "Balanço geral";
            // 
            // tendênciasGeraisToolStripMenuItem
            // 
            this.tendênciasGeraisToolStripMenuItem.Name = "tendênciasGeraisToolStripMenuItem";
            this.tendênciasGeraisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tendênciasGeraisToolStripMenuItem.Text = "Tendências Gerais";
            // 
            // HomepageContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 520);
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
        private System.Windows.Forms.ToolStripMenuItem mniHome;
        private System.Windows.Forms.ToolStripMenuItem smiViewExpense;
        private System.Windows.Forms.ToolStripMenuItem smiViewEarning;
        private System.Windows.Forms.ToolStripMenuItem smiViewCategory;
        private System.Windows.Forms.ToolStripMenuItem smiViewSubcategory;
        private System.Windows.Forms.ToolStripMenuItem smiReportMonth;
        private System.Windows.Forms.ToolStripMenuItem smiReportYear;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiReportCustom;
        private System.Windows.Forms.ToolStripMenuItem balançoGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tendênciasGeraisToolStripMenuItem;
    }
}