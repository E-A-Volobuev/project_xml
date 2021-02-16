using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace universal_calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Amperage am = new Amperage();
            am.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Losses loss = new Losses();
            loss.Show();
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile prof = new Profile();
            prof.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\Расчет для скважин.xlsx");
            }
           catch
            {
                MessageBox.Show("что-то пошло не так((");
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mech amp = new Mech();
            amp.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WordOtch wr = new WordOtch();
            wr.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\Расчеты Вл.xlsx");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VL vl = new VL();
            vl.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateOL ol = new CreateOL();
            ol.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           Paint paint = new Paint();
            paint.Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Moln mol= new Moln();
            mol.Show();
            Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           Svet sv = new Svet();
            sv.Show();
            Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            K_zhurnal kzh = new K_zhurnal();
            kzh.Show();
        }
    }
}
