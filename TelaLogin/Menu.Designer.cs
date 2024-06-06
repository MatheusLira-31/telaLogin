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
            this.BtnCal = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalMed = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BtnCal
            // 
            this.BtnCal.BorderRadius = 20;
            this.BtnCal.CheckedState.Parent = this.BtnCal;
            this.BtnCal.CustomImages.Parent = this.BtnCal;
            resources.ApplyResources(this.BtnCal, "BtnCal");
            this.BtnCal.ForeColor = System.Drawing.Color.White;
            this.BtnCal.HoverState.Parent = this.BtnCal;
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.ShadowDecoration.Parent = this.BtnCal;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnCalMed
            // 
            this.BtnCalMed.BorderRadius = 20;
            this.BtnCalMed.CheckedState.Parent = this.BtnCalMed;
            this.BtnCalMed.CustomImages.Parent = this.BtnCalMed;
            resources.ApplyResources(this.BtnCalMed, "BtnCalMed");
            this.BtnCalMed.ForeColor = System.Drawing.Color.White;
            this.BtnCalMed.HoverState.Parent = this.BtnCalMed;
            this.BtnCalMed.Name = "BtnCalMed";
            this.BtnCalMed.ShadowDecoration.Parent = this.BtnCalMed;
            this.BtnCalMed.Click += new System.EventHandler(this.BtnCalMed_Click);
            // 
            // Menu
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.BtnCalMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnCal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnCalMed;
    }
}