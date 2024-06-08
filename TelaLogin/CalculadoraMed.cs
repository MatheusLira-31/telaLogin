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
    public partial class CalculadoraMed : Form
    {

        public CalculadoraMed()
        {
            InitializeComponent();
        }

        private void CalculadoraMed_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            
            double num1 = Convert.ToDouble(TxtNumUm.Text), num2 = Convert.ToDouble(TxtNumDois.Text), 
                num3 = Convert.ToDouble(TxtNumTres.Text);
            double soma = num1 + num2 + num3;


            double media = soma / 3;
            TxtResultado.Text = Convert.ToString(media);
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNumUm.Text = "";
            TxtNumDois.Text = "";
            TxtNumTres.Text = "";
            TxtResultado.Text = "";
        }

        private void BtnPicVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
