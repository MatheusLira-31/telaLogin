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
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();
            this.Hide();
        }

        private void BtnCalMed_Click(object sender, EventArgs e)
        {
            CalculadoraMed calculadoraMed = new CalculadoraMed();
            calculadoraMed.Show();
            this.Hide();
        }
    }
}
