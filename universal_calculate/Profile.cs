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
    public partial class Profile : Form
    {
        WebBrowser web = new WebBrowser();
        public Profile()
        {
            InitializeComponent();
            web.Navigate("https://www.calc.ru/raschet-secheniya-kabelya-kalkulyator.html");
            web.ScriptErrorsSuppressed = true;
            label9.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            trackBar1.Scroll += trackBar1_Scroll;
            comboBox1.Items.AddRange(new string[] { "Открытая проводка", "Два одножильных в трубе", "Три одножильных в трубе",
                "Четыре одножильных в трубе","Один двухжильный в трубе","Один трёхжильный в трубе","Гр. прокладка в коробах, 1-4 кабеля",
                "Гр. прокладка в коробах, 5-6 кабелей","Гр. прокладка в коробах, 7-9 кабелей","Гр. прокладка в коробах, 10-11 кабелей",
                "Гр. прокладка в коробах, 12-14 кабелей" ,"Гр. прокладка в коробах, 15-18 кабелей"});
        }
        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Visible = true;
            label9.Text = trackBar1.Value.ToString()+ "°С";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true && radioButton2.Checked == false)
                {
                    web.Document.GetElementById("resistunits_0").InvokeMember("CLICK"); //медь
                    Logic_Part1();
                }
                else
                {
                    web.Document.GetElementById("resistunits_1").InvokeMember("CLICK"); //аллюминий
                    Logic_Part1();
                }
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
                Application.Exit();
            }
        }
        public void Logic_Part1()
        {
            web.Document.GetElementById("length").SetAttribute("value", $"{textBox1.Text}");//длина линии
            web.Document.GetElementById("power").SetAttribute("value", $"{textBox2.Text}");//мощность нагрузки
            if (radioButton3.Checked == true && radioButton4.Checked == false)
            {
                web.Document.GetElementById("faz_0").InvokeMember("CLICK"); //1 фаза
                Logic_Part2();
            }
            else
            {
                web.Document.GetElementById("faz_1").InvokeMember("CLICK"); //3 фазы
                Logic_Part2();
            }
        }
        public void Logic_Part2()
        {
            string temp = trackBar1.Value.ToString();
            string select = comboBox1.SelectedIndex.ToString();
            web.Document.GetElementById("voltag").SetAttribute("value", $"{textBox3.Text}");//напряжение сети
            web.Document.GetElementById("cosinus").SetAttribute("value", $"{textBox4.Text}");//Коэффициент мощности
            web.Document.GetElementById("loss").SetAttribute("value", $"{textBox5.Text}");//Потери напряжения
            web.Document.GetElementById("t").SetAttribute("value", $"{temp}");//температура кабеля
            web.Document.GetElementById("sposob").SetAttribute("value", $"{select}");//способ прокладки кабеля
            foreach (HtmlElement hh in web.Document.GetElementsByTagName("input")) //берем все элементы с тегом input
            {
                if (hh.GetAttribute("id") == "submit")
                    hh.InvokeMember("click");//вызываем клик
            }
            web.DocumentCompleted += Result_DocumentCompleted;
        }
        //ожидание полной загрузки страницы и запись ответа html в строку////////////////////////////////////////////////////////////////
        public void Result_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            StreamReader SR = new StreamReader(this.web.DocumentStream, Encoding.GetEncoding("windows-1251"));
            var s = SR.ReadToEnd();
            Result(s);
        }
        public void Result(string text)
        {
            string subString = "менее</span>";
            int indexOfSubstring = text.IndexOf(subString);
            text = text.Substring(indexOfSubstring + 13,3);
            label13.Text = text;
            label13.Visible = true;
            label11.Visible = true;
            label12.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }
    }
}
