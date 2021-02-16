using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universal_calculate
{
    public partial class Mech : Form
    {
        public Mech()
        {
            
                InitializeComponent();
                var mass = Cabel_Name();
                comboBox1.Items.AddRange(mass);
                var listKtp = NameKTP();
                comboBox2.Items.AddRange(listKtp);
                label4.Visible = false;
                label15.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label12.Visible = false;
                label14.Visible = false;
                label3.Visible = false;
                label11.Visible = false;
                label14.Visible = false;
                comboBox4.Visible = false;
                comboBox2.Visible = false;
                radioButton3.Click += radioButton3_Click;
                radioButton4.Click += radioButton4_Click;
                comboBox2.SelectionChangeCommitted += KtpEvent;
           
           
            
        }
        public void radioButton3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            comboBox2.Visible = true;
            label4.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            comboBox4.Visible = true;

        }
        public void KtpEvent(object sender, EventArgs e)
        {
            int power = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            var ktp = Val().FirstOrDefault(l => l.Power == power);
            string firstPower_1 = ktp.FirstPower_1.ToString();
            string[] YY = new string[] { "Y/Yo", "Δ/Y,Y/X" };
            comboBox4.Items.AddRange(YY);
        }
      


        public void radioButton4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            comboBox2.Visible = false;
            label4.Visible = false;
            comboBox4.Visible = false;
            label11.Visible = false;
            label15.Visible = false;
        }
        //инициализация кабеля
        public  Cabel[] Cabel()
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
            Cabel cab10 = new Cabel { Sechenie = 95.0, Activnoe = 0.195, Reactivnoe =0.0602, AmperAir = 242, AmperZem = 259 };
            Cabel cab11 = new Cabel { Sechenie = 120.0, Activnoe = 0.154, Reactivnoe = 0.0602, AmperAir = 280, AmperZem = 294 };
            Cabel cab12 = new Cabel { Sechenie = 150.0, Activnoe = 0.124, Reactivnoe = 0.0596, AmperAir = 321, AmperZem = 332 };
            Cabel cab13 = new Cabel { Sechenie = 185.0, Activnoe = 0.1, Reactivnoe = 0.0596, AmperAir = 369, AmperZem = 376 };
            Cabel cab14 = new Cabel { Sechenie = 240.0, Activnoe = 0.077, Reactivnoe = 0.0587, AmperAir = 438, AmperZem = 438 };
            Cabel[] cab = new Cabel[] { cab1,cab2,cab3,cab4,cab5,cab6,cab7,cab8,cab9,cab10,cab11,cab12,cab13,cab14};
            return cab;

        }
        //названия кабелей
        public string [] Cabel_Name()
        {
            var s = Cabel();
            string[] name = new string[s.Length];
           for(int i=0;i<s.Length;i++)
            {
                name[i] = s[i].Sechenie.ToString();
            }
            return name;
        }
       
     
       
        // массив сопротивлений трансформатора
        public Resistance[] Val()
        {
            Resistance r1 = new Resistance { Power = 25, FirstPower_1 = "6-10", Resistance_YY = 1.036, Resistance_DYYX = 0.302 };
            Resistance r2 = new Resistance { Power = 40, FirstPower_1 = "6-10", Resistance_YY = 0.649, Resistance_DYYX = 0.187 };
            Resistance r3 = new Resistance { Power = 69, FirstPower_1 = "6-10",  Resistance_YY = 0.412, Resistance_DYYX = 0.12 };
            Resistance r4 = new Resistance { Power = 100, FirstPower_1 = "6-10",  Resistance_YY = 0.259, Resistance_DYYX = 0.0754 };
            Resistance r5 = new Resistance { Power = 160, FirstPower_1 = "6-10",  Resistance_YY = 0.162, Resistance_DYYX = 0.047 };
            Resistance r6 = new Resistance { Power = 250, FirstPower_1 = "6-10",  Resistance_YY = 0.104, Resistance_DYYX = 0.03 };
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
       

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton3.Checked == true)
                {
                    var power = Convert.ToDouble(comboBox2.SelectedItem.ToString());// мощность транса кВа
                    Resistance trans = Val().FirstOrDefault(l => l.Power == power);// определение трансформатора
                    double u = Convert.ToDouble(textBox2.Text);// напряжение
                    var cabel = SelectCabel();//кабель
                    string yy = comboBox4.SelectedItem.ToString();// обмотки 
                    Result(cabel,u,yy,trans);
                    
                  
                }
                else
                {
                    double u = Convert.ToDouble(textBox2.Text);// напряжение
                    var cabel = SelectCabel();//кабель
                    string yy = "";
                    Resistance trans = null;
                    Result(cabel, u, yy,trans);

                }
                
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");

            }
            
           
        }
        public Cabel SelectCabel()
        {
            var selectNameCabel = comboBox1.SelectedItem.ToString();
            Cabel select = new Cabel();
            var cab = Cabel();
            foreach (var s in cab)
            {
                var sech = s.Sechenie.ToString();
                if (selectNameCabel == sech)
                {
                    select = s;
                }
            }
            return select;
           
        }
        public void Result(Cabel cabel,double u,string yy,Resistance trans)
        {
            
            
            double line = Convert.ToDouble(textBox3.Text);// длина линии

            double resistance = Math.Sqrt(Math.Pow((cabel.Activnoe * 0.001)*line,2)+ Math.Pow((cabel.Reactivnoe * 0.001) * line, 2));
            double resistance_ktp = 0; //сопротивление трансформатора



            if (radioButton1.Checked == true)
            {
                //1 фаза
                if (yy == "Y/Yo")
                {
                    resistance_ktp = trans.Resistance_YY;
                    KZ(resistance_ktp, resistance, u);


                }
                else if (yy == "Δ/Y,Y/X")
                {
                    resistance_ktp = trans.Resistance_DYYX;
                    KZ(resistance_ktp, resistance, u);

                }
                else
                {

                    KZ(resistance_ktp, resistance, u);
                }

            }

            else
            {

                ////три фазы
                if (yy == "Y/Yo")
                {
                    resistance_ktp = trans.Resistance_YY;
                    KZ(resistance_ktp, resistance, u);

                }
                else if (yy == "Δ/Y,Y/X")
                {
                    resistance_ktp = trans.Resistance_DYYX;
                    KZ(resistance_ktp, resistance, u); ;
                }
                else
                {
                    KZ(resistance_ktp, resistance, u);
                }


            }


        }
        //ток кз
        public void KZ(double resistance_ktp, double resistance,double u)
        {
            double i_kz = 0;// ток кз
            double i_nach = Convert.ToDouble(textBox1.Text);//начальный ток
            i_kz = u / (resistance_ktp + resistance);
            i_kz += i_nach;
            LabelFunc(i_kz);
        }
        
        //ВЫВОД РЕЗУЛЬТАТА
        public void LabelFunc(double x)
        {
            
            double itog = Math.Round(x, 2);
            string result = itog.ToString();
            Label_text(result);

        }
        public void Label_text(string result)
        {
            
            label9.Visible = true;
            label10.Visible = true;
            label12.Text = result;
            label12.Visible = true;
            label14.Visible = true;
        }
        ////инициализация ктп
        //public KTP[] ktpInizializer()
        //{
        //    KTP ktp25 = new KTP { Power = 25, Losses_XX = 125, Losses_KZ = 600, Voltage = 4.5, Amperage = 3.2 };
        //    KTP ktp40 = new KTP { Power = 40, Losses_XX = 180, Losses_KZ = 880, Voltage = 4.5, Amperage = 3.0 };
        //    KTP ktp63 = new KTP { Power = 63, Losses_XX = 265, Losses_KZ = 1280, Voltage = 4.5, Amperage = 2.8 };
        //    KTP ktp100 = new KTP { Power = 100, Losses_XX = 365, Losses_KZ = 1970, Voltage = 4.5, Amperage = 2.6 };
        //    KTP ktp160 = new KTP { Power = 160, Losses_XX = 540, Losses_KZ = 2650, Voltage = 4.5, Amperage = 2.4 };
        //    KTP ktp250 = new KTP { Power = 250, Losses_XX = 780, Losses_KZ = 3700, Voltage = 4.5, Amperage = 2.3 };
        //    KTP ktp400 = new KTP { Power = 400, Losses_XX = 1080, Losses_KZ = 5500, Voltage = 4.5, Amperage = 3.0 };
        //    KTP ktp630 = new KTP { Power = 630, Losses_XX = 1680, Losses_KZ = 7600, Voltage = 5.5, Amperage = 3.0 };
        //    KTP[] ktpmass = new KTP[] { ktp25, ktp40, ktp63, ktp100, ktp160, ktp250, ktp400, ktp630 };

        //    return ktpmass;
        //}
        ////массив имён  всех ктп
        //public string[] NameKTP()
        //{
        //    var ktp = ktpInizializer();
        //    string[] nameKTP = new string[ktp.Length];
        //    for (int i = 0; i < ktp.Length; i++)
        //    {
        //        nameKTP[i] = ktp[i].Power.ToString();

        //    }
        //    return nameKTP;

        //}
    }
}
