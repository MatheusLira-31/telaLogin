namespace TelaLogin
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.lblOperacao = new System.Windows.Forms.Label();
            this.BtnAdicao = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSubtracao = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVirgula = new Guna.UI2.WinForms.Guna2Button();
            this.BtnIgual = new Guna.UI2.WinForms.Guna2Button();
            this.Btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn0 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMultiplicacao = new Guna.UI2.WinForms.Guna2Button();
            this.Btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDivisao = new Guna.UI2.WinForms.Guna2Button();
            this.Btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.TxtResultado = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.PicBtnVoltar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBtnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(30, 73);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 16);
            this.lblOperacao.TabIndex = 31;
            // 
            // BtnAdicao
            // 
            this.BtnAdicao.CheckedState.Parent = this.BtnAdicao;
            this.BtnAdicao.CustomImages.Parent = this.BtnAdicao;
            this.BtnAdicao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdicao.ForeColor = System.Drawing.Color.White;
            this.BtnAdicao.HoverState.Parent = this.BtnAdicao;
            this.BtnAdicao.Location = new System.Drawing.Point(256, 395);
            this.BtnAdicao.Name = "BtnAdicao";
            this.BtnAdicao.ShadowDecoration.Parent = this.BtnAdicao;
            this.BtnAdicao.Size = new System.Drawing.Size(70, 70);
            this.BtnAdicao.TabIndex = 30;
            this.BtnAdicao.Text = "+";
            this.BtnAdicao.Click += new System.EventHandler(this.BtnAdicao_Click);
            // 
            // BtnSubtracao
            // 
            this.BtnSubtracao.CheckedState.Parent = this.BtnSubtracao;
            this.BtnSubtracao.CustomImages.Parent = this.BtnSubtracao;
            this.BtnSubtracao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSubtracao.ForeColor = System.Drawing.Color.White;
            this.BtnSubtracao.HoverState.Parent = this.BtnSubtracao;
            this.BtnSubtracao.Location = new System.Drawing.Point(256, 319);
            this.BtnSubtracao.Name = "BtnSubtracao";
            this.BtnSubtracao.ShadowDecoration.Parent = this.BtnSubtracao;
            this.BtnSubtracao.Size = new System.Drawing.Size(70, 70);
            this.BtnSubtracao.TabIndex = 29;
            this.BtnSubtracao.Text = "-";
            this.BtnSubtracao.Click += new System.EventHandler(this.BtnSubtracao_Click);
            // 
            // BtnVirgula
            // 
            this.BtnVirgula.CheckedState.Parent = this.BtnVirgula;
            this.BtnVirgula.CustomImages.Parent = this.BtnVirgula;
            this.BtnVirgula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnVirgula.ForeColor = System.Drawing.Color.White;
            this.BtnVirgula.HoverState.Parent = this.BtnVirgula;
            this.BtnVirgula.Location = new System.Drawing.Point(27, 395);
            this.BtnVirgula.Name = "BtnVirgula";
            this.BtnVirgula.ShadowDecoration.Parent = this.BtnVirgula;
            this.BtnVirgula.Size = new System.Drawing.Size(70, 70);
            this.BtnVirgula.TabIndex = 28;
            this.BtnVirgula.Text = ",";
            this.BtnVirgula.Click += new System.EventHandler(this.BtnVirgula_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.CheckedState.Parent = this.BtnIgual;
            this.BtnIgual.CustomImages.Parent = this.BtnIgual;
            this.BtnIgual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnIgual.ForeColor = System.Drawing.Color.White;
            this.BtnIgual.HoverState.Parent = this.BtnIgual;
            this.BtnIgual.Location = new System.Drawing.Point(180, 395);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.ShadowDecoration.Parent = this.BtnIgual;
            this.BtnIgual.Size = new System.Drawing.Size(70, 70);
            this.BtnIgual.TabIndex = 27;
            this.BtnIgual.Text = "=";
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // Btn1
            // 
            this.Btn1.CheckedState.Parent = this.Btn1;
            this.Btn1.CustomImages.Parent = this.Btn1;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.HoverState.Parent = this.Btn1;
            this.Btn1.Location = new System.Drawing.Point(27, 319);
            this.Btn1.Name = "Btn1";
            this.Btn1.ShadowDecoration.Parent = this.Btn1;
            this.Btn1.Size = new System.Drawing.Size(70, 70);
            this.Btn1.TabIndex = 26;
            this.Btn1.Text = "1";
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn3
            // 
            this.Btn3.CheckedState.Parent = this.Btn3;
            this.Btn3.CustomImages.Parent = this.Btn3;
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn3.ForeColor = System.Drawing.Color.White;
            this.Btn3.HoverState.Parent = this.Btn3;
            this.Btn3.Location = new System.Drawing.Point(180, 319);
            this.Btn3.Name = "Btn3";
            this.Btn3.ShadowDecoration.Parent = this.Btn3;
            this.Btn3.Size = new System.Drawing.Size(70, 70);
            this.Btn3.TabIndex = 25;
            this.Btn3.Text = "3";
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn0
            // 
            this.Btn0.CheckedState.Parent = this.Btn0;
            this.Btn0.CustomImages.Parent = this.Btn0;
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn0.ForeColor = System.Drawing.Color.White;
            this.Btn0.HoverState.Parent = this.Btn0;
            this.Btn0.Location = new System.Drawing.Point(104, 395);
            this.Btn0.Name = "Btn0";
            this.Btn0.ShadowDecoration.Parent = this.Btn0;
            this.Btn0.Size = new System.Drawing.Size(70, 70);
            this.Btn0.TabIndex = 24;
            this.Btn0.Text = "0";
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn2
            // 
            this.Btn2.CheckedState.Parent = this.Btn2;
            this.Btn2.CustomImages.Parent = this.Btn2;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.HoverState.Parent = this.Btn2;
            this.Btn2.Location = new System.Drawing.Point(104, 319);
            this.Btn2.Name = "Btn2";
            this.Btn2.ShadowDecoration.Parent = this.Btn2;
            this.Btn2.Size = new System.Drawing.Size(70, 70);
            this.Btn2.TabIndex = 23;
            this.Btn2.Text = "2";
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.CheckedState.Parent = this.BtnClear;
            this.BtnClear.CustomImages.Parent = this.BtnClear;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.HoverState.Parent = this.BtnClear;
            this.BtnClear.Location = new System.Drawing.Point(256, 124);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.ShadowDecoration.Parent = this.BtnClear;
            this.BtnClear.Size = new System.Drawing.Size(70, 37);
            this.BtnClear.TabIndex = 22;
            this.BtnClear.Text = "C";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.CheckedState.Parent = this.BtnMultiplicacao;
            this.BtnMultiplicacao.CustomImages.Parent = this.BtnMultiplicacao;
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.BtnMultiplicacao.HoverState.Parent = this.BtnMultiplicacao;
            this.BtnMultiplicacao.Location = new System.Drawing.Point(256, 243);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.ShadowDecoration.Parent = this.BtnMultiplicacao;
            this.BtnMultiplicacao.Size = new System.Drawing.Size(70, 70);
            this.BtnMultiplicacao.TabIndex = 21;
            this.BtnMultiplicacao.Text = "x";
            this.BtnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // Btn9
            // 
            this.Btn9.CheckedState.Parent = this.Btn9;
            this.Btn9.CustomImages.Parent = this.Btn9;
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn9.ForeColor = System.Drawing.Color.White;
            this.Btn9.HoverState.Parent = this.Btn9;
            this.Btn9.Location = new System.Drawing.Point(180, 167);
            this.Btn9.Name = "Btn9";
            this.Btn9.ShadowDecoration.Parent = this.Btn9;
            this.Btn9.Size = new System.Drawing.Size(70, 70);
            this.Btn9.TabIndex = 20;
            this.Btn9.Text = "9";
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn4
            // 
            this.Btn4.CheckedState.Parent = this.Btn4;
            this.Btn4.CustomImages.Parent = this.Btn4;
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn4.ForeColor = System.Drawing.Color.White;
            this.Btn4.HoverState.Parent = this.Btn4;
            this.Btn4.Location = new System.Drawing.Point(27, 243);
            this.Btn4.Name = "Btn4";
            this.Btn4.ShadowDecoration.Parent = this.Btn4;
            this.Btn4.Size = new System.Drawing.Size(70, 70);
            this.Btn4.TabIndex = 18;
            this.Btn4.Text = "4";
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.CheckedState.Parent = this.Btn5;
            this.Btn5.CustomImages.Parent = this.Btn5;
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn5.ForeColor = System.Drawing.Color.White;
            this.Btn5.HoverState.Parent = this.Btn5;
            this.Btn5.Location = new System.Drawing.Point(104, 243);
            this.Btn5.Name = "Btn5";
            this.Btn5.ShadowDecoration.Parent = this.Btn5;
            this.Btn5.Size = new System.Drawing.Size(70, 70);
            this.Btn5.TabIndex = 17;
            this.Btn5.Text = "5";
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn8
            // 
            this.Btn8.CheckedState.Parent = this.Btn8;
            this.Btn8.CustomImages.Parent = this.Btn8;
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn8.ForeColor = System.Drawing.Color.White;
            this.Btn8.HoverState.Parent = this.Btn8;
            this.Btn8.Location = new System.Drawing.Point(104, 167);
            this.Btn8.Name = "Btn8";
            this.Btn8.ShadowDecoration.Parent = this.Btn8;
            this.Btn8.Size = new System.Drawing.Size(70, 70);
            this.Btn8.TabIndex = 16;
            this.Btn8.Text = "8";
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // BtnDivisao
            // 
            this.BtnDivisao.CheckedState.Parent = this.BtnDivisao;
            this.BtnDivisao.CustomImages.Parent = this.BtnDivisao;
            this.BtnDivisao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDivisao.ForeColor = System.Drawing.Color.White;
            this.BtnDivisao.HoverState.Parent = this.BtnDivisao;
            this.BtnDivisao.Location = new System.Drawing.Point(256, 167);
            this.BtnDivisao.Name = "BtnDivisao";
            this.BtnDivisao.ShadowDecoration.Parent = this.BtnDivisao;
            this.BtnDivisao.Size = new System.Drawing.Size(70, 70);
            this.BtnDivisao.TabIndex = 15;
            this.BtnDivisao.Text = "/";
            this.BtnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // Btn7
            // 
            this.Btn7.CheckedState.Parent = this.Btn7;
            this.Btn7.CustomImages.Parent = this.Btn7;
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn7.ForeColor = System.Drawing.Color.White;
            this.Btn7.HoverState.Parent = this.Btn7;
            this.Btn7.Location = new System.Drawing.Point(27, 167);
            this.Btn7.Name = "Btn7";
            this.Btn7.ShadowDecoration.Parent = this.Btn7;
            this.Btn7.Size = new System.Drawing.Size(70, 70);
            this.Btn7.TabIndex = 14;
            this.Btn7.Text = "7";
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtResultado.DefaultText = "";
            this.TxtResultado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtResultado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtResultado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtResultado.DisabledState.Parent = this.TxtResultado;
            this.TxtResultado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtResultado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtResultado.FocusedState.Parent = this.TxtResultado;
            this.TxtResultado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtResultado.HoverState.Parent = this.TxtResultado;
            this.TxtResultado.Location = new System.Drawing.Point(27, 71);
            this.TxtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.PasswordChar = '\0';
            this.TxtResultado.PlaceholderText = "";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.SelectedText = "";
            this.TxtResultado.ShadowDecoration.Parent = this.TxtResultado;
            this.TxtResultado.Size = new System.Drawing.Size(299, 47);
            this.TxtResultado.TabIndex = 13;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn6
            // 
            this.Btn6.CheckedState.Parent = this.Btn6;
            this.Btn6.CustomImages.Parent = this.Btn6;
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn6.ForeColor = System.Drawing.Color.White;
            this.Btn6.HoverState.Parent = this.Btn6;
            this.Btn6.Location = new System.Drawing.Point(180, 243);
            this.Btn6.Name = "Btn6";
            this.Btn6.ShadowDecoration.Parent = this.Btn6;
            this.Btn6.Size = new System.Drawing.Size(70, 70);
            this.Btn6.TabIndex = 32;
            this.Btn6.Text = "6";
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // PicBtnVoltar
            // 
            this.PicBtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("PicBtnVoltar.Image")));
            this.PicBtnVoltar.Location = new System.Drawing.Point(12, 12);
            this.PicBtnVoltar.Name = "PicBtnVoltar";
            this.PicBtnVoltar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicBtnVoltar.ShadowDecoration.Parent = this.PicBtnVoltar;
            this.PicBtnVoltar.Size = new System.Drawing.Size(28, 28);
            this.PicBtnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBtnVoltar.TabIndex = 33;
            this.PicBtnVoltar.TabStop = false;
            this.PicBtnVoltar.Click += new System.EventHandler(this.PicBtnVoltar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 480);
            this.Controls.Add(this.PicBtnVoltar);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.BtnAdicao);
            this.Controls.Add(this.BtnSubtracao);
            this.Controls.Add(this.BtnVirgula);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.BtnDivisao);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.TxtResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBtnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacao;
        private Guna.UI2.WinForms.Guna2Button BtnAdicao;
        private Guna.UI2.WinForms.Guna2Button BtnSubtracao;
        private Guna.UI2.WinForms.Guna2Button BtnVirgula;
        private Guna.UI2.WinForms.Guna2Button BtnIgual;
        private Guna.UI2.WinForms.Guna2Button Btn1;
        private Guna.UI2.WinForms.Guna2Button Btn3;
        private Guna.UI2.WinForms.Guna2Button Btn0;
        private Guna.UI2.WinForms.Guna2Button Btn2;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
        private Guna.UI2.WinForms.Guna2Button BtnMultiplicacao;
        private Guna.UI2.WinForms.Guna2Button Btn9;
        private Guna.UI2.WinForms.Guna2Button Btn4;
        private Guna.UI2.WinForms.Guna2Button Btn5;
        private Guna.UI2.WinForms.Guna2Button Btn8;
        private Guna.UI2.WinForms.Guna2Button BtnDivisao;
        private Guna.UI2.WinForms.Guna2Button Btn7;
        private Guna.UI2.WinForms.Guna2TextBox TxtResultado;
        private Guna.UI2.WinForms.Guna2Button Btn6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PicBtnVoltar;
    }
}