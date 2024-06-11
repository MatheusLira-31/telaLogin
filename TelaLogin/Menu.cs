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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void calculadora_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();

        }

        private void calculadoraDeMédia_Click(object sender, EventArgs e)
        {
            CalculadoraMed calculadoraMed = new CalculadoraMed();
            calculadoraMed.Show();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void calculadorasMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
