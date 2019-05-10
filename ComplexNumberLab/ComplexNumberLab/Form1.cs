using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumberLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ComplexNumber a = new ComplexNumber(Convert.ToDouble(tBoxRealPart1.Text), Convert.ToDouble(tBoxImaginaryPart1.Text));
            ComplexNumber b = new ComplexNumber(Convert.ToDouble(tBoxRealPart2.Text), Convert.ToDouble(tBoxImaginaryPart2.Text));
            ComplexNumber c = new ComplexNumber(Convert.ToDouble(tBoxRealPart3.Text), Convert.ToDouble(tBoxImaginaryPart3.Text));
            ComplexNumber d = new ComplexNumber(Convert.ToDouble(tBoxRealPart4.Text), Convert.ToDouble(tBoxImaginaryPart4.Text));

            ComplexNumber R = a.GetComplexNumberSqrt(3) - ((b + c) / a) + (b * d);
            ResultTextBox1.Text = R.Output();
            ResultTextBox2.Text = (R.GetComplexNumberModule()).ToString();
            R++;
            ResultTextBox3.Text = R.Output();
        }
    }
}
