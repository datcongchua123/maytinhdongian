using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maytinhdongian
{
    public partial class Form1 : Form
    {
        string currentExpression = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            currentExpression += "1";
            txtDisplay.Text = currentExpression;
            btn1.Text += "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentExpression += "2";
            txtDisplay.Text = currentExpression;
            btn2.Text += "";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentExpression += "3";
            txtDisplay.Text = currentExpression;
            btn3.Text += "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentExpression += "4";
            txtDisplay.Text = currentExpression;
            btn4.Text += "";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            currentExpression += "5";
            
        txtDisplay.Text = currentExpression;
            btn5.Text += "";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            currentExpression += "6";
            txtDisplay.Text = currentExpression;
            btn6.Text += "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            currentExpression += "7";
                txtDisplay.Text = currentExpression;
            btn7.Text += "";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            currentExpression += "8";
            txtDisplay.Text = currentExpression;
            btn8.Text += "";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            currentExpression += "9";
            txtDisplay.Text = currentExpression;
            btn9.Text += "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            currentExpression += "0";
            txtDisplay.Text = currentExpression;
            btn0.Text += "";
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            currentExpression += "+";
            txtDisplay.Text = currentExpression;
            btncong.Text += "";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            currentExpression += "-";
            txtDisplay.Text = currentExpression;
            btntru.Text += "";
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            currentExpression += "*";
                txtDisplay.Text = currentExpression;
            btnnhan.Text += "";
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            currentExpression += "/";
            txtDisplay.Text = currentExpression;
            btnchia.Text += "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            currentExpression = "";
        }

        private void btnketqua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(currentExpression, "");
                txtDisplay.Text = currentExpression + "=" + result.ToString();
                currentExpression = result.ToString();
            }
            catch (Exception ex){
                txtDisplay.Text = "Lỗi!";
                currentExpression = "";
            }
        }
    }
}
