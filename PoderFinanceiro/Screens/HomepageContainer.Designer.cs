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
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.adicionarDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarGanhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarDespesasToolStripMenuItem,
            this.adicionarGanhosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsMainMenu.TabIndex = 2;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // adicionarDespesasToolStripMenuItem
            // 
            this.adicionarDespesasToolStripMenuItem.Name = "adicionarDespesasToolStripMenuItem";
            this.adicionarDespesasToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.adicionarDespesasToolStripMenuItem.Text = "Adicionar Despesas";
            this.adicionarDespesasToolStripMenuItem.Click += new System.EventHandler(this.AdicionarDespesasToolStripMenuItem_Click);
            // 
            // adicionarGanhosToolStripMenuItem
            // 
            this.adicionarGanhosToolStripMenuItem.Name = "adicionarGanhosToolStripMenuItem";
            this.adicionarGanhosToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.adicionarGanhosToolStripMenuItem.Text = "Adicionar Ganhos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMainMenu;
            this.Name = "Homepage";
            this.Text = "Poder Financeiro";
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem adicionarDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarGanhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}