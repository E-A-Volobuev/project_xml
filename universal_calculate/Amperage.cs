using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universal_calculate
{
    public partial class Amperage : Form
    {
        WebBrowser webBrowser = new WebBrowser();
        public Amperage()
        {
            InitializeComponent();
            label5.Visible = false;
            label6.Visible = false;
            try
            {
                webBrowser.Navigate("https://www.calc.ru/tok-v-odnofaznykh-i-trekhfaznykh-setyakh-kalkulyator.html");
                webBrowser.ScriptErrorsSuppressed = true;
            }
            catch
            {
                MessageBox.Show("Проверьте соединение с интернетом");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                    if (radioButton1.Checked == true)
                    {

                        webBrowser.Document.GetElementById("num3_1").InvokeMember("CLICK"); //1 фаза
                        Process();
                    }
                    else
                    {

                        webBrowser.Document.GetElementById("num3_2").InvokeMember("CLICK"); //3 фазы
                        Process();
                    }
                
               
            }
            catch
            {
                MessageBox.Show("что-то пошло не так(((");
                Application.Exit();
            }
        }
        public void Process()
        {
            if(radioButton3.Checked==true)
            {
               
                webBrowser.Document.GetElementById("num4_1").InvokeMember("CLICK");// активная
                Attribut();
            }
            else
            {
                
                webBrowser.Document.GetElementById("num4_2").InvokeMember("CLICK");// реактивная
                Attribut();
            }
        }
        public void Attribut()
        {
           
            
                webBrowser.Document.GetElementById("num").SetAttribute("value", $"{textBox1.Text}");//мощность нагрузки
                webBrowser.Document.GetElementById("num1").SetAttribute("value", $"{textBox2.Text}");//напряжение в сети
                foreach (HtmlElement hh in webBrowser.Document.GetElementsByTagName("input")) //берем все элементы с тегом input
                {
                    if (hh.GetAttribute("id") == "submit")
                        hh.InvokeMember("click");//вызываем клик
                }
                webBrowser.DocumentCompleted += Result_DocumentCompleted;
            
            
        }
        //ожидание полной загрузки страницы и запись ответа html в строку////////////////////////////////////////////////////////////////
        void Result_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            StreamReader SR = new StreamReader(this.webBrowser.DocumentStream, Encoding.GetEncoding("windows-1251"));
            var s = SR.ReadToEnd();
            Result(s);
        }
        //поиск результата расчёта в строке(html) ответа с сайта///////////////////////////////////////////////////////////////////////////////////////////
        public void Result(string text)
        {
            string subString = "равен</span>";
            int indexOfSubstring = text.IndexOf(subString);
            text = text.Substring(indexOfSubstring + 12, 18);
            label6.Text = text;
            label5.Visible = true;
            label6.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.Show();
            Hide();
            
        }

        private void Amperage_Load(object sender, EventArgs e)
        {

        }
    }
}
