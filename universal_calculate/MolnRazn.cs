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
    public partial class MolnRazn : Form
    {
        public MolnRazn()
        {
            InitializeComponent();
            label33.Visible = false;
            label31.Visible = false;
            label30.Visible = false;
            label28.Visible = false;
            label27.Visible = false;
            label17.Visible = false;
            label26.Visible = false;
            label25.Visible = false;
            label24.Visible = false;
            label22.Visible = false;
            label21.Visible = false;
            label20.Visible = false;
            label11.Visible = false;
            label18.Visible = false;
            label32.Visible = false;
            label34.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\4294853905.pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double vys_1 = Convert.ToDouble(textBox1.Text);// проектируемая высота первого молниеотвода
                double vys_2 = Convert.ToDouble(textBox2.Text);// проектируемая высота второго молниеотвода
                double h0 = 0;// высота зоны защиты первого м
                double r0 = 0;// радиус зоны защиты первого м
                string hc1 = "";
                string hc2 = "";
                string r01 = "";
                string r02 = "";
                Rasch(vys_1, out h0, out r0);
                TwoMoln(vys_1, h0, r0);
                label31.Text = "h0=" + " " + h0.ToString();
                label30.Text = "r0=" + " " + r0.ToString();
                label28.Text = "Lmax=" + " " + L_max.ToString();
                label27.Text = "Lc=" + " " + L_c.ToString();
                label26.Text = "hc=" + " " + H_c.ToString();
                hc1 = H_c.ToString();
                r01 = r0.ToString();
                label31.Visible = true;
                label28.Visible = true;
                label27.Visible = true;
                label26.Visible = true;
                label30.Visible = true;
                Rasch(vys_2, out h0, out r0);
                TwoMoln(vys_2, h0, r0);
                label25.Text = " h0 = " + " " + h0.ToString();
                label24.Text = "r0=" + " " + r0.ToString();
                label22.Text = "Lmax=" + " " + L_max.ToString();
                label21.Text = "Lc=" + " " + L_c.ToString();
                label20.Text = "hc=" + " " + H_c.ToString();
                hc2 = H_c.ToString();
                r02 = r0.ToString();
                label22.Visible = true;
                label21.Visible = true;
                label20.Visible = true;
                label25.Visible = true;
                label24.Visible = true;

                label17.Visible = true;
                label33.Visible = true;
                label11.Visible = true;
                Itog(hc1, hc2, r01, r02);
                MolnRazn2 ml = new MolnRazn2();
                ml.Show();
            }
              
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
           


        }

        //ho и r0 рассчёт
        public void Rasch(double vys, out double h0, out double r0)
        {
          
            //vys - высота проектируемого молниеотвода
            if (radioButton1.Checked == true)
            {
                if (vys>0&&vys<=100)
                {
                    h0 = 0.85 * vys;
                    r0 = 1.2 * vys;
                }
                else
                {
                    h0 = 0.85 * vys;
                    r0 = 1.2 * -0.001 * (vys - 100) * vys;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (vys > 0 && vys <= 30)
                {
                    h0 = 0.8 * vys;
                    r0 = 0.8 * vys;
                }
                else if (vys > 30 && vys <= 100)
                {
                    h0 = 0.8 * vys;
                    r0 = (0.8 - 1.43 * 0.001 * (vys - 30)) * vys;
                }
                else
                {
                    h0 = (0.8 - 0.001 * (vys - 100)) * vys;
                    r0 = 0.7 * vys;
                }
            }
            else
            {
                if (vys > 0 && vys <= 30)
                {
                    h0 = 0.7 * vys;
                    r0 = 0.6 * vys;
                }
                else if (vys > 30 && vys <= 100)
                {
                    h0 = (0.7 - 7.14 * 0.0001 * (vys - 30)) * vys;
                    r0 = (0.6 - 1.43 * 0.001 * (vys - 30)) * vys;
                }
                else
                {
                    h0 = (0.65 - 0.001 * (vys - 100)) * vys;
                    r0 = (0.5 - 2 * 0.001 * (vys - 100)) * vys;
                }
            }
        }

        //обрезка текста
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
        //rx
        public double RxMethod(double h0, double r0, double hx)
        {
            double rx = r0 * (h0 - hx) / h0;
            return rx;
        }
        /// //////////////////////////////////////////////
        public string L_max { get; set; }
        public string L_c { get; set; }
        public string H_c { get; set; }

        public void TwoMoln(double vysota,double h0, double r0)
        {

            //vys - высота проектируемого молниеотвода
            double Lmax = 0;
            double Lc = 0;
            double L = Convert.ToDouble(textBox4.Text);
            double vys = vysota;

            if (radioButton1.Checked == true)
            {
                if (vys > 0 && vys < 30)
                {
                    Lmax = 5.75 * vys;
                    Lc = 2.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
                else if (vys > 30 && vys < 100)
                {
                    Lmax = (5.75 - 3.57 * 0.001 * (vys - 30)) * vys;
                    Lc = Lc = 2.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
                else
                {
                    Lmax = 2.5 * vys;
                    Lc = 2.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (vys > 0 && vys < 30)
                {
                    Lmax = 4.75 * vys;
                    Lc = 2.25 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
                else if (vys > 30 && vys < 100)
                {
                    Lmax = (4.75 - 3.57 * 0.001 * (vys - 30)) * vys;
                    Lc = (2.25 - 0.01007 * (vys - 30)) * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
                else
                {
                    Lmax = 4.5 * vys;
                    Lc = 1.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
            }
            else
            {
                if (vys > 0 && vys < 30)
                {
                    Lmax = 4.5 * vys;
                    Lc = 2.25 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
                else if (vys > 30 && vys < 100)
                {
                    Lmax = (4.25 - 3.57 * 0.001 * (vys - 30)) * vys;
                    Lc = (2.25 - 0.01007 * (vys - 30)) * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
                else
                {
                    Lmax = 4.0 * vys;
                    Lc = 1.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0);
                }
            }

        }
        public void Hc_Rcx(double Lmax, double Lc, double L, double h0)
        {
            double hc = 0;
           
            //hx_center высота объекта между двумя молниеотводами

            if (Lc >= L)
            {
                hc = h0;

               

            }
            else if (Lc <= L && L >= Lmax)
            {
                hc = ((Lmax - L) / (Lmax - Lc)) * h0;

            }
            else
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
            L_max = Lmax.ToString();
            L_c = Lc.ToString();
            H_c = hc.ToString();

        }
       
       //расчёт общих hc rc и rcx
       public void Itog(string hc1, string hc2, string r01, string r02)
        {

            double hc_1 = Convert.ToDouble(hc1);
            double hc_2 = Convert.ToDouble(hc2);
            double r0_1 = Convert.ToDouble(r01);
            double r0_2 = Convert.ToDouble(r02);
            double hx = Convert.ToDouble(textBox3.Text);

            double hc = 0;
            double rc = 0;
            double rcx = 0;
            hc = (hc_1 + hc_2) / 2;
            rc = (r0_1 + r0_2) / 2;
            if (hc >= hx)
            {
                rcx = (rc * (hc - hx)) / hc;
            }
            else
            {
                MessageBox.Show("Высота между молниеотводами должна быть меньше");
            }
            label18.Text = "hc ="+ Substring_Text(hc.ToString());
            label18.Visible = true;
            label32.Text = "rc ="+Substring_Text(rc.ToString());
            label32.Visible = true;
            label34.Text = "rcx = "+Substring_Text(rcx.ToString());
            label34.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Moln ml = new Moln();
            ml.Show();
            Hide();
        }
    }
}
