using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt64(txtBoxInput1.Text);
            num2 = Convert.ToInt64(txtBoxInput2.Text);

            if (cbOperator.Text.ToString().Equals("+"))
            {
                cal.CalculateEvent += new Information<double>(cal.getSum);
                lblDisplayOutput.Text = cal.getSum(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.getSum);

            }else if (cbOperator.Text.ToString().Equals("-"))
            {
                cal.CalculateEvent += new Information<double>(cal.getDifference);
                lblDisplayOutput.Text = cal.getDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.getDifference);

            }else if (cbOperator.Text.ToString().Equals("*"))
            {
                cal.CalculateEvent += new Information<double>(cal.getProduct);
                lblDisplayOutput.Text = cal.getProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.getProduct);

            }
            else if (cbOperator.Text.ToString().Equals("/"))
            {
                cal.CalculateEvent += new Information<double>(cal.getQuotient);
                lblDisplayOutput.Text = cal.getQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.getQuotient);

            }
        }
    }
}
