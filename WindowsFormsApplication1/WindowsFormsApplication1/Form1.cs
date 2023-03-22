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
    public partial class Form1 : Form
    {
        public decimal s = 0;
        public bool kt = true, kt2 = true;
        public string dau = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void tinh()
        {
            if (dau == "+") s = cong();
            if (dau == "-") s = tru();
            if (dau == "x") s = nhan();
            if (dau == "/") s = chia();
            if (dau == "") s = decimal.Parse(label1.Text);
        }
        private decimal cong()
        {
            return s + decimal.Parse(label1.Text);
        }
        private decimal tru()
        {
            return s - decimal.Parse(label1.Text);
        }
        private decimal nhan()
        {
            return s * decimal.Parse(label1.Text);
        }
        private decimal chia()
        {
            return s / decimal.Parse(label1.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void N0_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '0';
        }

        private void N1_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '1';
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '2';
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '3';
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '4';
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '5';
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '6';
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '7';
        }

        private void N8_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '8';
        }

        private void N9_Click(object sender, EventArgs e)
        {
            if (kt == false) { label1.Text = ""; kt = true; }
            label1.Text += '9';
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0) N0_Click(sender, e);
        }

        private void CONG_Click(object sender, EventArgs e)
        {
            if (kt2 == true)
            {
                textBox1.Text += label1.Text + '+';
                tinh();
                label1.Text = s.ToString();
                kt = false;
            } else
            {
                textBox1.Text += '+';
                label1.Text = "";
            }
            dau = "+";
        }

        private void TRU_Click(object sender, EventArgs e)
        {
            if (kt2 == true)
            {
                textBox1.Text += label1.Text + '-';
                tinh();
                label1.Text = s.ToString();
                kt = false;
            }
            else
            {
                textBox1.Text += '-';
                label1.Text = "";
            }
            dau = "-";
        }

        private void NHAN_Click(object sender, EventArgs e)
        {
            if (kt2 == true)
            {
                textBox1.Text += label1.Text + 'x';
                tinh();
                kt = false;
            }
            else
            {
                textBox1.Text += '*';
                label1.Text = "";
            }
            dau = "x";
        }

        private void CHIA_Click(object sender, EventArgs e)
        {
            if (kt2 == true)
            {
                textBox1.Text += label1.Text + '/';
                tinh();
                kt = false;
            }
            else
            {
                textBox1.Text += '/';
                label1.Text = "";
            }
            dau = "/";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            s = 0;
            dau = "";
            kt = true;
            kt2 = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            tinh();
            label1.Text = s.ToString();
            kt2 = false;
        }
    }
}
