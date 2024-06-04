using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUser.Text.Equals("admin") && TxtSenha.Text.Equals("1234"))
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", 
                        "Desculpe", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    TxtUser.Focus();
                    TxtSenha.Text = "";
                }
                } catch (Exception ex)
                {
                    MessageBox.Show("Desculpe",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
