using System;

namespace TelaLogin
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadorasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraDeMédia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasMenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // calculadorasMenu
            // 
            this.calculadorasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadora,
            this.calculadoraDeMédia});
            this.calculadorasMenu.Name = "calculadorasMenu";
            resources.ApplyResources(this.calculadorasMenu, "calculadorasMenu");
            this.calculadorasMenu.Click += new System.EventHandler(this.calculadorasMenu_Click);
            // 
            // calculadora
            // 
            resources.ApplyResources(this.calculadora, "calculadora");
            this.calculadora.Name = "calculadora";
            this.calculadora.Click += new System.EventHandler(this.calculadora_Click);
            // 
            // calculadoraDeMédia
            // 
            resources.ApplyResources(this.calculadoraDeMédia, "calculadoraDeMédia");
            this.calculadoraDeMédia.Name = "calculadoraDeMédia";
            this.calculadoraDeMédia.Click += new System.EventHandler(this.calculadoraDeMédia_Click);
            // 
            // Menu
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadorasMenu;
        private System.Windows.Forms.ToolStripMenuItem calculadora;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeMédia;
    }
}