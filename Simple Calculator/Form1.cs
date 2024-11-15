using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "9";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textresult.Clear();
            textstore.Clear();
        }

        float num;
        int count;
        private void btnmin_Click(object sender, EventArgs e)
        {
            if(textstore.Text!="")
            {
                num = float.Parse(textstore.Text);
                textresult.Text = textstore.Text + "-";
                textstore.Clear();
                count = 1;
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresult.Text = textstore.Text + "+";
                textstore.Clear();
                count = 2;
            }

        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresult.Text = textstore.Text + "x";
                textstore.Clear();
                count = 3;
            }

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresult.Text = textstore.Text + "/";
                textstore.Clear();
                count = 4;
            }

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresult.Text = textstore.Text + "%";
                textstore.Clear();
                count = 5;
            }

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(textstore.Text);
                    textresult.Text = textresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;

                case 2:
                    ans = num + float.Parse(textstore.Text);
                    textresult.Text = textresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textstore.Text);
                    textresult.Text = textresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textstore.Text);
                    textresult.Text = textresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;

                case 5:
                    ans = num % float.Parse(textstore.Text);
                    textresult.Text = textresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;



            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textstore.Clear();
        }
    }
}
