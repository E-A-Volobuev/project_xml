using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universal_calculate
{
    public partial class CreateOL : Form
    {
        public CreateOL()
        {
            InitializeComponent();
            string[] name = new string[] { "Ритэк", "ПреображенскНефть" };
            comboBox1.Items.AddRange(name);
            string [] ktp = new string[] { "25", "40","69","100","160","250","400","630"};
            comboBox2.Items.AddRange(ktp);
            string[] line = new string[] { "Воздух-кабель", "Земля-кабель" };
            comboBox3.Items.AddRange(line);
            string[] typeObm = new string[] { "Y/Yo", "Δ/Y-11", "Y/Δ-11", "Y/X-11" };
            comboBox4.Items.AddRange(typeObm);
            label10.Visible = false;
            textBox4.Visible = false;
            string[] pkt= new string[] { "ВНАП-10/400-20зп(с ПКТ-101-6-8-20-У3)", "ВНАП-10/400-20зп(с ПКТ-101-10-16-31,5-У3)", "ВНАП-10/400-20зп(с ПКТ-101-6-31,5-31,5-У3)",
                "ВНАП-10/400-20зп(с ПКТ-101-10-20-31,5-У3)","ВНАП-10/630-20зп(с ПКТ-101-10-50-31,5-У3)" };
            comboBox5.Items.AddRange(pkt);
            radioButton1.Click += radioButton1_Click;
            comboBox5.SelectionChangeCommitted += ComboEvent;
            label12.Visible = false;
            textBox5.Visible = false;
            string[] opn = new string[] {  "ОПНп-6/7,2/10/1 УХЛ1", "ОПН-РВ/TEL-10/12,6 УХЛ1", "ОПН-РС 6/7,6 УХЛ1" };
            radioButton4.Click += radioButton4_Click;
            comboBox6.Items.AddRange(opn);
            comboBox6.SelectionChangeCommitted += ComboEvent2;



        }
        public void radioButton1_Click(object sender, EventArgs e)
        {
            
            label10.Visible = true;
            textBox4.Visible = true;
            
        }
        public void radioButton4_Click(object sender, EventArgs e)
        {

            label12.Visible = true;
            textBox5.Visible = true;

        }
        public void ComboEvent(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            label10.Visible = false;
            textBox4.Visible = false;
        }
        public void ComboEvent2(object sender, EventArgs e)
        {
            radioButton4.Checked = false;
            label12.Visible = false;
            textBox5.Visible = false;
        }

        public void CreateDoc()
        {
            try
            {
                string file = Environment.CurrentDirectory;//путь к папке с программой

                string currentOl = comboBox1.SelectedItem.ToString();//наименование заказчика
                string path = "";
                string newPath = "";
                if (currentOl == "Ритэк")
                {
                    path = file + @"\Ол ктп Ритек.docx"; //исходный шаблон
                    newPath = @"D:\Ол ктп Ритек.docx"; // копия шаблона с расчётными значениями
                }
                else
                {
                    path = file + @"\Ол ктп Преображенскнефть.docx"; //исходный шаблон
                    newPath = @"D:\Ол ктп Преображенскнефть.docx"; // копия шаблона с расчётными значениями
                }
                ////данные с формы

                string nameKtp = textBox12.Text;// НАЗВАНИЕ КТП
                string powerKTP = comboBox2.SelectedItem.ToString();//мощность КТП
                string colich = numericUpDown1.Value.ToString();//КОЛИЧЕСТВО
                string mesto = textBox1.Text;// МЕСТО УСТАНОВКИ
                string napryazh = textBox2.Text;// НАПРЯЖЕНИЕ
                string isp_vvoda = comboBox3.SelectedItem.ToString();//тип ввода
                string tip_trans = textBox3.Text;// тип силового трансформатора
                string tip_obmotok = comboBox4.SelectedItem.ToString();//тип обмоток
                string tip_com_apparat = "";//тип коммутац аппарата на вводе
                if (radioButton1.Checked == true)
                {
                    tip_com_apparat = textBox4.Text;
                }
                else
                {
                    tip_com_apparat = comboBox5.SelectedItem.ToString();
                }

                string razyed = ""; //Разъединитель РЛК 10/400 (на отдельно стоящей опоре)
                if (radioButton2.Checked == true)
                {
                    razyed = "Да";
                }
                else
                {
                    razyed = "Нет";
                }

                string opn = "";//Комплект РВО или ОПН 
                if (radioButton4.Checked == true)
                {
                    opn = textBox5.Text;
                }
                else
                {
                    opn = comboBox6.SelectedItem.ToString();
                }
                string vykl = textBox6.Text;// тип выключателя
                string raz_na_vh = textBox7.Text;// тип разъединителя

                string opn_n_na_vhode = "";//Комплект ОПН-Н-0,4 (при воздушном вводе/выводе)
                if (radioButton6.Checked == true)
                {
                    opn_n_na_vhode = "Да";
                }
                else
                {
                    opn_n_na_vhode = "Нет";
                }
                string tt_na_vyvode = "";//Трансформаторы тока на выводе (Т-0,66, ТШ-0,66)
                if (radioButton8.Checked == true)
                {
                    tt_na_vyvode = "Да";
                }
                else
                {
                    tt_na_vyvode = "Нет";
                }
                string tt_na_uchet = textBox9.Text;//Отдельные трансформаторы тока на учет
                string fider = textBox10.Text;//фидер уличного освещения
                string react = textBox11.Text;//мощность укрм
                                              ///////////////////////////////////

                string[] text_insert = new string[] {nameKtp,mesto,colich,powerKTP,napryazh,isp_vvoda,tip_trans,tip_obmotok,tip_com_apparat,razyed,opn,vykl,raz_na_vh,opn_n_na_vhode,tt_na_vyvode,tt_na_uchet,
            fider,react,colich};
                string[] text_replace = new string[] { "7_9", "7_8", "7_7", "7_6", "7_5", "7_4", "7_3", "7_2", "7_1", "7_0", "6_9", "6_8", "6_7", "6_6", "6_5", "6_4", "6_3", "6_2", "6_1" };

                WordCreate wd = new WordCreate();
                MessageBox.Show(wd.Rasch_oborud_1(path, newPath, text_insert, text_replace));
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных!");
            }


        }
        //кнопка Назад
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                CreateDoc();
            
            
        }
    }
}
