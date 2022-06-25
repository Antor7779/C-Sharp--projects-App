using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class calculatorBody : Form
    {
        String operation = "";
        Double firstNumber, secondNumber;

        public calculatorBody()
        {
            InitializeComponent();
        }

        private void numericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if(b.Text==".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;

            }

            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void Clearclick_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            String f, s;
            f = Convert.ToString(firstNumber);
            s = Convert.ToString(secondNumber);

            f = "";
            s = "";

            
        }

        private void operational_Functions(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNumber = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = "";
        }

        private void txtDislpay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
