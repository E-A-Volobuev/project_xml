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
    public partial class Moln : Form
    {
        public Moln()
        {
            InitializeComponent();
            label8.Visible = false;
            label9.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label7.Visible = false;
            label10_0.Visible = false;
            label14_0.Visible = false;
            radioButton7.Visible = false;
            label16_0.Visible = false;
            label17_0.Visible = false;
            label18_0.Visible = false;
            label19_0.Visible = false;
            label20_0.Visible = false;

            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            radioButton1.Click += radioButton1_Click;
            radioButton2.Click += radioButton2_Click;
            radioButton3.Click += radioButton2_Click;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\so_153-34_21_122-2003.pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }
        private void radioButton1_Click(object sender,EventArgs e)
        {
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = true;
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = false;
        }

        //добавление высоты
        private void button1_Click(object sender, EventArgs e)
        {
            string symbol = "_"; // символ в конце названия элемента,после которого стоит номер элемента(уникальный)
            int index = 6;// индекс z в имени элемента

            int max;// нашли максимальное число в имени элементов
            int loc; // координата Y существующего элемента текстбокс
            int location = 193;// координата x  текстбокса

            SearchMaxNumberName(symbol, index, out max, out loc, location);
            max += 1;
            loc += 30;
            //создаём элементы для добавления на форму
            var label_x1 = new Label();
            var textbox = new TextBox();
            var label_x2 = new Label();
            var button = new Button();
            var label_x3 = new Label();
            var label_x4 = new Label();
           


            label_x1.Name = "labelx1_" + max;
            label_x1.Size = new System.Drawing.Size(180, 16);
            label_x1.Text = "Введите высоту объекта:";
            label_x1.Location = new Point(0, loc);
            this.Controls.Add(label_x1);

            textbox.Name = "textb_" + max;
            textbox.Size = new System.Drawing.Size(68, 22);
            textbox.Location = new Point(193, loc);
            this.Controls.Add(textbox);

            label_x2.Name = "labelx2_" + max;
            label_x2.Size = new System.Drawing.Size(17, 16);
            label_x2.Text = "м";
            label_x2.Location = new Point(271, loc);
            this.Controls.Add(label_x2);

            button.Name = "buttonx_" + max;
            button.Size = new System.Drawing.Size(75, 23);
            button.Text = "удалить";
            button.Location = new Point(295, loc);
            button.Click += Button_DelOpora_Click;
            this.Controls.Add(button);

            label_x3.Name = "labelx3_" + max;
            label_x3.Size = new System.Drawing.Size(33, 16);
            label_x3.Text = "rx=";
            label_x3.Location = new Point(403, loc);
            label_x3.Visible = false;
            this.Controls.Add(label_x3);

            label_x4.Name = "labelx4_" + max;
            label_x4.Size = new System.Drawing.Size(50, 13);
            label_x4.Text = "м";
            label_x4.Location = new Point(432, loc);
            label_x4.Visible =false;
            this.Controls.Add(label_x4);

           
        }
        // поиск максимального числа в названии имени элемента и координаты "Y"
        public void SearchMaxNumberName(string symbol, int index, out int max, out int loc, int location)
        {
            string name = null;//название элемента
            int num = 0;// номер элемента
            string subString = symbol;// искомый символ ( "_")
            int indexOfSubstring = 0;//индекс вхождения подстроки в название элемента
            var combo = new TextBox();// найденный элемент
            List<int> numbers = new List<int>();
            //Находим имя существующей высоты 
            foreach (TextBox com in this.Controls.OfType<TextBox>())
            {
                if (com.Location.X == location)
                {
                    indexOfSubstring = com.Name.IndexOf(subString);
                    if (indexOfSubstring > 0)
                    {
                        name = com.Name;
                        combo = com;
                        num = Convert.ToInt32(name.Substring(index));
                        numbers.Add(num);
                    }
                }


            }
            max = numbers.Max();// нашли максимальное число в имени элементов
            loc = combo.Location.Y;
        }
        ////удаление элементов 
        public void Button_DelOpora_Click(object sender, EventArgs e)
        {

            string name = (sender as Button).Name;// имя нажатой кнопки
            string subString = "_";
            int indexOfSubstring = name.IndexOf(subString);//индекс вхождения подстроки в название элемента
            indexOfSubstring += 1;//индекс цифры после черточки в имени элемента
            int num = Convert.ToInt32(name.Substring(indexOfSubstring));// номер в имени элемента
            foreach (Label x1 in this.Controls.OfType<Label>())
            {
                if (x1.Name == "labelx1_" + num)
                {
                    this.Controls.Remove(x1);
                }
            }

            foreach (TextBox cb in this.Controls.OfType<TextBox>())
            {
                if (cb.Name == "textb_" + num)
                {
                    this.Controls.Remove(cb);
                }
            }
            foreach (Label x2 in this.Controls.OfType<Label>())
            {
                if (x2.Name == "labelx2_" + num)
                {
                    this.Controls.Remove(x2);
                }
            }
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name == "buttonx_" + num)
                {
                    this.Controls.Remove(btn);
                }
            }
            foreach (Label x3 in this.Controls.OfType<Label>())
            {
                if (x3.Name == "labelx3_" + num)
                {
                    this.Controls.Remove(x3);
                }
            }
            foreach (Label x4 in this.Controls.OfType<Label>())
            {
                if (x4.Name == "labelx4_" + num)
                {
                    this.Controls.Remove(x4);
                }
            }
            foreach (Label x5 in this.Controls.OfType<Label>())
            {
                if (x5.Name == "labelx5_" + num)
                {
                    this.Controls.Remove(x5);
                }
            }
            foreach (Label x6 in this.Controls.OfType<Label>())
            {
                if (x6.Name == "labelx6_" + num)
                {
                    this.Controls.Remove(x6);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton8.Checked == true || radioButton9.Checked == true)
            {
                label8.Visible = true;
                string subString = "_";
                int indexOfSubstring = 0;//индекс вхождения подстроки в название элемента
                double vysota = Convert.ToDouble(textBox1.Text);// проектируемая высота молниеотвода
                double h0 = 0;// высота зоны защиты
                double r0 = 0;// радиус зоны защиты
                              //Находим имя существующей высоты 
                Rasch(vysota, out h0, out r0);
                label9.Text = h0.ToString();
                label7.Text = r0.ToString();
                label9.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                label7.Visible = true;
                double hx = 0;//высота защищаемого обекта


                double rx = 0;// радиус на высоте hx
                if (radioButton8.Checked == true)
                {
                    Moln2 mol = new Moln2();
                    mol.Show();
                }
                else 
                {
                    Moln3 mol = new Moln3();
                    mol.Show();
                }
              



                foreach (TextBox com in this.Controls.OfType<TextBox>())
                {

                    indexOfSubstring = com.Name.IndexOf(subString);
                    if (indexOfSubstring > 0)
                    {
                        if (com.Text != null && com.Text != "")
                        {
                            hx = Convert.ToDouble(com.Text);
                            rx = RxMethod(h0, r0, hx);
                            var label = this.Controls.OfType<Label>().FirstOrDefault(x => x.Location.Y == com.Location.Y && x.Location.X == 403);
                            label.Visible = true;
                            var label_1 = this.Controls.OfType<Label>().FirstOrDefault(x => x.Location.Y == com.Location.Y && x.Location.X == 432);
                            label_1.Text = Substring_Text(rx.ToString());
                            label_1.Visible = true;

                            if (radioButton9.Checked == true)
                            {
                                TwoMoln(h0, r0, hx);
                                label16_0.Text = "Lmax= " + Substring_Text(L_max);
                                label16_0.Visible = true;
                                label17_0.Text = "Lc= " + Substring_Text(L_c);
                                label17_0.Visible = true;
                                label18_0.Text = "hc= " + Substring_Text(H_c);
                                label18_0.Visible = true;
                                label19_0.Text = "Lx= " + Substring_Text(L_xx);
                                label19_0.Visible = true;
                                label20_0.Text = "rcx= " + Substring_Text(R_cx);
                                label20_0.Visible = true;
                            }


                        }
                        else
                        {
                            MessageBox.Show("Проверьте правильность введённых данных");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Укажите тип молниеотвода");
            }
            
        }
        //ho и r0 рассчёт
        public void Rasch(double vys,out double h0, out double r0)
        {
            h0 = 0;
            r0 = 0;
            //vys - высота проектируемого молниеотвода
            if (radioButton1.Checked == true)
            {
                if (radioButton7.Checked == true)
                {
                    h0 = 0.85 * vys;
                    r0 = 1.2 * vys;
                }
                else
                {
                    h0 = 0.85 * vys;
                    r0 = 1.2 *-0.001*(vys-100)*vys;
                }
            }
            else if(radioButton2.Checked == true)
            {
                if (radioButton6.Checked == true)
                {
                    h0 = 0.8 * vys;
                    r0 = 0.8 * vys;
                }
                else if (radioButton5.Checked == true)
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
                if (radioButton6.Checked == true)
                {
                    h0 = 0.7 * vys;
                    r0 = 0.6 * vys;
                }
                else if (radioButton5.Checked == true)
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
        //rx
        public double RxMethod(double h0,double r0,double hx)
        {
            double rx = r0 * (h0 - hx) / h0;
            return rx;
        }

       
        /// //////////////////////////////////////////////для двух молниеотводов одинаковой высоты
        public string L_max { get; set; }
        public string L_c { get; set; }
        public string H_c { get; set; }
        public string L_xx { get; set; }
        public string R_cx { get; set; }
        public void TwoMoln(double h0, double r0, double hx)
        {
            
            //vys - высота проектируемого молниеотвода
            double Lmax = 0;
            double Lc = 0;
            double L = Convert.ToDouble(textBox2.Text);
            double vys= Convert.ToDouble(textBox1.Text);
            double hx_center= Convert.ToDouble(textBox3.Text);

            if (radioButton1.Checked == true)
            {
                if (vys>0&&vys<30)
                {
                    Lmax = 5.75 * vys;
                    Lc = 2.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
                else if(vys > 30 && vys < 100)
                {
                    Lmax = (5.75 - 3.57 * 0.001 * (vys - 30)) * vys;
                    Lc= Lc = 2.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
                else
                {
                    Lmax = 2.5 * vys;
                    Lc = 2.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (vys > 0 && vys < 30)
                {
                    Lmax = 4.75 * vys;
                    Lc = 2.25 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
                else if (vys > 30 && vys < 100)
                {
                    Lmax = (4.75 - 3.57 * 0.001 * (vys-30)) * vys;
                    Lc = (2.25 - 0.01007 * (vys-30)) * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
                else
                {
                    Lmax = 4.5 * vys;
                    Lc = 1.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
            }
            else
            {
                if (vys > 0 && vys < 30)
                {
                    Lmax = 4.5 * vys;
                    Lc = 2.25 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
                else if (vys > 30 && vys < 100)
                {
                    Lmax = (4.25 - 3.57 * 0.001 * (vys - 30)) * vys;
                    Lc = (2.25-0.01007*(vys-30)) * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
                else
                {
                    Lmax = 4.0 * vys;
                    Lc = 1.5 * vys;
                    Hc_Rcx(Lmax, Lc, L, h0, r0, hx_center, hx);
                }
            }

        }
        public void Hc_Rcx(double Lmax, double Lc, double L,double h0,double r0,double hx_center,double hx)
        {
            double hc = 0;
            double Lx = 0;
            double rcx = 0;
            //hx_center высота объекта между двумя молниеотводами

            if(Lc>=L)
            {
                hc = h0;
                if(hx_center<=hc)
                {
                    rcx = Rcx(r0, hc, hx_center);
                    Lx = L_x(L, h0, hx, hc);
                }
                else
                {
                    MessageBox.Show("hx должно быть меньше hc!!");
                }

            }
            else if(Lc<=L&&L>=Lmax)
            {
                hc = ((Lmax - L) / (Lmax - Lc)) * h0;
                rcx = Rcx(r0, hc, hx_center);
                Lx = L_x(L, h0, hx, hc);
            }
            else
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
            L_max = Lmax.ToString();
            L_c = Lc.ToString();
            H_c = hc.ToString();
            L_xx = Lx.ToString();
            R_cx = rcx.ToString();
        }
        public double L_x(double L,double h0,double hx,double hc)
        {
            double Lx = 0;
            if(hx>=hc)
            {
                Lx = (L * (h0 - hx)) / (2 * (h0 - hc));
                return Lx;
            }
            else
            {
                Lx = L / 2;
                return Lx;
            }
        }
        public double Rcx(double r0, double hc, double hx)
        {
            double rcx = (r0 * (hc - hx)) / hc;
            return rcx;
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

        private void label10_0_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MolnRazn ml = new MolnRazn();
            ml.Show();
            Hide();
        }
    }
}
