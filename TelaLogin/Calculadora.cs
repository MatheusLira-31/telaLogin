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
    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }


        private Operacao OperacaoSelecionada { get; set; }  

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            lblOperacao.Text = "x";

        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(TxtResultado.Text);
                    break;

                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(TxtResultado.Text);
                    break;

                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(TxtResultado.Text);
                    break;

                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(TxtResultado.Text);
                    break;
             }
            TxtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if(!TxtResultado.Text.Contains(","))
                TxtResultado.Text += ",";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void PicBtnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
