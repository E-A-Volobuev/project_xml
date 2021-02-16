using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universal_calculate
{
    public partial class Svet : Form
    {
        public Svet()
        {
            InitializeComponent();
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel2.LinkClicked += linkLabel1_LinkClicked;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\СП-53.13.330.2016.pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ml = new Form1();
            ml.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double e_ = Convert.ToDouble(textBox1.Text);
                double s_ = Convert.ToDouble(textBox2.Text);
                double n_ = Convert.ToDouble(textBox3.Text);
                double k_ = Convert.ToDouble(textBox4.Text);
                double f_ = Convert.ToDouble(textBox5.Text);
                double x_ = Convert.ToDouble(textBox6.Text);
                double l = (e_ * s_ * n_ * k_) / (f_ * x_);
                label20.Text = Substring_Text(l.ToString());
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введнных данных");
            }
        }
        public string Substring_Text(string text)
        {
            if (text.Contains(","))
            {
                char ch = ',';
                int indexOfChar = text.IndexOf(ch);
                if (text.Length > indexOfChar + 4)
                {
                    text = text.Substring(0, indexOfChar + 3);
                    return text;
                }
                else
                {
                    text = text.Substring(0, indexOfChar + 2);
                    return text;
                }
            }
            else
            {
                return text;
            }
        }
    }
}
