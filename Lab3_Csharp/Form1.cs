using System;
using System.Windows.Forms;

namespace Lab3_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            ComplexNumber a = new ComplexNumber(Convert.ToDouble(tBoxRealPart1.Text), Convert.ToDouble(tBoxImaginaryPart1.Text));
            ComplexNumber b = new ComplexNumber(Convert.ToDouble(tBoxRealPart2.Text), Convert.ToDouble(tBoxImaginaryPart2.Text));
            ComplexNumber c = new ComplexNumber(Convert.ToDouble(tBoxRealPart3.Text), Convert.ToDouble(tBoxImaginaryPart3.Text));
            ComplexNumber d = new ComplexNumber(Convert.ToDouble(tBoxRealPart4.Text), Convert.ToDouble(tBoxImaginaryPart4.Text));
            
            ComplexNumber R = a.GetComplexNumberSqrt(3) - ((b + c) / a) + (b * d);
            ResultTextBox1.Text = R.ToString();
            ResultTextBox2.Text = (R.GetComplexNumberModule()).ToString();
            R++;
            ResultTextBox3.Text = R.ToString();
        }
    }
}
