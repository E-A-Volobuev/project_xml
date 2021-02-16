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
    public partial class WordOtch : Form
    {
        public WordOtch()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 3;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 3;
            numericUpDown3.Minimum = 1;
            numericUpDown3.Maximum = 3;
            numericUpDown4.Minimum = 1;
            numericUpDown4.Maximum = 3;
            var listKtp = NameKTP();
            comboBox5.Items.AddRange(listKtp);
            comboBox5.SelectionChangeCommitted += KtpEvent;
            var mass = Cabel_Name();
            comboBox1.Items.AddRange(mass);
            comboBox2.Items.AddRange(mass);
            comboBox3.Items.AddRange(mass);
            var kol_vo = Kol_zhil();
            comboBox6.Items.AddRange(kol_vo);
            comboBox7.Items.AddRange(kol_vo);
            comboBox8.Items.AddRange(kol_vo);
            Visible_Element();
            radioButton1.Click += Radiobutton1_Click;
            radioButton2.Click += Radiobutton2_Click;
            radioButton3.Click += Radiobutton3_Click;
            radioButton4.Click += Radiobutton4_Click;
            radioButton5.Click += Radiobutton5_Click;
            radioButton6.Click += Radiobutton6_Click;
            numericUpDown1.Click += Numerical1_Click;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;

        }
        //видимость ячеек
        public void Visible_Element()
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            textBox2.Visible = false;
            textBox5.Visible = false;
            numericUpDown3.Visible = false;
            textBox8.Visible = false;
            groupBox2.Visible = false;
            textBox26.Visible = false;
            textBox31.Visible = false;
            textBox33.Visible = false;
            textBox35.Visible = false;
            label21.Visible = false; 
            label22.Visible = false;
            textBox11.Visible = false;
            textBox14.Visible = false;
            label20.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            label16.Visible = false; 
            textBox17.Visible = false;
            comboBox2.Visible = false;
            textBox20.Visible = false;
            textBox23.Visible = false;
            textBox38.Visible = false;
            textBox41.Visible = false;
            textBox47.Visible = false;
            textBox50.Visible = false;
            textBox53.Visible = false;
            textBox56.Visible = false;
            textBox59.Visible = false;
            comboBox7.Visible = false;

            label73.Visible = false;
            label77.Visible = false;
            label81.Visible = false;
            label61.Visible = false;
            label62.Visible = false;
            label91.Visible = false;
            label94.Visible = false;
            label101.Visible = false;
            label105.Visible = false;
            label109.Visible = false;
            label122.Visible = false;
            label127.Visible = false;

            textBox3.Visible = false;
            textBox6.Visible = false;
            numericUpDown4.Visible = false;
            textBox9.Visible = false;
            groupBox3.Visible = false;
            textBox25.Visible = false;
            textBox32.Visible = false;
            textBox34.Visible = false;
            textBox36.Visible = false;
            label31.Visible = false;
            label30.Visible = false;
            textBox12.Visible = false;
            textBox15.Visible = false;
            label29.Visible = false;
            label26.Visible = false;
            label25.Visible = false;
            label24.Visible = false;
            textBox18.Visible = false;
            comboBox3.Visible = false;
            textBox21.Visible = false;
            textBox24.Visible = false;
            textBox39.Visible = false;
            textBox42.Visible = false;
            textBox48.Visible = false;
            textBox51.Visible = false;
            textBox54.Visible = false;
            textBox57.Visible = false;
            textBox60.Visible = false;
            comboBox8.Visible = false;

            label74.Visible = false;
            label78.Visible = false;
            label82.Visible = false;
            label63.Visible = false;
            label64.Visible = false;
            label92.Visible = false;
            label95.Visible = false;
            label102.Visible = false;
            label106.Visible = false;
            label110.Visible = false;
            label123.Visible = false;
            label128.Visible = false;

        }
        //обработка клика количества электроприёмников
        public void Numerical1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value==2)
            {
                textBox2.Visible = true;
                textBox5.Visible = true;
                numericUpDown3.Visible = true;
                textBox8.Visible = true;
                groupBox2.Visible = true;
                textBox26.Visible = true;
                textBox31.Visible = true;
                textBox33.Visible = true;
                textBox35.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                textBox11.Visible = true;
                textBox14.Visible = true;
                label20.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label16.Visible = true;
                textBox17.Visible = true;
                comboBox2.Visible = true;
                textBox20.Visible = true;
                textBox23.Visible = true;
                textBox38.Visible = true;
                textBox41.Visible = true; 
                textBox47.Visible = true;
                textBox50.Visible = true;
                textBox53.Visible = true;
                textBox56.Visible = true;
                textBox59.Visible = true;
                label73.Visible = true;
                label77.Visible = true;
                label81.Visible = true;
                label61.Visible = true;
                label62.Visible = true;
                label91.Visible = true;
                label94.Visible = true;
                label101.Visible = true;
                label105.Visible = true;
                label109.Visible = true;
                label122.Visible = true;
                comboBox7.Visible = true;
                label127.Visible = true;


                textBox3.Visible = false;
                textBox6.Visible = false;
                numericUpDown4.Visible = false;
                textBox9.Visible = false;
                groupBox3.Visible = false;
                textBox25.Visible = false;
                textBox32.Visible = false;
                textBox34.Visible = false;
                textBox36.Visible = false;
                label31.Visible = false;
                label30.Visible = false;
                textBox12.Visible = false;
                textBox15.Visible = false;
                label29.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                textBox18.Visible = false;
                comboBox3.Visible = false;
                textBox21.Visible = false;
                textBox24.Visible = false;
                textBox39.Visible = false;
                textBox42.Visible = false;
                textBox48.Visible = false;
                textBox51.Visible = false;
                textBox54.Visible = false;
                textBox57.Visible = false;
                textBox60.Visible = false;
                comboBox8.Visible = false;

                label74.Visible = false;
                label78.Visible = false;
                label82.Visible = false;
                label63.Visible = false;
                label64.Visible = false;
                label92.Visible = false;
                label95.Visible = false;
                label102.Visible = false;
                label106.Visible = false;
                label110.Visible = false;
                label123.Visible = false;
                label128.Visible = false;


            }
            else if(numericUpDown1.Value == 1)
            {
                Visible_Element();
            }
            else 
            {
                textBox3.Visible = true;
                textBox6.Visible = true;
                numericUpDown4.Visible = true;
                textBox9.Visible = true;
                groupBox3.Visible = true;
                textBox25.Visible = true;
                textBox32.Visible = true;
                textBox34.Visible = true;
                textBox36.Visible = true;
                label31.Visible = true;
                label30.Visible = true;
                textBox12.Visible = true;
                textBox15.Visible = true;
                label29.Visible = true;
                label26.Visible = true;
                label25.Visible = true;
                label24.Visible = true;
                textBox18.Visible = true;
                comboBox3.Visible = true;
                textBox21.Visible = true;
                textBox24.Visible = true;
                textBox39.Visible = true;
                textBox42.Visible = true;
                textBox48.Visible = true;
                textBox51.Visible = true;
                textBox54.Visible = true;
                textBox57.Visible = true;
                textBox60.Visible = true;
                label74.Visible = true;
                label78.Visible = true;
                label82.Visible = true;
                label63.Visible = true;
                label64.Visible = true;
                label92.Visible = true;
                label95.Visible = true;
                label102.Visible = true;
                label106.Visible = true;
                label110.Visible = true;
                label113.Visible = true;
                comboBox8.Visible = true;
                label128.Visible = true;

            }
            
        }
        //обработка значений переключателей мощности
        public void Radiobutton1_Click(object sender, EventArgs e)
        {
            textBox27.Visible = true;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            label7.Visible = false;
            button3.Visible = false;


        }
        public void Radiobutton2_Click(object sender, EventArgs e)
        {
            textBox27.Visible = false;
            textBox28.Visible = true;
            textBox29.Visible = true;
            textBox30.Visible = true;
            label53.Visible = true;
            label54.Visible = true;
            label57.Visible = true;
            label7.Visible = true;
            button3.Visible = true;
        }
        public void Radiobutton3_Click(object sender, EventArgs e)
        {
            textBox26.Visible = true;
            textBox31.Visible = false;
            textBox33.Visible = false;
            textBox35.Visible = false;
            label22.Visible = false;
            button4.Visible = false;


        }
        public void Radiobutton5_Click(object sender, EventArgs e)
        {
            textBox26.Visible = false;
            label53.Visible = true;
            label54.Visible = true;
            label57.Visible = true;
            textBox31.Visible = true;
            textBox33.Visible = true;
            textBox35.Visible = true;
            label22.Visible = true;
            button4.Visible = true;

        }
        public void Radiobutton4_Click(object sender, EventArgs e)
        {
            textBox25.Visible = true;
            textBox32.Visible = false;
            textBox34.Visible = false;
            textBox36.Visible = false;
            label31.Visible = false;
            label31.Visible = false;
            button5.Visible = false;

        }
        public void Radiobutton6_Click(object sender, EventArgs e)
        {
            textBox25.Visible = false;
            label53.Visible = true;
            label54.Visible = true;
            label57.Visible = true;
            textBox32.Visible = true;
            textBox34.Visible = true;
            textBox36.Visible = true;
            label31.Visible = true;
            button5.Visible = true;

        }
        //обработчик выбора обмотки трансформатора по типу транса
        public void KtpEvent(object sender, EventArgs e)
        {
            int power = Convert.ToInt32(comboBox5.SelectedItem.ToString());
            var ktp = Val().FirstOrDefault(l => l.Power == power);
            string firstPower_1 = ktp.FirstPower_1.ToString();
            string[] YY = new string[] { "Y/Yo", "Δ/Y,Y/X" };
            comboBox4.Items.AddRange(YY);
        }
        //инициализация кабеля
        public Cabel[] Cabel()
        {

            Cabel cab1 = new Cabel { Sechenie = 2.5, Activnoe = 7.4, Reactivnoe = 0.116, AmperAir = 25, AmperZem = 33 };
            Cabel cab2 = new Cabel { Sechenie = 4.0, Activnoe = 4.63, Reactivnoe = 0.095, AmperAir = 33, AmperZem = 43 };
            Cabel cab3 = new Cabel { Sechenie = 6.0, Activnoe = 3.09, Reactivnoe = 0.09, AmperAir = 42, AmperZem = 54 };
            Cabel cab4 = new Cabel { Sechenie = 10.0, Activnoe = 1.84, Reactivnoe = 0.073, AmperAir = 58, AmperZem = 73 };
            Cabel cab5 = new Cabel { Sechenie = 16.0, Activnoe = 1.16, Reactivnoe = 0.0675, AmperAir = 78, AmperZem = 94 };
            Cabel cab6 = new Cabel { Sechenie = 25.0, Activnoe = 0.74, Reactivnoe = 0.0662, AmperAir = 104, AmperZem = 123 };
            Cabel cab7 = new Cabel { Sechenie = 35.0, Activnoe = 0.53, Reactivnoe = 0.0637, AmperAir = 127, AmperZem = 146 };
            Cabel cab8 = new Cabel { Sechenie = 50.0, Activnoe = 0.37, Reactivnoe = 0.0625, AmperAir = 155, AmperZem = 173 };
            Cabel cab9 = new Cabel { Sechenie = 70.0, Activnoe = 0.265, Reactivnoe = 0.0612, AmperAir = 196, AmperZem = 214 };
            Cabel cab10 = new Cabel { Sechenie = 95.0, Activnoe = 0.195, Reactivnoe = 0.0602, AmperAir = 242, AmperZem = 259 };
            Cabel cab11 = new Cabel { Sechenie = 120.0, Activnoe = 0.154, Reactivnoe = 0.0602, AmperAir = 280, AmperZem = 294 };
            Cabel cab12 = new Cabel { Sechenie = 150.0, Activnoe = 0.124, Reactivnoe = 0.0596, AmperAir = 321, AmperZem = 332 };
            Cabel cab13 = new Cabel { Sechenie = 185.0, Activnoe = 0.1, Reactivnoe = 0.0596, AmperAir = 369, AmperZem = 376 };
            Cabel cab14 = new Cabel { Sechenie = 240.0, Activnoe = 0.077, Reactivnoe = 0.0587, AmperAir = 438, AmperZem = 438 };
            Cabel[] cab = new Cabel[] { cab1, cab2, cab3, cab4, cab5, cab6, cab7, cab8, cab9, cab10, cab11, cab12, cab13, cab14 };
            return cab;

        }
        //названия кабелей
        public string[] Cabel_Name()
        {
            var s = Cabel();
            string[] name = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                name[i] = s[i].Sechenie.ToString();
            }
            return name;
        }
        //количество жил кабеля
        public string [] Kol_zhil()
        {
            string [] kol_vo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            return kol_vo;
        }



        // массив сопротивлений трансформатора
        public Resistance[] Val()
        {
            Resistance r1 = new Resistance { Power = 25, FirstPower_1 = "6-10", Resistance_YY = 1.036, Resistance_DYYX = 0.302 };
            Resistance r2 = new Resistance { Power = 40, FirstPower_1 = "6-10", Resistance_YY = 0.649, Resistance_DYYX = 0.187 };
            Resistance r3 = new Resistance { Power = 69, FirstPower_1 = "6-10", Resistance_YY = 0.412, Resistance_DYYX = 0.12 };
            Resistance r4 = new Resistance { Power = 100, FirstPower_1 = "6-10", Resistance_YY = 0.259, Resistance_DYYX = 0.0754 };
            Resistance r5 = new Resistance { Power = 160, FirstPower_1 = "6-10", Resistance_YY = 0.162, Resistance_DYYX = 0.047 };
            Resistance r6 = new Resistance { Power = 250, FirstPower_1 = "6-10", Resistance_YY = 0.104, Resistance_DYYX = 0.03 };
            Resistance r7 = new Resistance { Power = 400, FirstPower_1 = "6-10", Resistance_YY = 0.065, Resistance_DYYX = 0.019 };
            Resistance r8 = new Resistance { Power = 630, FirstPower_1 = "6-10", Resistance_YY = 0.043, Resistance_DYYX = 0.014 };
            Resistance[] res = new Resistance[] { r1, r2, r3, r4, r5, r6, r7, r8 };
            return res;
        }
        //массив названий  всех трансов
        public string[] NameKTP()
        {
            var ktp = Val();
            string[] nameKTP = new string[ktp.Length];
            for (int i = 0; i < ktp.Length; i++)
            {
                nameKTP[i] = ktp[i].Power.ToString();

            }
            return nameKTP;

        }



        //////////////////////////////////////////////////////////////////////////////////////расчёты значений//////////////////////////////////////////////////////////////////////
        
       
        /// ////////////////////////////////////// расчётная мощность (если не известна)
        public string Rl_1 { get; set; }//активное сопротивление линии, Ом до насоса
        public string Rk_1 { get; set; }//потери активной мощности в кабельной линии, кВт до насоса
        public string Rl_2 { get; set; }
        public string Rk_2 { get; set; }
        public string Rl_3 { get; set; }
        public string Rk_3 { get; set; }
        public void Power_1()
        {
            Raschet_Moshnosti ras = new Raschet_Moshnosti(textBox7.Text,textBox28.Text,textBox29.Text,textBox30.Text);
            label7.Text = Substring_Text(ras.RR.ToString());
            Rl_1= Substring_Text(ras.Rl.ToString());
            Rk_1 = Substring_Text(ras.Rk.ToString());
        }
        public void Power_2()
        {
            Raschet_Moshnosti ras = new Raschet_Moshnosti(textBox8.Text, textBox31.Text, textBox33.Text, textBox35.Text);
            label22.Text = Substring_Text(ras.RR.ToString());
            Rl_2 = Substring_Text(ras.Rl.ToString());
            Rk_2 = Substring_Text(ras.Rk.ToString());
        }
        public void Power_3()
        {
            Raschet_Moshnosti ras = new Raschet_Moshnosti(textBox9.Text, textBox32.Text, textBox34.Text, textBox36.Text);
            label31.Text = Substring_Text(ras.RR.ToString());
            Rl_3 = Substring_Text(ras.Rl.ToString());
            Rk_3 = Substring_Text(ras.Rk.ToString());
        }
        
        /// ///////////////////////////////////////////////////СУММА УСТАНОВЛЕННОЙ МОЩНОСТИ
        public void Ustan_Power_Sum()
        {
            if (textBox8.Text == "")
            {
                label124.Text = textBox7.Text;
            }
            else if (textBox8.Text != "" && textBox9.Text == "")
            {

                double p1 = Convert.ToDouble(textBox7.Text);
                double p2 = Convert.ToDouble(textBox8.Text);
                double sum = p1 + p2;
                label124.Text = sum.ToString();
            }
            else
            {
                double p1 = Convert.ToDouble(textBox7.Text);
                double p2 = Convert.ToDouble(textBox8.Text);
                double p3 = Convert.ToDouble(textBox9.Text);
                double sum = p1 + p2 + p3;
                label124.Text = sum.ToString();
            }
        }
       

        ////////////////////////////////////////////////////////////////максимальная мощность
        public void MaxPower_Raschet()
        {
           
            if (numericUpDown1.Value==1)
            {
                Max_Pow1();
            }
            else if(numericUpDown1.Value==2)
            {
                Max_Pow1();
                Max_Pow2();
            }
            else 
            {
                Max_Pow1();
                Max_Pow2();
                Max_Pow3();
            }

        }
        public void Max_Pow1()
        {
            double power = Convert.ToDouble(textBox7.Text);// установленная мощность
            double k_isp = Convert.ToDouble(textBox13.Text);// коэф использования
            double max_power = power * k_isp;
            label8.Text = max_power.ToString();
        }
        public void Max_Pow2()
        {
            double power2 = Convert.ToDouble(textBox8.Text);// установленная мощность
            double k_isp2 = Convert.ToDouble(textBox14.Text);// коэф использования
            double max_power2 = power2 * k_isp2;
            label21.Text = max_power2.ToString();
        }
        public void Max_Pow3()
        {
            double power3 = Convert.ToDouble(textBox9.Text);// установленная мощность
            double k_isp3 = Convert.ToDouble(textBox15.Text);// коэф использования
            double max_power3 = power3 * k_isp3;
            label30.Text = max_power3.ToString();
        }

        ///////////
        /////////////////////////////////////////////////////////////расчётный ток
        //////////
        public void Rasch_Amperage()
        {
            if (numericUpDown1.Value == 1)
            {
                Amper1();
            }
            else if (numericUpDown1.Value == 2)
            {
                Amper1();
                Amper2();
            }
            else
            {
                Amper1();
                Amper2();
                Amper3();
            }
        }

        public void Amper1()
        {
            double u = Convert.ToDouble(textBox4.Text);//напряжение
            double power = 0;/// расчётная мощность
            if (radioButton1.Checked)
            {
                power = Convert.ToDouble(textBox27.Text);
            }
            else
            {
                power = Convert.ToDouble(label7.Text);
            }
            
            double i = 0;//расчётный ток
            if (numericUpDown2.Value == 1)
            {
                i = power / u;
                label9.Text = Substring_Text(i.ToString());
            }
            else
            {
                i = power / (1.73 * u);
                label9.Text = Substring_Text(i.ToString());
            }
        }
        public void Amper2()
        {
            double u = Convert.ToDouble(textBox5.Text);//напряжение
            double power = 0;/// расчётная мощность
            if (radioButton3.Checked)
            {
                power = Convert.ToDouble(textBox26.Text);
            }
            else
            {
                power = Convert.ToDouble(label22.Text);
            }
            double i = 0;//расчётный ток
            if (numericUpDown3.Value == 1)
            {
                i = power / u;
                label20.Text = Substring_Text(i.ToString());
            }
            else
            {
                i = power / (1.73 * u);
                label20.Text = Substring_Text(i.ToString());
            }

        }
        public void Amper3()
        {
            double u = Convert.ToDouble(textBox6.Text);//напряжение
            double power = 0;/// расчётная мощность
            if (radioButton4.Checked)
            {
                power = Convert.ToDouble(textBox25.Text);
            }
            else
            {
                power = Convert.ToDouble(label31.Text);
            }
            double i = 0;//расчётный ток
            if (numericUpDown4.Value == 1)
            {
                i = power / u;
                label29.Text = Substring_Text(i.ToString());
            }
            else
            {
                i = power / (1.73 * u);
                label29.Text = Substring_Text(i.ToString());
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
        ///
        ///////////////////////////////////////////////////////////// тангенс 
        public void Rasch_Tg()
        {
            if (numericUpDown1.Value == 1)
            {
                Tg_1();
            }
            else if (numericUpDown1.Value == 2)
            {
                Tg_1();
                Tg_2();
            }
            else
            {
                Tg_1();
                Tg_2();
                Tg_3();
            }
        }
        public void Tg_1()
        {
            double cos = Convert.ToDouble(textBox10.Text);
            double tg = Math.Sqrt(1 - (Math.Pow(cos, 2))) / cos;
            label11.Text = Substring_Text(tg.ToString());
        }
        public void Tg_2()
        {
            double cos = Convert.ToDouble(textBox11.Text);
            double tg = Math.Sqrt(1 - (Math.Pow(cos, 2))) / cos;
            label18.Text = Substring_Text(tg.ToString());
        }
        public void Tg_3()
        {
            double cos = Convert.ToDouble(textBox12.Text);
            double tg = Math.Sqrt(1 - (Math.Pow(cos, 2))) / cos;
            label26.Text = Substring_Text(tg.ToString());
        }
       


        /// /////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////реактивная мощность
        public void Rasch_React_Power()
        {
            if (numericUpDown1.Value == 1)
            {
                React_Power1();
            }
            else if (numericUpDown1.Value == 2)
            {
                React_Power1();
                React_Power2();
                
            }
            else
            {
                React_Power1();
                React_Power2();
                React_Power3();
            }

        }

        public void React_Power1()
        {
            double power = 0;/// расчётная мощность
            if (radioButton1.Checked)
            {
                power = Convert.ToDouble(textBox27.Text);
            }
            else
            {
                power = Convert.ToDouble(label7.Text);
            }
            double tg = Convert.ToDouble(label11.Text);// расчётный тангенс
            double q = power * tg;
            label12.Text = Substring_Text(q.ToString());
        }
        public void React_Power2()
        {
            double power = 0;/// расчётная мощность
            if (radioButton3.Checked)
            {
                power = Convert.ToDouble(textBox26.Text);
            }
            else
            {
                power = Convert.ToDouble(label22.Text);
            }
            double tg = Convert.ToDouble(label18.Text);// расчётный тангенс
            double q = power * tg;
            label17.Text = Substring_Text(q.ToString());
        }
        public void React_Power3()
        {
            double power = 0;/// расчётная мощность
            if (radioButton4.Checked)
            {
                power = Convert.ToDouble(textBox25.Text);
            }
            else
            {
                power = Convert.ToDouble(label31.Text);
            }
            double tg = Convert.ToDouble(label26.Text);// расчётный тангенс
            double q = power * tg;
            label25.Text = Substring_Text(q.ToString());
        }
       
        ///////////////////////////////////////////////////////////////////полная мощность
        public void Rasch_Full_Power()
        {
            if (numericUpDown1.Value == 1)
            {
                Full_Power1();


            }
            else if (numericUpDown1.Value == 2)
            {
                Full_Power1();
                Full_Power2();


            }
            else
            {
                Full_Power1();
                Full_Power2();
                Full_Power3();
            }

        }
        public void Full_Power1()
        {
            double power = 0;/// расчётная мощность
            if (radioButton1.Checked)
            {
                power = Convert.ToDouble(textBox27.Text);
            }
            else
            {
                power = Convert.ToDouble(label7.Text);
            }
            double q = Convert.ToDouble(label12.Text);// руактивная мощность
            double full_power = Math.Sqrt((Math.Pow(power, 2) + Math.Pow(q, 2)));
            label13.Text = Substring_Text(full_power.ToString());
        }
        public void Full_Power2()
        {
            double power = 0;/// расчётная мощность
            if (radioButton3.Checked)
            {
                power = Convert.ToDouble(textBox26.Text);
            }
            else
            {
                power = Convert.ToDouble(label22.Text);
            }
            double q = Convert.ToDouble(label17.Text);// руактивная мощность
            double full_power = Math.Sqrt((Math.Pow(power, 2) + Math.Pow(q, 2)));
            label16.Text = Substring_Text(full_power.ToString());
        }
        public void Full_Power3()
        {
            double power = 0;/// расчётная мощность
            if (radioButton4.Checked)
            {
                power = Convert.ToDouble(textBox25.Text);
            }
            else
            {
                power = Convert.ToDouble(label31.Text);
            }
            double q = Convert.ToDouble(label25.Text);// руактивная мощность
            double full_power = Math.Sqrt((Math.Pow(power, 2) + Math.Pow(q, 2)));
            label24.Text = Substring_Text(full_power.ToString());
        }
        ///////////////////////////////////////////////////////////////////
        //сумма расчётной мощности
      ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// ///////////////////////////////////////////////cумма расчётной мощности
        /// </summary>
        public void Power_Sum()
        {
           
            if ( textBox26.Text=="")
            {
                label56.Text = Sum_1().ToString();
            }
            else if(textBox26.Text != ""&& textBox25.Text == "")
            {

                double p1 = Sum_1();
                double p2 = Sum_2();// расчётная мощность2
                double sum = p1 + p2;
                label56.Text = Substring_Text(sum.ToString());
            }
            else
            {
                double p1 = Sum_1();
                double p2 = Sum_2();// расчётная мощность2
                double p3 = Sum_3();// расчётная мощность3
                double sum = p1 + p2 + p3;
                label56.Text = Substring_Text(sum.ToString());
            }
            
        }


        public double Sum_1()
        {
            double p1 = 0;// расчётная мощность1
            if (radioButton1.Checked)
            {
               p1= Convert.ToDouble(textBox27.Text);
                return p1;
            }
            else
            {
                p1 = Convert.ToDouble(label7.Text);
                return p1;
            }

        }
        public double Sum_2()
        {
            double p2 = 0;// расчётная мощность2
            if (radioButton3.Checked)
            {
                p2 = Convert.ToDouble(textBox26.Text);
                return p2;
            }
            else
            {
                p2 = Convert.ToDouble(label22.Text);
                return p2;
            }

        }
        public double Sum_3()
        {
            double p3 = 0;// расчётная мощность2
            if (radioButton4.Checked)
            {
                p3 = Convert.ToDouble(textBox25.Text);
                return p3;
            }
            else
            {
                p3 = Convert.ToDouble(label31.Text);
                return p3;
            }

        }

        ////////////////////////////////////////////////////////////сумма максимальной мощности
        public void Max_Power_Sum()
        {
            if (label21.Text == "--")
            {
                label58.Text = label8.Text;
            }
            else if (label21.Text != "" && label30.Text == "--")
            {
                double mp1 = Convert.ToDouble(label8.Text);// макс мощность1
                double mp2 = Convert.ToDouble(label21.Text);// макс мощность2
                double sum = mp1 + mp2;
                label58.Text = Substring_Text(sum.ToString());
            }
            else
            {
                double mp1 = Convert.ToDouble(label8.Text);// макс мощность1
                double mp2 = Convert.ToDouble(label21.Text);// макс мощность2
                double mp3 = Convert.ToDouble(label21.Text);// макс мощность3
                double sum = mp1 + mp2+mp3;
                label58.Text = Substring_Text(sum.ToString());
            }
        }


        /// ///////////////////////////////////////////сумма реактивной мощности
        public void React_Power_Sum()
        {
            if (label17.Text == "--")
            {
                label59.Text = Substring_Text(label12.Text);
            }
            else if (label17.Text != "--" && label25.Text == "--")
            {
                double rp1 = Convert.ToDouble(label12.Text);// расчётная мощность1
                double rp2 = Convert.ToDouble(label17.Text);// расчётная мощность2
                double sum = rp1 + rp2;
                label59.Text = Substring_Text(sum.ToString());
            }
            else
            {
                double rp1 = Convert.ToDouble(label12.Text);// расчётная мощность1
                double rp2 = Convert.ToDouble(label17.Text);// расчётная мощность2
                double rp3 = Convert.ToDouble(label25.Text);// расчётная мощность2
                double sum = rp1 + rp2 + rp3;
                label59.Text = Substring_Text(sum.ToString());
            }

        }

       
        /// ////////////////////////////////////Сумма полной мощности
        public void Full_Power_Sum()
        {
            if (label16.Text == "--")
            {
                label60.Text = Substring_Text(label13.Text);
            }
            else if (label16.Text != "--" && label24.Text == "--")
            {
                double fp1 = Convert.ToDouble(label13.Text);// расчётная мощность1
                double fp2 = Convert.ToDouble(label16.Text);// расчётная мощность2
                double sum = fp1 + fp2;
                label60.Text = Substring_Text(sum.ToString());
            }
            else
            {
                double fp1 = Convert.ToDouble(label13.Text);// расчётная мощность1
                double fp2 = Convert.ToDouble(label16.Text);// расчётная мощность2
                double fp3 = Convert.ToDouble(label24.Text);// расчётная мощность2
                double sum = fp1 + fp2 + fp3;
                label60.Text = Substring_Text(sum.ToString());
            }
        }
       
        //////////////////////////////////////////////////ток на шинах РУ
        public void RU()
        {
            double sum_full_power = Convert.ToDouble(label60.Text);
            double tok = sum_full_power / (1.73 * 0.38);
            label44.Text = Substring_Text(tok.ToString());
        }
        
        /// ////////////////////загрузка трансформатора
        public void Zagruz_Trans()
        {
            double max_power = Convert.ToDouble(label58.Text);
            double power_trans = Convert.ToDouble(comboBox5.SelectedItem.ToString());
            double zagruz_trans = max_power / (power_trans * 0.95);
            label47.Text = Substring_Text(zagruz_trans.ToString());
        }
        

        
         /////////////////////////////////////токи кз
        public string Activ_Resist_Cab1 { get; set; }//Активное сопротивление кабеля1, Ом/км
        public string Inductiv_Resist_Cab1 { get; set; }//Индуктивное сопротивление кабеля1, Ом/км
        public string Full_Resist_Line1 { get; set; } //Полное сопротивление линии
        public string Resist_Trans { get; set; }//сопротивление трансформатора

        public void Toki_KZ()
        {

            if (numericUpDown1.Value == 1)
            {
                Tok_kz1();
            }
            else if (numericUpDown1.Value == 2)
            {
                Tok_kz1();
                Tok_kz2();
                

            }
            else
            {
                Tok_kz1();
                Tok_kz2();
                Tok_kz3();
            }
        }
        public void Tok_kz1()
        {
            string power_trans = comboBox5.SelectedItem.ToString(); //мощность
            string napregenie = textBox4.Text; //напряжение
            string sechenie_cabel = comboBox1.SelectedItem.ToString();//сечение
            string obmotki = comboBox4.SelectedItem.ToString();//обмотки
            string dlina_line = textBox22.Text;//длина линии
            decimal numeric = numericUpDown2.Value;// значение переключателя количества фаз
            Label kz_shiny = label46; // лейбл в форме тока кз на шинах
            Label kz = label49; //лейбл в форме тока кз в конце линии
            KZ_Rasch(power_trans, napregenie, sechenie_cabel, obmotki, dlina_line, numeric, kz_shiny, kz);
            double kf = Convert.ToDouble(label49.Text) / Convert.ToDouble(textBox40.Text);
            label113.Text = Substring_Text(kf.ToString());
        }
        public void Tok_kz2()
        {
            string power_trans2 = comboBox5.SelectedItem.ToString(); //мощность
            string napregenie2 = textBox5.Text; //напряжение
            string sechenie_cabel2 = comboBox2.SelectedItem.ToString();//сечение
            string obmotki2 = comboBox4.SelectedItem.ToString();//обмотки
            string dlina_line2 = textBox23.Text;//длина линии
            decimal numeric2 = numericUpDown3.Value;// значение переключателя количества фаз
            Label kz_shiny2 = label61; // лейбл в форме тока кз на шинах
            Label kz2 = label62; //лейбл в форме тока кз в конце линии
            KZ_Rasch(power_trans2, napregenie2, sechenie_cabel2, obmotki2, dlina_line2, numeric2, kz_shiny2, kz2);
            double kf = Convert.ToDouble(label62.Text) / Convert.ToDouble(textBox41.Text);
            label122.Text = Substring_Text(kf.ToString());
        }
        public void Tok_kz3()
        {
            string power_trans3 = comboBox5.SelectedItem.ToString(); //мощность
            string napregenie3 = textBox6.Text; //напряжение
            string sechenie_cabel3 = comboBox3.SelectedItem.ToString();//сечение
            string obmotki3 = comboBox4.SelectedItem.ToString();//обмотки
            string dlina_line3 = textBox24.Text;//длина линии
            decimal numeric3 = numericUpDown4.Value;// значение переключателя количества фаз
            Label kz_shiny3 = label63; // лейбл в форме тока кз на шинах
            Label kz3 = label64; //лейбл в форме тока кз в конце линии
            KZ_Rasch(power_trans3, napregenie3, sechenie_cabel3, obmotki3, dlina_line3, numeric3, kz_shiny3, kz3);
            double kf = Convert.ToDouble(label64.Text) / Convert.ToDouble(textBox42.Text);
            label123.Text = Substring_Text(kf.ToString());
        }
        public void KZ_Rasch(string power_trans,string napregenie,string sechenie_cabel,string obmotki,string dlina_line,decimal numericUpDown,
            Label kz_shiny, Label kz)
        {

                    double power = Convert.ToDouble(power_trans);// мощность транса кВа
                    Resistance trans = Val().FirstOrDefault(l => l.Power == Convert.ToInt32(power));// определение трансформатора
                    double u = Convert.ToDouble(napregenie)*1000;// напряжение
                    double sech_cabel = Convert.ToDouble(sechenie_cabel);// сечение кабеля
                    Cabel cabel = Cabel().FirstOrDefault(c=>c.Sechenie==sech_cabel);//кабель
                    string yy = obmotki;// обмотки 
                    double line = Convert.ToDouble(dlina_line);// длина линии
                    Label label_kz_na_shinah = kz_shiny;/// ток кз на шинах
                    Label label_kz = kz;/// ток кз в конце линии
                    Result_Toki_KZ(cabel, u, yy, trans, line, numericUpDown, label_kz_na_shinah, label_kz);
        }
        public void Result_Toki_KZ(Cabel cabel, double u, string yy, Resistance trans, double line,
            decimal numericUpDown, Label label_kz_na_shinah, Label label_kz)
        {
            Activ_Resist_Cab1 = cabel.Activnoe.ToString();
            Inductiv_Resist_Cab1 = cabel.Reactivnoe.ToString();

            double resistance = Math.Sqrt(Math.Pow((cabel.Activnoe * 0.001) * line, 2) + Math.Pow((cabel.Reactivnoe * 0.001) * line, 2));
            Full_Resist_Line1 = resistance.ToString();

            double resistance_ktp = 0; //сопротивление трансформатора



            if (numericUpDown == 1)
            {
                //1 фаза
                if (yy == "Y/Yo")
                {
                    resistance_ktp = trans.Resistance_YY;
                    Resist_Trans = resistance_ktp.ToString();
                    KZ(resistance_ktp, resistance, u, label_kz_na_shinah, label_kz);


                }
                else if (yy == "Δ/Y,Y/X")
                {
                    resistance_ktp = trans.Resistance_DYYX;
                    Resist_Trans = resistance_ktp.ToString();
                    MessageBox.Show(Resist_Trans);
                    KZ(resistance_ktp, resistance, u, label_kz_na_shinah, label_kz);

                }
                else
                {

                    KZ(resistance_ktp, resistance, u, label_kz_na_shinah, label_kz);
                }

            }

            else
            {

                ////три фазы
                if (yy == "Y/Yo")
                {
                    resistance_ktp = trans.Resistance_YY;
                    Resist_Trans = resistance_ktp.ToString();
                    KZ(resistance_ktp, resistance, u, label_kz_na_shinah, label_kz);

                }
                else if (yy == "Δ/Y,Y/X")
                {
                    resistance_ktp = trans.Resistance_DYYX;
                    Resist_Trans = resistance_ktp.ToString();
                    KZ(resistance_ktp, resistance, u, label_kz_na_shinah, label_kz);
                }
                else
                {
                    KZ(resistance_ktp, resistance, u, label_kz_na_shinah, label_kz);
                }


            }


        }
        //ток кз
        public void KZ(double resistance_ktp, double resistance, double u, Label kz_na_shinah, Label kz)
        {
            double i_kz = 0;// ток кз
            i_kz = u / (resistance_ktp + resistance);
            double i_kz_na_shinah = 380 / resistance_ktp;
            kz_na_shinah.Text = Substring_Text(i_kz_na_shinah.ToString());
            kz.Text = Substring_Text(i_kz.ToString());
        }

        //////////////////////////////////////////////потери напряжения
        public void Poteri()
        {
            
            string cos1 = "";//косинусы
            string cos2 = "";
            string cos3 = "";
            //установочные мощности
            string ustan_power = "";
            string ustan_power2 = "";
            string ustan_power3 = "";
            //длины линий
            string line = "";
            string line2 = "";
            string line3 = "";
            //реакт мощности
            string react_power = "";
            string react_power2 = "";
            string react_power3 = "";
            //фазные напряжения
            string u_faz = "";
            string u_faz2 = "";
            string u_faz3 = "";

            if (numericUpDown1.Value == 1)
            {
                Line_1(cos1,ustan_power,line,react_power,u_faz);


            }
            else if (numericUpDown1.Value == 2)
            {
                Line_1(cos1, ustan_power, line, react_power, u_faz);
                Line_2(cos2, ustan_power2, line2, react_power2, u_faz2);
            }
            else
            {
                Line_1(cos1, ustan_power, line, react_power, u_faz);
                Line_2(cos2, ustan_power2, line2, react_power2, u_faz2);
                Line_3(cos3, ustan_power3, line3, react_power3, u_faz3);

            }
        }
        //инициализация значений по линиям
        public void Line_1(string cos1,string ustan_power,string line,string react_power,string u_faz)
        {
            cos1 = textBox10.Text;
            Sin(cos1, label72);

            ustan_power = textBox7.Text;
            line = textBox22.Text;
            react_power = label12.Text;
            u_faz = textBox4.Text;
            Volt(ustan_power, line, react_power, u_faz, label76, label80);
        }
        public void Line_2(string cos2, string ustan_power2, string line2, string react_power2, string u_faz2)
        {
            cos2 = textBox11.Text;
            Sin(cos2, label73);

            ustan_power2 = textBox8.Text;
            line2 = textBox23.Text;
            react_power2 = label17.Text;
            u_faz2 = textBox5.Text;
            Volt(ustan_power2, line2, react_power2, u_faz2, label77, label81);
        }
        public void Line_3(string cos3, string ustan_power3, string line3, string react_power3, string u_faz3)
        {
            cos3 = textBox12.Text;
            Sin(cos3, label74);

            ustan_power3 = textBox9.Text;
            line3 = textBox24.Text;
            react_power3 = label25.Text;
            u_faz3 = textBox6.Text;
            Volt(ustan_power3, line3, react_power3, u_faz3, label78, label82);
        }
        //синус
        public void Sin(string cos,Label sin)
        {
            double cosin =Convert.ToDouble(cos);//КОСИНУС
            double sinus = Math.Sqrt(1 - Math.Pow(cosin, 2));
            sin.Text = Substring_Text(sinus.ToString());
        }
        //потери вольт
        public void Volt(string ustan_power,string line,string react_power,string u_faz,Label volt_label,Label percent)
        {
            double ust_power = Convert.ToDouble(ustan_power);//с4
            double sechenie_cabel = Convert.ToDouble(comboBox1.SelectedItem.ToString());//сечение
            var cabel= Cabel().FirstOrDefault(c => c.Sechenie == sechenie_cabel);//кабель
            double activ_resist = cabel.Activnoe;//активное сопротивление кабеля  с21
            double dlina = Convert.ToDouble(line);// длина линии c15
            double r_power = Convert.ToDouble(react_power);// реактивная мощность c11
            double induct_resist = cabel.Reactivnoe;//индуктивное сопротивление кабеля c22
            double u = Convert.ToDouble(u_faz);//фазное напряжение c2
            double volt = (((ust_power * 1000) * (activ_resist / 1000)) * dlina + (r_power * 1000) * (induct_resist / 1000) * dlina) / (u * 1000);
            volt_label.Text = Substring_Text(volt.ToString());
            Percent(volt, u, percent);
        }
        //потери процент
        public void Percent(double poteri_volt, double u, Label percent_label)
        {
            double percent = poteri_volt / ((1000 * u) / 100);
            percent_label.Text = Substring_Text(percent.ToString());
        }

        //////////////////////////////////////////////
        
      
        ///////////////////////////////////////////////термическая стойкость
        public void TermoStoykost()
        {
            string dlit = "";//длительно допуст ток
            string p_kf = "";//поправочный коэффициент
            string tem_grad = "";//Максимальная температура окружающей среды, град
            string temp_nagr = "";//Допустимое значение температуры нагрева жилы кабеля рабочим током ПУЭ п.1.3.11, град
            string norm_temp = "";//Нормированная температура окружающей среды (в земле), град
            string tok_max_power = "";//Длительно допустимый ток нагрузки при макcимальной температуре, А 
            string rasch_tok = "";//Расчетный ток Iр

            string dlit2 = "";//длительно допуст ток
            string p_kf2 = "";//поправочный коэффициент
            string tem_grad2 = "";//Максимальная температура окружающей среды, град
            string temp_nagr2 = "";//Допустимое значение температуры нагрева жилы кабеля рабочим током ПУЭ п.1.3.11, град
            string norm_temp2= "";//Нормированная температура окружающей среды (в земле), град
            string tok_max_power2 = "";//Длительно допустимый ток нагрузки при макcимальной температуре, А 
            string rasch_tok2 = "";//Расчетный ток Iр

            string dlit3 = "";//длительно допуст ток
            string p_kf3 = "";//поправочный коэффициент
            string tem_grad3 = "";//Максимальная температура окружающей среды, град
            string temp_nagr3 = "";//Допустимое значение температуры нагрева жилы кабеля рабочим током ПУЭ п.1.3.11, град
            string norm_temp3 = "";//Нормированная температура окружающей среды (в земле), град
            string tok_max_power3 = "";//Длительно допустимый ток нагрузки при макcимальной температуре, А 
            string rasch_tok3 = "";//Расчетный ток Iр

            if (numericUpDown1.Value == 1)
            {
                Line1(dlit, p_kf, tem_grad, temp_nagr, norm_temp, tok_max_power, rasch_tok);
            }
            else if (numericUpDown1.Value == 2)
            {
                Line1(dlit, p_kf, tem_grad, temp_nagr, norm_temp, tok_max_power, rasch_tok);
                Line2(dlit2, p_kf2, tem_grad2, temp_nagr2, norm_temp2, tok_max_power2, rasch_tok2);
            }
            else
            {
                Line1(dlit, p_kf, tem_grad, temp_nagr, norm_temp, tok_max_power, rasch_tok);
                Line2(dlit2, p_kf2, tem_grad2, temp_nagr2, norm_temp2, tok_max_power2, rasch_tok2);
                Line3(dlit3, p_kf3, tem_grad3, temp_nagr3, norm_temp3, tok_max_power3, rasch_tok3);

            }

        }
        //значния по линиям
        public void Line1(string dlit, string p_kf, string tem_grad, string temp_nagr, string norm_temp, string tok_max_power, string rasch_tok)
        {
            dlit = textBox19.Text;
            p_kf = textBox58.Text;
            Dlit_Tok_Max_Power(dlit, p_kf, label90);

            tem_grad = textBox52.Text;
            temp_nagr= textBox55.Text;
            norm_temp= textBox49.Text;
            tok_max_power = label90.Text;
            rasch_tok = label9.Text;
            Temp(tem_grad, temp_nagr, norm_temp, tok_max_power, rasch_tok, label93);
        }
        public void Line2(string dlit, string p_kf, string tem_grad, string temp_nagr, string norm_temp, string tok_max_power, string rasch_tok)
        {
            dlit = textBox20.Text;
            p_kf = textBox59.Text;
            Dlit_Tok_Max_Power(dlit, p_kf, label91);

            tem_grad = textBox53.Text;
            temp_nagr = textBox56.Text;
            norm_temp = textBox50.Text;
            tok_max_power = label91.Text;
            rasch_tok = label20.Text;
            Temp(tem_grad, temp_nagr, norm_temp, tok_max_power, rasch_tok, label94);
        }
        public void Line3(string dlit, string p_kf, string tem_grad, string temp_nagr, string norm_temp, string tok_max_power, string rasch_tok)
        {
            dlit = textBox21.Text;
            p_kf = textBox60.Text;
            Dlit_Tok_Max_Power(dlit, p_kf, label92);

            tem_grad = textBox54.Text;
            temp_nagr = textBox57.Text;
            norm_temp = textBox51.Text;
            tok_max_power = label92.Text;
            rasch_tok = label29.Text;
            Temp(tem_grad, temp_nagr, norm_temp, tok_max_power, rasch_tok, label95);
        }
        //длит допустимый ток при максим нагрузке
        public void Dlit_Tok_Max_Power(string dlit_tok, string popr_koef,Label label)
        {
            double tok=Convert.ToDouble(dlit_tok);
            double koef = Convert.ToDouble(popr_koef);
            double result = tok * koef;
            label.Text = Substring_Text(result.ToString());
        }
        //температура нагрева жилы
        public void Temp(string tem_grad,string temp_nagr,string norm_temp, string tok_max_power,string rasch_tok,Label label)
        {
            double temp = Convert.ToDouble(tem_grad);//  Максимальная температура окружающей среды, град
            double nagr = Convert.ToDouble(temp_nagr);//Допустимое значение температуры нагрева жилы кабеля рабочим током ПУЭ п.1.3.11, град
            double norm = Convert.ToDouble(norm_temp);//Нормированная температура окружающей среды (в земле), град
            double tok = Convert.ToDouble(tok_max_power);//Длительно допустимый ток нагрузки при макcимальной температуре, А  
            double ras_tok = Convert.ToDouble(rasch_tok);//Расчетный ток Iр
            double result = temp + ((nagr - norm) * (Math.Pow((ras_tok / tok), 2)));
            label.Text = Substring_Text(result.ToString());

        }


        /////////////////////////////////// Проверка кабеля на предельно допустимую температуру нагрева жилы током к.з. 

        public void Temp_Zhil()
        {
            string kz = "";//ток кз
            string vremya_protekania = "";//время протекания
            string med = "";//теплотехнические характеристики
            string sechenie = "";//сечение
            string temp_nagreva_zhil = ""; //температура нагрева жил

            if (numericUpDown1.Value == 1)
            {
                Line_1_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil);
            }
            else if (numericUpDown1.Value == 2)
            {
                Line_1_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil);
                Line_2_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil);
            }
            else
            {

                Line_1_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil);
                Line_2_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil);
                Line_3_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil);
            }

        }
        public void Line_1_Temp(string kz, string vremya_protekania, string med, string sechenie, string temp_nagreva_zhil)
        {
            kz = label49.Text;
            vremya_protekania = textBox46.Text;
            med = label98.Text;
            sechenie= comboBox1.SelectedItem.ToString();
            temp_nagreva_zhil = label93.Text;
            Rasch_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil, label100, label104, label108);
        }
        public void Line_2_Temp(string kz, string vremya_protekania, string med, string sechenie, string temp_nagreva_zhil)
        {
            kz = label62.Text;
            vremya_protekania = textBox47.Text;
            med = label98.Text;
            sechenie = comboBox2.SelectedItem.ToString();
            temp_nagreva_zhil = label94.Text;
            Rasch_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil, label101, label105, label109);
        }
        public void Line_3_Temp(string kz, string vremya_protekania, string med, string sechenie, string temp_nagreva_zhil)
        {
            kz = label64.Text;
            vremya_protekania = textBox48.Text;
            med = label98.Text;
            sechenie = comboBox3.SelectedItem.ToString();
            temp_nagreva_zhil = label95.Text;
            Rasch_Temp(kz, vremya_protekania, med, sechenie, temp_nagreva_zhil, label102, label106, label110);
        }
        public void Rasch_Temp(string kz,string vremya_protekania,string med,string sechenie,string temp_nagreva_zhil,Label label_1,Label label_2,Label label_3)
        {
            double tok_kz = Convert.ToDouble(kz);
            double vrem_protek = Convert.ToDouble(vremya_protekania);
            double tepl_impuls = Math.Pow((tok_kz / 1000), 2) * vrem_protek;
            label_1.Text = Substring_Text(tepl_impuls.ToString());//импульс
            double sech= Convert.ToDouble(sechenie);//сечение
            double med_1 = Convert.ToDouble(label98.Text);//теплофизхические хзарактеристики меди
            double K = (med_1 * tepl_impuls) / (Math.Pow(sech, 2));///Расчётный коэффициент К при заданном импульсе
            label_2.Text = Substring_Text(K.ToString());
            double temp_nagreva_zhily = Convert.ToDouble(temp_nagreva_zhil);
            double kon_temp_nagreva = (temp_nagreva_zhily * Math.Exp(K)) + 228 * (Math.Exp(K) - 1);
            label_3.Text = Substring_Text(kon_temp_nagreva.ToString());// Конечная температура нагрева жилы кабеля при к.з.
        }

       
        /// ////////////////////////////////////подбор УКРМ/////////////////////////
        public string Napr_kz { get; set; }//Напряжение К.З. в трансформаторе %
        public string Tok_xx { get; set; }//Ток х.х. %
        public string Poteri_XX_ { get; set; }//Потери х.х. в трасформаторе, кВт
        public string Poteri_kz_ { get; set; }//Потери к.з., кВт
        public void UKRM()
        {
            int powerKtp= Convert.ToInt32(comboBox5.SelectedItem);
            var massivKtp = ktpInizializer();
            var ktp = massivKtp.FirstOrDefault(n => n.Power == powerKtp);
            Napr_kz = ktp.Voltage.ToString();
            Tok_xx = ktp.Amperage.ToString();
            double loss_xx = Convert.ToDouble(ktp.Losses_XX) /Convert.ToDouble(1000);// потери холостого хода в трансформаторе
            Poteri_XX_ = loss_xx.ToString();
            double loss_kz = Convert.ToDouble(ktp.Losses_KZ) / Convert.ToDouble(1000);// потери тока к.з.
            Poteri_kz_ = loss_kz.ToString();
            double zagr_trans = Convert.ToDouble(label47.Text);//КОЭФ загрузки транса
            double loss_activ = loss_xx+ (loss_kz* (Math.Pow(zagr_trans, 2)));////Потери активной мощности в тр-ре, кВт
            label115.Text = Substring_Text(loss_activ.ToString());
            double full_power = Convert.ToDouble(label60.Text);//полная мощность
            double power = Convert.ToDouble(powerKtp);
            double loss_react = (power * ktp.Amperage / Convert.ToDouble(100)) + Math.Sqrt(Math.Pow(ktp.Voltage, 2) - Math.Pow((100 * loss_kz / power), 2)) * (Math.Pow(full_power, 2) / (100 * power));
            label117.Text = Substring_Text(loss_react.ToString());
            double react_pow = Convert.ToDouble(label59.Text);//реактивная суммарная мощность
            double rasch_pow = Convert.ToDouble(label56.Text);//расчётная суммарная мощность
            double tg = (loss_react + react_pow) / (loss_activ + rasch_pow);//тангенс расчётный
            label119.Text = Substring_Text(tg.ToString());
            double tg_treb = Convert.ToDouble(textBox61.Text);
            double power_ukrm = (loss_kz * (tg - tg_treb)) - (loss_activ * tg_treb) + loss_react;
            label121.Text = Substring_Text(power_ukrm.ToString());
        }


        /// ////////////////лэйбллинки///////////
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\длительнодопустимые токи.png");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\температура жил.jpg");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\поправочный коэффициент.jpg");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }

        //параметры ктп
        public KTP[] ktpInizializer()
        {
            KTP ktp25 = new KTP { Power = 25, Losses_XX = 125, Losses_KZ = 600, Voltage = 4.5, Amperage = 3.2 };
            KTP ktp40 = new KTP { Power = 40, Losses_XX = 180, Losses_KZ = 880, Voltage = 4.5, Amperage = 3.0 };
            KTP ktp63 = new KTP { Power = 69, Losses_XX = 265, Losses_KZ = 1280, Voltage = 4.5, Amperage = 2.8 };
            KTP ktp100 = new KTP { Power = 100, Losses_XX = 365, Losses_KZ = 1970, Voltage = 4.5, Amperage = 2.6 };
            KTP ktp160 = new KTP { Power = 160, Losses_XX = 540, Losses_KZ = 2650, Voltage = 4.5, Amperage = 2.4 };
            KTP ktp250 = new KTP { Power = 250, Losses_XX = 780, Losses_KZ = 3700, Voltage = 4.5, Amperage = 2.3 };
            KTP ktp400 = new KTP { Power = 400, Losses_XX = 1080, Losses_KZ = 5500, Voltage = 4.5, Amperage = 3.0 };
            KTP ktp630 = new KTP { Power = 630, Losses_XX = 1680, Losses_KZ = 7600, Voltage = 5.5, Amperage = 3.0 };
            KTP[] ktpmass = new KTP[] { ktp25, ktp40, ktp63, ktp100, ktp160, ktp250, ktp400, ktp630 };

            return ktpmass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MaxPower_Raschet();
                Rasch_Amperage();
                Rasch_Tg();
                Rasch_React_Power();
                Rasch_Full_Power();
                Power_Sum();
                Ustan_Power_Sum();
                Max_Power_Sum();
                React_Power_Sum();
                Full_Power_Sum();
                RU();
                Zagruz_Trans();
                Toki_KZ();
                Poteri();
                TermoStoykost();
                Temp_Zhil();
                UKRM();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных.\nПри вводе дробных чисел используйте символ ',' ");
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }


        //кнопки расчёта расчётной мощности

        private void button3_Click(object sender, EventArgs e)
        {
            Power_1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Power_2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Power_3();

        }

        //создание ворд-документа отчёта
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value == 1)
                {
                    Text_Insert_1();
                }
                else if (numericUpDown1.Value == 2)
                {
                    Text_Insert_1();
                    Text_Insert_2(Path);
                }
                else
                {
                    MessageBox.Show("Для 3-х и более линий используйте Excel расчёт");
                }
            }

            catch
            {
                MessageBox.Show("Ошибка создания документа .docx");
            }
        }
        //вставка текста для  первого электроприёмника
        public string Path { get; set; }//путь к файлу шаблона
       
        public void Text_Insert_1()
        {
            WordCreate word = new WordCreate();

            string file = Environment.CurrentDirectory;//путь к папке с программой

            string[] text_insert;// массив значений для записи
            string[] text_replace;// массив значений ,которые нужно заменить

            string nazvanie_elpriemnika = textBox1.Text;//наименование электроприемника
            string activ_power = textBox7.Text;// Установленная мощность паспортные данные
            string rr = "";//Расчетная активная мощность 
            string naprezhenie = textBox4.Text;//напряжение сети
            string kol_faz = numericUpDown2.Value.ToString();// количество фаз
            string sum_power_ustan = label124.Text;// СУММА установленной мощности
            string k_isp= textBox13.Text;//коэфф использования
            string rr_sum = label56.Text;//СУММА расчётной мощности
            string max_power = label8.Text;// МАКСИМ мощность
            string sum_max_pow = label58.Text;//сумма макс мощности
            string i_rasch = label9.Text;//расчётный ток
            string cos = textBox10.Text;//косинус
            string tg = label11.Text;//тангненс
            string react_power = label12.Text;//реактивн мощность
            string sum_react_power = label59.Text;// СУММА реакт мощности
            string sech_cabel = comboBox1.SelectedItem.ToString();//сечение кабеля
            string kolvo_zhil= comboBox6.SelectedItem.ToString();//количество жил кабеля
            string dop_tok = textBox19.Text;//длительный ток линии
            string marka = textBox16.Text;// марка кабеля
            string dlina_line = textBox22.Text;//ДЛИНА ЛИНИИ
            string full_power = label13.Text;//ПОЛНАЯ МОЩНОСТЬ
            string sum_full_power = label60.Text;// сумма полной мощности
            string power_trans= comboBox5.SelectedItem.ToString();//мощность трансформатора
            string tok_na_shinah_ru = label44.Text;//ТОК на шинах ру
            string zagruzka_transa = label47.Text;//загрузка трансформатора
            //токи кз
            string activ_cab = Activ_Resist_Cab1;//Активное сопротивление кабеля, Ом/км
            string reactiv_cabel = Inductiv_Resist_Cab1;//Индуктивное сопротивление кабеля, Ом/км
            string resist_line = Full_Resist_Line1;//полное сопротивление линии
            string resist_trans = Resist_Trans;//Сопротивление трансформатора, 0м
            string tok_kz_na_shinah= label46.Text;//ток кз на шинах 
            string tok_kz_v_konce_linii= label49.Text;//ток кз в конце линии
            string avtomat = textBox37.Text;//номинал автоматического выключателя
            string ustavki = textBox40.Text;// уставки 
            string k_chuv = label113.Text;//коэффициент чувствительности
            string vremya = textBox46.Text;//время защитного отключения
            //потери напряжения
            string sin = label72.Text;//СИНУС
            string poteri_volt = label76.Text;// ПОТЕРИ вольт
            string poteri_percent = label80.Text;//ПОТЕР процент
            //термическая стойкость
            string sech_term= sech_cabel;//сечение кабеля для терм стойкости
            string norm_temp_v_zemle = textBox49.Text;//ТЕМПЕРАТУРА В ЗЕМЛЕ
            string max_temp = textBox52.Text;//максимальная температура окр среды
            string dopust_temper = textBox55.Text;//ДОПУСТИМОЕ значение температуры нагревы жилы
            string dlit_tok_nagr = dop_tok;//длит ток для терм стойкости
            string popr_kf = textBox58.Text;// ПОПРАВОЧНЫЙ КОЭФФИЦИЕНТ табл пуэ
            string dlit_tok_pri_max = label90.Text;//Длительно допустимый ток нагрузки при макcимальной температуре, А
            string temp_nagr_zhily = label93.Text;//Температура нагрева жилы кабеля рабочим током, град
            //Проверка кабеля на предельно допустимую температуру нагрева жилы током к.з.
            string med_khar = label98.Text;//Теплофизические характеристики материала проводника b, мм4/(кА2с), (для меди)
            string vrem_prot = vremya;//время протекания тока
            string tepl_impuls = label100.Text;//ТЕПЛОВОЙ импульс
            string k_umpuls = label104.Text;//Расчётный коэффициент К при заданном импульсе
            string konech_temp = label108.Text;//Конечная температура нагрева жилы кабеля при к.з.
            ///УКРМ
            string napr_kz = Napr_kz;//Напряжение К.З. в трансформаторе %
            string xx_tok = Tok_xx;//Ток х.х. %
            string poteri_xx = Poteri_XX_;//Потери х.х. в трасформаторе, кВт
            string poteri_kz = Poteri_kz_;//Потери к.з., кВт
            string tg_UKRM = textBox61.Text;//Необходимый tg ϕ
            string poteri_act_power = label115.Text;//Потери активной мощности в тр-ре, кВт
            string poteri_react_power = label117.Text;//Потери реактивной мощности в тр-ре, кВар
            string rasch_tg = label119.Text;//Расчетный tg ϕ
            string nom_pow_ukrm = label121.Text;//Номинальная мощность УКРМ






            if (radioButton2.Checked)
            {
                string path =file+ @"\1 насос расчёт.docx"; //исходный шаблон
                string newPath = @"D:\1 насос расчёт.docx"; // копия шаблона с расчётными значениями
                Path = newPath;

                if (numericUpDown1.Value == 2 && radioButton5.Checked)
                {
                    path = file + @"\2 насоса расчёт.docx"; //исходный шаблон
                    newPath = @"D:\2 насоса расчёт.docx"; // копия шаблона с расчётными значениями
                    Path = newPath;
                }
                else if (numericUpDown1.Value==2 &&radioButton3.Checked)
                {
                    path = file + @"\1 насос и 2 колонки в таблице.docx"; //исходный шаблон
                    newPath = @"D:\1 насос и 2 колонки в таблице.docx"; // копия шаблона с расчётными значениями
                    Path = newPath;
                }


                string i_nasos = textBox28.Text;// ток насоса
                string dlina = textBox29.Text;//длина линии до насоса
                string sechen = textBox30.Text;//сечение кабеля до насоса
                string rl = Rl_1;//активное сопротивление линии до насоса, Ом
                string rk = Rk_1;//потери активной мощности в кабельной линии до насоса, кВт;
                rr = label7.Text;//Расчетная активная мощность 
               text_insert = new string[] { nom_pow_ukrm,rasch_tg,poteri_react_power,poteri_act_power,tg_UKRM,poteri_kz,poteri_xx,xx_tok,napr_kz,konech_temp,k_umpuls,tepl_impuls,vrem_prot,med_khar,temp_nagr_zhily,dlit_tok_pri_max,popr_kf,
               dlit_tok_nagr,dopust_temper,max_temp,norm_temp_v_zemle,sech_term,poteri_percent,poteri_volt,sin,vremya,k_chuv,ustavki,avtomat,tok_kz_v_konce_linii,tok_kz_na_shinah,resist_trans,resist_line,reactiv_cabel,activ_cab,zagruzka_transa,
               tok_na_shinah_ru,power_trans, full_power,sum_full_power,dlina_line,marka,dop_tok,sech_cabel,kolvo_zhil,react_power,sum_react_power,tg,cos,i_rasch,max_power,sum_max_pow,rr,rr_sum,k_isp,activ_power,sum_power_ustan,kol_faz,naprezhenie,rr,rk,rl,
               sechen,dlina,i_nasos,activ_power,nazvanie_elpriemnika};
                
                text_replace = new string[] { "7_9", "7_8", "7_7", "7_6", "7_5", "7_4", "7_3", "7_2", "7_1", "6_9", "6_8","6_7","6_6","6_5","6_4","6_3","6_2","6_1","5_9","5_8","5_7","5_6","5_4","5_3","5_2","5_1","4_9","4_8","4_7",
                "4_6","4_5","4_4","4_3","4_2","4_1","3_9","3_8","3_7","3_6","full","3_5","3_4","3_3","3_2","3_1","2_9","two","2_8","2_7","2_6","2_5","sev","2_4","sal","2_3","2_2","fav","2_1","teen","1_8","1_7","1_6",
                "1_5","1_4","1_3","1_2","1_1"};

                MessageBox.Show(word.Rasch_oborud_1(path, newPath, text_insert, text_replace));
            }
            else
            {
                string path =""; 
                string newPath = ""; 
                Path = newPath;

                if (numericUpDown1.Value == 2 && radioButton3.Checked)
                {
                    path = file + @"\2 насоса характеристика сети.docx"; 
                    newPath = @"D:\2 насоса характеристика сети.docx"; 
                    Path = newPath;


                  
                }

                /////////////////////
                else if(radioButton1.Checked&&radioButton5.Checked)
                {
                    path = file + @"\1 насос второй стобец и 2 колонки в таблице .docx"; 
                    newPath = @"D:\1 насос второй стобец и 2 колонки в таблице .docx"; 
                    Path = newPath;

                }
                else
                {
                    path = file + @"\1 насос характеристика сети.docx";
                    newPath = @"D:\1 насос характеристика сети.docx";
                    Path = newPath;
                }

                //////////////
                 rr = textBox27.Text;

                text_insert = new string[] { nom_pow_ukrm,rasch_tg,poteri_react_power,poteri_act_power,tg_UKRM,poteri_kz,poteri_xx,xx_tok,napr_kz,konech_temp,k_umpuls,tepl_impuls,vrem_prot,med_khar,temp_nagr_zhily,dlit_tok_pri_max,popr_kf,
               dlit_tok_nagr,dopust_temper,max_temp,norm_temp_v_zemle,sech_term,poteri_percent,poteri_volt,sin,vremya,k_chuv,ustavki,avtomat,tok_kz_v_konce_linii,tok_kz_na_shinah,resist_trans,resist_line,reactiv_cabel,activ_cab,zagruzka_transa,
               tok_na_shinah_ru,power_trans, full_power,sum_full_power,dlina_line,marka,dop_tok,sech_cabel,kolvo_zhil,react_power,sum_react_power,tg,cos,i_rasch,max_power,sum_max_pow,rr,rr_sum,k_isp,activ_power,sum_power_ustan,kol_faz,naprezhenie,rr,
               activ_power,nazvanie_elpriemnika};

                text_replace = new string[] { "7_9", "7_8", "7_7", "7_6", "7_5", "7_4", "7_3", "7_2", "7_1", "6_9", "6_8","6_7","6_6","6_5","6_4","6_3","6_2","6_1","5_9","5_8","5_7","5_6","5_4","5_3","5_2","5_1","4_9","4_8","4_7",
                "4_6","4_5","4_4","4_3","4_2","4_1","3_9","3_8","3_7","3_6","full","3_5","3_4","3_3","3_2","3_1","2_9","two","2_8","2_7","2_6","2_5","sev","2_4","sal","2_3","2_2","fav","2_1","teen","1_8",
                "1_2","1_1"};

                MessageBox.Show(word.Rasch_oborud_1(path, newPath, text_insert, text_replace));



            }
            
            
        }
        ///вставка текста для второго электроприёмника
        public void Text_Insert_2(string path)
        {

            WordCreate word = new WordCreate();

            string file = Environment.CurrentDirectory;//путь к папке с программой

            string[] text_insert;// массив значений для записи
            string[] text_replace;// массив значений ,которые нужно заменить

            string nazvanie_elpriemnika = textBox2.Text;//наименование электроприемника
            string activ_power = textBox8.Text;// Установленная мощность паспортные данные
            string rr = "";//Расчетная активная мощность 
            string naprezhenie = textBox5.Text;//напряжение сети
            string kol_faz = numericUpDown3.Value.ToString();// количество фаз

            string k_isp = textBox14.Text;//коэфф использования

            string max_power = label21.Text;// МАКСИМ мощность

            string i_rasch = label20.Text;//расчётный ток
            string cos = textBox11.Text;//косинус
            string tg = label18.Text;//тангненс
            string react_power = label17.Text;//реактивн мощность

            string sech_cabel = comboBox2.SelectedItem.ToString();//сечение кабеля
            string kolvo_zhil = comboBox7.SelectedItem.ToString();//количество жил кабеля
            string dop_tok = textBox20.Text;//длительный ток линии
            string marka = textBox17.Text;// марка кабеля
            string dlina_line = textBox23.Text;//ДЛИНА ЛИНИИ
            string full_power = label16.Text;//ПОЛНАЯ МОЩНОСТЬ



            //токи кз
            string activ_cab = Activ_Resist_Cab1;//Активное сопротивление кабеля, Ом/км
            string reactiv_cabel = Inductiv_Resist_Cab1;//Индуктивное сопротивление кабеля, Ом/км
            string resist_line = Full_Resist_Line1;//полное сопротивление линии
            string resist_trans = Resist_Trans;//Сопротивление трансформатора, 0м
            string tok_kz_na_shinah = label61.Text;//ток кз на шинах 
            string tok_kz_v_konce_linii = label62.Text;//ток кз в конце линии
            string avtomat = textBox38.Text;//номинал автоматического выключателя
            string ustavki = textBox41.Text;// уставки 
            string k_chuv = label122.Text;//коэффициент чувствительности
            string vremya = textBox47.Text;//время защитного отключения
            //потери напряжения
            string sin = label73.Text;//СИНУС
            string poteri_volt = label77.Text;// ПОТЕРИ вольт
            string poteri_percent = label81.Text;//ПОТЕР процент
            //термическая стойкость
            string sech_term = sech_cabel;//сечение кабеля для терм стойкости
            string norm_temp_v_zemle = textBox50.Text;//ТЕМПЕРАТУРА В ЗЕМЛЕ
            string max_temp = textBox53.Text;//максимальная температура окр среды
            string dopust_temper = textBox56.Text;//ДОПУСТИМОЕ значение температуры нагревы жилы
            string dlit_tok_nagr = dop_tok;//длит ток для терм стойкости
            string popr_kf = textBox59.Text;// ПОПРАВОЧНЫЙ КОЭФФИЦИЕНТ табл пуэ
            string dlit_tok_pri_max = label91.Text;//Длительно допустимый ток нагрузки при макcимальной температуре, А
            string temp_nagr_zhily = label94.Text;//Температура нагрева жилы кабеля рабочим током, град
            //Проверка кабеля на предельно допустимую температуру нагрева жилы током к.з.
            string med_khar = label98.Text;//Теплофизические характеристики материала проводника b, мм4/(кА2с), (для меди)
            string vrem_prot = vremya;//время протекания тока
            string tepl_impuls = label101.Text;//ТЕПЛОВОЙ импульс
            string k_umpuls = label105.Text;//Расчётный коэффициент К при заданном импульсе
            string konech_temp = label109.Text;//Конечная температура нагрева жилы кабеля при к.з.




            


             if (radioButton5.Checked)
            {


                string i_nasos = textBox31.Text;// ток насоса
                string dlina = textBox33.Text;//длина линии до насоса
                string sechen = textBox35.Text;//сечение кабеля до насоса
                string rl = Rl_2;//активное сопротивление линии до насоса, Ом
                string rk = Rk_2;//потери активной мощности в кабельной линии до насоса, кВт;
                rr = label22.Text;//Расчетная активная мощность 
                //
                text_insert = new string[] { konech_temp,k_umpuls,tepl_impuls,vrem_prot,med_khar,temp_nagr_zhily,dlit_tok_pri_max,popr_kf,dlit_tok_nagr,dopust_temper,max_temp,norm_temp_v_zemle,sech_term,
                poteri_percent,poteri_volt,sin,vremya,k_chuv,ustavki,avtomat,tok_kz_v_konce_linii,tok_kz_na_shinah,resist_line,reactiv_cabel,activ_cab,full_power,dlina_line,marka,dop_tok,kolvo_zhil,sech_cabel,
                react_power,tg,cos,i_rasch,max_power,rr,k_isp,activ_power,kol_faz,naprezhenie,rr,rk,rl,sechen,dlina,i_nasos,activ_power,nazvanie_elpriemnika};

                text_replace = new string[] { "ggg", "onehundredandone", "onehundred", "ninetynine", "ninetyeight", "eee" , "ninetysix", "ninetyfive", "ninetyfour", "ninetythree", "qqq", "ninetyone", "ninety",
                "eightynine","eightyeight","fff","eightysix","eightyfive","eightyfour","eightythree","sss","eightyone","eighty","bbb","aaa","ccc","vvv","uuu","nnn","ooo",
                "jdb","xxx","ppp","mmm","sixtynine","sixtyeight","kkl","sixtysix","sixtyfive","sixtyfour","sixtythree","eigth","jjb","sixth","five","foure","three","second","first"};

                MessageBox.Show(word.Rasch_oborud_2(path, text_insert, text_replace));

            }

            else
            {

                rr = textBox26.Text;

                text_insert = new string[] { konech_temp,k_umpuls,tepl_impuls,vrem_prot,med_khar,temp_nagr_zhily,dlit_tok_pri_max,popr_kf,dlit_tok_nagr,dopust_temper,max_temp,norm_temp_v_zemle,sech_term,
                poteri_percent,poteri_volt,sin,vremya,k_chuv,ustavki,avtomat,tok_kz_v_konce_linii,tok_kz_na_shinah,resist_line,reactiv_cabel,activ_cab,full_power,dlina_line,marka,dop_tok,kolvo_zhil,sech_cabel,
                react_power,tg,cos,i_rasch,max_power,rr,k_isp,activ_power,kol_faz,naprezhenie,nazvanie_elpriemnika};

                text_replace = new string[] { "ggg", "onehundredandone", "onehundred", "ninetynine", "ninetyeight", "eee" , "ninetysix", "ninetyfive", "ninetyfour", "ninetythree", "qqq", "ninetyone", "ninety",
                "eightynine","eightyeight","fff","eightysix","eightyfive","eightyfour","eightythree","sss","eightyone","eighty","bbb","aaa","ccc","vvv","uuu","nnn","ooo",
                "jdb","xxx","ppp","mmm","sixtynine","sixtyeight","kkl","sixtysix","sixtyfive","sixtyfour","sixtythree","first"};


                MessageBox.Show(word.Rasch_oborud_2(path, text_insert, text_replace));




            }


        }


    }
}
