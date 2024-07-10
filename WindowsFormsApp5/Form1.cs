using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text +"3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text +"0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Text="";
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Text="";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Text= "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Text= "";
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
          if(txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Remove(txtTotal.Text.Length - 1, 1);
            }
         
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            num2 =int.Parse(txtTotal.Text);
            if (option == ("+"))
                result = num1 + num2;
            if (option == ("-"))
                result = num1 - num2;
            if (option == ("*"))
                result = num1 * num2;
            if (option == ("/"))
                result = num1 / num2;
            txtTotal.Text = result + "";

            
            
        }

    }
}
