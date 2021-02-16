using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universal_calculate
{
    public partial class Losses : Form
    {
        WebBrowser webBrowser1 = new WebBrowser();
        public Losses()
        {
            try
            {
                InitializeComponent();
                webBrowser1.Navigate("https://www.calc.ru/poteri-napryazheniya-v-kabele-kalkulyator.html");
                webBrowser1.ScriptErrorsSuppressed = true;

                comboBox1.Items.AddRange(new string[] { "Алюминий", "Медь" });
                comboBox2.Items.AddRange(new string[] { "0.50", "0.75", "1.00", "1.50", "2.50", "4.00", "6.00",
                "10.00", "16.00", "25.00", "35.00", "50.00", "70.00","95.00","120.00","150.00","185.00","240.00" });
                radioButton1.Click += RadioButton1Event;
                radioButton2.Click += RadioButton2Event;
                label14.Visible = false;
                label15.Visible = false;
            }
            catch
            {
                MessageBox.Show("Проверьте соединение с интернетом");
                Application.Exit();
            }
           
            
        }
        //стилистика формы при переключении флажков/////////////////////////////////
        public void RadioButton1Event(object sender, EventArgs e)
        {
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox5.Visible = false;
        }
        public void RadioButton2Event(object sender, EventArgs e)
        {
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            textBox5.Visible = true;
        }
        //кнопка////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true && radioButton2.Checked == false)//постоянный ток
                {
                    webBrowser1.Document.GetElementById("acdc_0").InvokeMember("CLICK"); //постоянный ток
                    if (comboBox1.SelectedItem.ToString() == "Алюминий")// материал
                    {
                        webBrowser1.Document.GetElementById("mDC").SetAttribute("value", "0");//материал
                        DcAttrib();

                    }
                    else
                    {
                        webBrowser1.Document.GetElementById("mDC").SetAttribute("value", "14");
                        DcAttrib();
                    }

                }
                else
                {

                    webBrowser1.Document.GetElementById("acdc_1").InvokeMember("CLICK");
                    if (comboBox1.SelectedItem.ToString() == "Алюминий")// материал
                    {
                        webBrowser1.Document.GetElementById("mAC").SetAttribute("value", "0");//материал
                        AcAttrib_Part1();

                    }
                    else
                    {
                        webBrowser1.Document.GetElementById("mAC").SetAttribute("value", "14");
                        AcAttrib_Part1();
                    }
                }
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
                Application.Exit();
            }

           
        }
        //ожидание полной загрузки страницы и запись ответа html в строку////////////////////////////////////////////////////////////////
        void Result_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            StreamReader SR = new StreamReader(this.webBrowser1.DocumentStream, Encoding.GetEncoding("windows-1251"));
            var s = SR.ReadToEnd();
            Result(s);
        }
        //заполнение отрибутов формы для постоянного тока при выборе материала проводника//////////////////////////////////////////////////////////////
        public void DcAttrib()
        {
            string select= comboBox2.SelectedItem.ToString();
            webBrowser1.Document.GetElementById("lDC").SetAttribute("value", $"{textBox1.Text}");//длина линии
            webBrowser1.Document.GetElementById("sDC").SetAttribute("value", $"{select}");//сечение кабеля
            webBrowser1.Document.GetElementById("pDC").SetAttribute("value", $"{textBox3.Text}");//мощность нагрузки
            webBrowser1.Document.GetElementById("uDC").SetAttribute("value", $"{textBox4.Text}");//напряжение сети
            foreach (HtmlElement hh in webBrowser1.Document.GetElementsByTagName("input")) //берем все элементы с тегом input
            {
                if (hh.GetAttribute("id") == "submit")
                    hh.InvokeMember("click");//вызываем клик
            }
            webBrowser1.DocumentCompleted += Result_DocumentCompleted;
        }
        //заполнение аттрибутов формы переменного тока при выборе материала проводника/////////////////////////////////////////////////
        public void AcAttrib_Part1()
        {
            string select = comboBox2.SelectedIndex.ToString();
            webBrowser1.Document.GetElementById("lAC").SetAttribute("value", $"{textBox1.Text}");//длина линии
            webBrowser1.Document.GetElementById("sAC").SetAttribute("value", $"{select}");//сечение кабеля
            webBrowser1.Document.GetElementById("pAC").SetAttribute("value", $"{textBox3.Text}");//мощность нагрузки
            //количество фаз////////
            if (radioButton3.Checked == true && radioButton4.Checked == false && radioButton5.Checked == false)
            {
                webBrowser1.Document.GetElementById("fazaAC_0").InvokeMember("CLICK");
                AcAttrib_Part2();
            }
            else if ((radioButton3.Checked == false && radioButton4.Checked == true && radioButton5.Checked == false))
            {
                webBrowser1.Document.GetElementById("fazaAC_1").InvokeMember("CLICK");
                AcAttrib_Part2();
            }
            else
            {
                webBrowser1.Document.GetElementById("fazaAC_2").InvokeMember("CLICK");
                AcAttrib_Part2();
            }

        }
        public void AcAttrib_Part2()
        {
            
            webBrowser1.Document.GetElementById("uAC").SetAttribute("value", $"{textBox4.Text}");//напряжение сети
            webBrowser1.Document.GetElementById("cosAC").SetAttribute("value", $"{textBox5.Text}");//коэффициент мощности
            foreach (HtmlElement hh in webBrowser1.Document.GetElementsByTagName("input")) //берем все элементы с тегом input
            {
                if (hh.GetAttribute("id") == "submit")
                    hh.InvokeMember("click");//вызываем клик
            }
            webBrowser1.DocumentCompleted += Result_DocumentCompleted;
        }


        //поиск результата расчёта в строке(html) ответа с сайта///////////////////////////////////////////////////////////////////////////////////////////
        public void Result(string text)
        {
            string subString = "составляют</span>";
            int indexOfSubstring = text.IndexOf(subString);
            text = text.Substring(indexOfSubstring + 17, 22);
            label15.Text = text;
            label14.Visible = true;
            label15.Visible = true;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void Losses_Load(object sender, EventArgs e)
        {

        }
    }
}
