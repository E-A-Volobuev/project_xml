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
    public partial class K_zhurnal : Form
    {
       public string [] Truba_tip { get; set; }
        public string[] Truba_diametr { get; set; }
        public string[] Metallorukav_tip { get; set; }
        public string[] Provod_tip { get; set; }
        public string[] Provod_sech { get; set; }
        public K_zhurnal()
        {
            InitializeComponent();
            linkLabel7.LinkClicked += linkLabel_LinkClicked;
            linkLabel7.MouseDoubleClick += linkLabel_DoubleClick;
            linkLabel6.LinkClicked += linkLabel_LinkClicked;
            linkLabel6.MouseDoubleClick += linkLabel_DoubleClick;
            linkLabel5.LinkClicked += linkLabel_LinkClicked;
            linkLabel5.MouseDoubleClick += linkLabel_DoubleClick;
            linkLabel1.LinkClicked += linkLabel_LinkClicked;
            linkLabel1.MouseDoubleClick += linkLabel_DoubleClick;
            linkLabel2.LinkClicked += linkLabel_LinkClicked;
            linkLabel2.MouseDoubleClick += linkLabel_DoubleClick;
            linkLabel4.LinkClicked += linkLabel_LinkClicked;
            linkLabel4.MouseDoubleClick += linkLabel_DoubleClick;
            linkLabel3.LinkClicked += linkLabel_LinkClicked;
            linkLabel3.MouseDoubleClick += linkLabel_DoubleClick;
            text8_0.Visible = false;
            text9_0.Visible = false;
            text10_0.Visible = false;
            text11_0.Visible = false;
            text12_0.Visible = false;
            text13_0.Visible = false;
            text14_0.Visible = false;

            Truba_tip = new string[] { "Т6", "Т8", "Т10", "Т15", "Т20", "Т25", "Т32", "Т40", "Т50", "Т65", "Т80", "Т90", "Т100", "Т125", "Т150" };
            combo_0.Items.AddRange(Truba_tip);
            Truba_diametr = new string[] { "6", "8", "10", "15", "20", "25", "32", "40", "50", "65", "80", "90", "100", "125", "150" };
            comb1_0.Items.AddRange(Truba_diametr);
            Metallorukav_tip = new string[] { "МРПИ 6", "МРПИ 8", "МРПИ 10", "МРПИ 12", "МРПИ 15", "МРПИ 20", "МРПИ 25", "МРПИ 32", "МРПИ 38", "МРПИ 50", };
            comb2_0.Items.AddRange(Metallorukav_tip);
            Provod_tip = new string[] { "ВБШвнг(А)", "ВВГнг(А)", "КПпБК-120", "КГН"};
            comb3_0.Items.AddRange(Provod_tip);
            Provod_sech = new string[] { "1х1.5", "3х1.5", "4х1.5", "5х1.5", "1х2.5", "3х2.5", "4х2.5", "5х2.5", "1х4", "3х4", "4х4", "5х4", "1х6", "3х6", "4х6", "5х6",
            "1х10", "3х10", "4х10", "5х10","1х16", "3х16", "4х16", "5х16","1х25", "3х25", "4х25", "5х25","1х35", "3х35", "4х35", "5х35","1х50", "3х50", "4х50", "5х50",
            "1х70", "3х70", "4х70", "5х70","1х95", "3х95", "4х95", "5х95","1х120", "3х120", "4х120", "5х120","1х150", "3х150", "4х150", "5х150",
            "1х185", "3х185", "4х185", "5х185","1х240", "3х240", "4х240", "5х240"};
            comb4_0.Items.AddRange(Provod_sech);
            comb5_0.Items.AddRange(Provod_tip);
            comb6_0.Items.AddRange(Provod_sech);
        }


        //добавление линии
        private void button1_Click(object sender, EventArgs e)
        {
            int max;// нашли максимальное число в имени элементов
            int loc; // координата Y существующего элемента текстбокс

            SearchMaxNumberName(out max, out loc);
            max += 1;
            //создаём элементы для добавления их на форму
            var textbox_1 = new TextBox();
            var textbox_2 = new TextBox();
            var textbox_3 = new TextBox();
            var comboBox = new ComboBox();
            var comboBox_2 = new ComboBox();
            var textbox_4 = new TextBox();
            var comboBox_3 = new ComboBox();
            var textbox_5 = new TextBox();
            var textbox_6 = new TextBox();
            var comboBox_4 = new ComboBox();
            var comboBox_5 = new ComboBox();
            var textbox_7 = new TextBox();
            var comboBox_6 = new ComboBox();
            var comboBox_7 = new ComboBox();
            var textbox_8 = new TextBox();
            var textbox_9 = new TextBox();
            var textbox_10 = new TextBox();
            var textbox_11 = new TextBox();
            var textbox_12 = new TextBox();
            var textbox_13 = new TextBox();
            var textbox_14 = new TextBox();
            var textbox_15 = new TextBox();
            var linklabel = new LinkLabel();
            var linklabel_2 = new LinkLabel();
            var linklabel_3 = new LinkLabel();
            var linklabel_4 = new LinkLabel();
            var linklabel_5 = new LinkLabel();
            var linklabel_6 = new LinkLabel();
            var linklabel_7 = new LinkLabel();
            var button = new Button();

            textbox_1.Name = "textb_" + max;//обозначение 
            textbox_1.Size = new System.Drawing.Size(113, 22);
            textbox_1.Location = new Point(16, loc + 65);
            this.Controls.Add(textbox_1);

            textbox_2.Name = "tttt1_" + max;//начало
            textbox_2.Size = new System.Drawing.Size(115, 22);
            textbox_2.Location = new Point(139, loc + 65);
            this.Controls.Add(textbox_2);

            textbox_3.Name = "text2_" + max;//конец
            textbox_3.Size = new System.Drawing.Size(123, 22);
            textbox_3.Location = new Point(263, loc + 65);
            this.Controls.Add(textbox_3);

            comboBox.Name = "combo_" + max;//труба обозначение
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Size = new System.Drawing.Size(100, 24);
            comboBox.Location = new Point(408, loc + 65);
            comboBox.Items.AddRange(Truba_tip);
            this.Controls.Add(comboBox);

            comboBox_2.Name = "comb1_" + max;//труба диаметр
            comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_2.Size = new System.Drawing.Size(87, 24);
            comboBox_2.Location = new Point(517, loc + 65);
            comboBox_2.Items.AddRange(Truba_diametr);
            this.Controls.Add(comboBox_2);

            textbox_4.Name = "text3_" + max;//метров
            textbox_4.Size = new System.Drawing.Size(57, 22);
            textbox_4.Location = new Point(616, loc + 65);
            this.Controls.Add(textbox_4);

            comboBox_3.Name = "comb2_" + max;//металлорукав
            comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_3.Size = new System.Drawing.Size(119, 24);
            comboBox_3.Location = new Point(680, loc + 65);
            comboBox_3.Items.AddRange(Metallorukav_tip);
            this.Controls.Add(comboBox_3);

            textbox_5.Name = "text4_" + max;//метров
            textbox_5.Size = new System.Drawing.Size(57, 22);
            textbox_5.Location = new Point(805, loc + 65);
            this.Controls.Add(textbox_5);

            textbox_6.Name = "text5_" + max;//протяж ящик
            textbox_6.Size = new System.Drawing.Size(88, 22);
            textbox_6.Location = new Point(872, loc + 65);
            this.Controls.Add(textbox_6);

            comboBox_4.Name = "comb3_" + max;//кабель по проекту
            comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_4.Size = new System.Drawing.Size(153, 24);
            comboBox_4.Location = new Point(973, loc + 65);
            comboBox_4.Items.AddRange(Provod_tip);
            this.Controls.Add(comboBox_4);

            comboBox_5.Name = "comb4_" + max;//кабель сечение
            comboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_5.Size = new System.Drawing.Size(93, 24);
            comboBox_5.Location = new Point(1136, loc + 65);
            comboBox_5.Items.AddRange(Provod_sech);
            this.Controls.Add(comboBox_5);

            textbox_7.Name = "text6_" + max;//длина
            textbox_7.Size = new System.Drawing.Size(64, 22);
            textbox_7.Location = new Point(1240, loc + 65);
            this.Controls.Add(textbox_7);

            comboBox_6.Name = "comb5_" + max;//кабель по факт
            comboBox_6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_6.Size = new System.Drawing.Size(153, 24);
            comboBox_6.Location = new Point(1329, loc + 65);
            comboBox_6.Items.AddRange(Provod_tip);
            this.Controls.Add(comboBox_6);

            comboBox_7.Name = "comb6_" + max;//сечен по факт
            comboBox_7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_7.Size = new System.Drawing.Size(93, 24);
            comboBox_7.Location = new Point(1492, loc + 65);
            comboBox_7.Items.AddRange(Provod_sech);
            this.Controls.Add(comboBox_7);

            textbox_8.Name = "text7_" + max;//длина факт
            textbox_8.Size = new System.Drawing.Size(64, 22);
            textbox_8.Location = new Point(1596, loc + 65);
            this.Controls.Add(textbox_8);

            textbox_9.Name = "text8_" + max;//обозначение труба
            textbox_9.Size = new System.Drawing.Size(100, 22);
            textbox_9.Location = new Point(408, loc + 103);
            textbox_9.Visible = false;
            this.Controls.Add(textbox_9);

            textbox_10.Name = "text9_" + max;//диаметр труба
            textbox_10.Size = new System.Drawing.Size(87, 22);
            textbox_10.Location = new Point(515, loc + 103);
            textbox_10.Visible = false;
            this.Controls.Add(textbox_10);

            textbox_11.Name = "text10_" + max;//тип металлорукав
            textbox_11.Size = new System.Drawing.Size(119, 22);
            textbox_11.Location = new Point(680, loc + 103);
            textbox_11.Visible = false;
            this.Controls.Add(textbox_11);

            textbox_12.Name = "text11_" + max;//кабель проект
            textbox_12.Size = new System.Drawing.Size(153, 22);
            textbox_12.Location = new Point(973, loc + 103);
            textbox_12.Visible = false;
            this.Controls.Add(textbox_12);

            textbox_13.Name = "text12_" + max;//сечение каб
            textbox_13.Size = new System.Drawing.Size(93, 22);
            textbox_13.Location = new Point(1136, loc + 103);
            textbox_13.Visible = false;
            this.Controls.Add(textbox_13);

            textbox_14.Name = "text13_" + max;//кабель факт
            textbox_14.Size = new System.Drawing.Size(153, 22);
            textbox_14.Location = new Point(1329, loc + 103);
            textbox_14.Visible = false;
            this.Controls.Add(textbox_14);

            textbox_15.Name = "text14_" + max;//сечение факт
            textbox_15.Size = new System.Drawing.Size(93, 22);
            textbox_15.Location = new Point(1489, loc + 103);
            textbox_15.Visible = false;
            this.Controls.Add(textbox_15);

            linklabel.Name = "lable_" + max;//другое название трубы
            linklabel.Text = "другое";
            linklabel.Location= new Point(408, loc + 87);
            linklabel.Size= new System.Drawing.Size(52, 16);
            linklabel.LinkClicked += linkLabel_LinkClicked;
            linklabel.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel);

            linklabel_2.Name = "labl1_" + max;//другое диаметр трубы
            linklabel_2.Text = "другое";
            linklabel_2.Location = new Point(515, loc + 87);
            linklabel_2.LinkClicked += linkLabel_LinkClicked;
            linklabel_2.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel_2);

            linklabel_3.Name = "labl2_" + max;//другое металлорукав
            linklabel_3.Text = "другое";
            linklabel_3.Location = new Point(680, loc + 87);
            linklabel_3.LinkClicked += linkLabel_LinkClicked;
            linklabel_3.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel_3);

            linklabel_4.Name = "labl3_" + max;//другое кабель проект
            linklabel_4.Text = "другое";
            linklabel_4.Location = new Point(973, loc + 87);
            linklabel_4.LinkClicked += linkLabel_LinkClicked;
            linklabel_4.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel_4);

            linklabel_5.Name = "labl4_" + max;//другое кабель сечен проект
            linklabel_5.Text = "другое";
            linklabel_5.Location = new Point(1136, loc + 87);
            linklabel_5.LinkClicked += linkLabel_LinkClicked;
            linklabel_5.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel_5);

            linklabel_6.Name = "labl5_" + max;//другое кабель факт
            linklabel_6.Text = "другое";
            linklabel_6.Location = new Point(1329, loc + 87);
            linklabel_6.LinkClicked += linkLabel_LinkClicked;
            linklabel_6.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel_6);

            linklabel_7.Name = "labl6_" + max;//другое кабель сечен факт
            linklabel_7.Text = "другое";
            linklabel_7.Location = new Point(1489, loc + 87);
            linklabel_7.LinkClicked += linkLabel_LinkClicked;
            linklabel_7.MouseDoubleClick += linkLabel_DoubleClick;
            this.Controls.Add(linklabel_7);

            //кнопка удаления 
            button.Name = "buttn_" + max;
            button.Text = "удалить";
            button.Location = new Point(1667, loc + 65);
            button.Click += Button_DelOpora_Click;
            this.Controls.Add(button);


        }        

    
        // поиск максимального числа в названии имени элемента и координаты "Y"
        public void SearchMaxNumberName( out int max, out int loc)
        {
            string name = null;//название элемента
            int index = 6;// индекс "_" элемента
            int location = 16;
            int num = 0;// номер элемента
            string subString = "_";// искомый символ (для опор это "_", для разъединителей "Z")
            int indexOfSubstring = 0;//индекс вхождения подстроки в название элемента
            var text = new TextBox();// найденный элемент
            List<int> numbers = new List<int>();
            //Находим имя существующего комбобокса с разъединителями
            foreach (TextBox com in this.Controls.OfType<TextBox>())
            {
                if (com.Location.X == location)
                {
                    indexOfSubstring = com.Name.IndexOf(subString);
                    if (indexOfSubstring > 0)
                    {
                        name = com.Name;
                        text = com;
                        num = Convert.ToInt32(name.Substring(index));
                        numbers.Add(num);
                    }
                }


            }
            max = numbers.Max();// нашли максимальное число в имени элементов
            loc = text.Location.Y;
        }

        //видимость текстбоксов
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string name = (sender as LinkLabel).Name;// имя линклейбла,на который кликнули
            Point point = new Point();//координаты 
            foreach (LinkLabel link in this.Controls.OfType<LinkLabel>())
            {
                if(link.Name==name)
                {
                    point = link.Location;
                }
            }
            point.Y += 16;
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                if (text.Location == point)
                {
                    text.Visible = true;
                }
            }
        }
 
        //сокрытие текстбоксов
        private void linkLabel_DoubleClick(object sender, MouseEventArgs e)
        {
            string name = (sender as LinkLabel).Name;// имя линклейбла,на который кликнули
            Point point = new Point();//координаты 
            foreach (LinkLabel link in this.Controls.OfType<LinkLabel>())
            {
                if (link.Name == name)
                {
                    point = link.Location;
                }
            }
            point.Y += 16;
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                if (text.Location == point)
                {
                    text.Visible = false;
                }
            }
        }
        //удаление линии
        public void Button_DelOpora_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;// имя нажатой кнопки
            string subString = "_";
            int indexOfSubstring = name.IndexOf(subString);//индекс вхождения подстроки в название элемента
            indexOfSubstring += 1;//индекс цифры после черточки в имени элемента
            int num = Convert.ToInt32(name.Substring(indexOfSubstring));// номер в имени элемента

            DelTextBox("textb_", num);
            DelTextBox("tttt1_", num);
            DelTextBox("text2_", num);
            DelTextBox("text3_", num);
            DelTextBox("text4_", num);
            DelTextBox("text5_", num);
            DelTextBox("text6_", num);
            DelTextBox("text7_", num);
            DelTextBox("text8_", num);
            DelTextBox("text9_", num);
            DelTextBox("text10_", num);
            DelTextBox("text11_", num);
            DelTextBox("text12_", num);
            DelTextBox("text13_", num);
            DelTextBox("text14_", num);
            DelCombBox("combo_",num);
            DelCombBox("comb1_", num);
            DelCombBox("comb2_", num);
            DelCombBox("comb3_", num);
            DelCombBox("comb4_", num);
            DelCombBox("comb5_", num);
            DelCombBox("comb6_", num);
            DelLink("lable_", num);
            DelLink("labl1_", num);
            DelLink("labl2_", num);
            DelLink("labl3_", num);
            DelLink("labl4_", num);
            DelLink("labl5_", num);
            DelLink("labl6_", num);
            DelButt("buttn_",num);

        }
        //удаление текстбокса
        public void DelTextBox(string name,int num)
        {
            foreach (TextBox cb in this.Controls.OfType<TextBox>())
            {
                if (cb.Name == name + num)
                {
                    this.Controls.Remove(cb);
                }
            }
        }
        //удаление комбобокса
        public void DelCombBox(string name, int num)
        {
            foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
            {
                if (cb.Name == name+ num)
                {
                    this.Controls.Remove(cb);
                }

            }
        }
        //удаление линклейбла
        public void DelLink(string name,int num)
        {
            foreach (LinkLabel cb in this.Controls.OfType<LinkLabel>())
            {
                if (cb.Name == name + num)
                {
                    this.Controls.Remove(cb);
                }

            }
        }
        //удаление кнопок
        public void DelButt(string name, int num)
        {
            foreach (Button cb in this.Controls.OfType<Button>())
            {
                if (cb.Name == name + num)
                {
                    this.Controls.Remove(cb);
                }

            }
        }

        //формирование кабельно-трубного журнала
        private void button2_Click(object sender, EventArgs e)
        {
            int max = 0; //номер первого элемента
            int loc = 0;// локация первого элемента
            SearchMaxNumberName(out max, out loc);
            List<KabLine> lines = new List<KabLine>();
            for (int i=0;i<max+1;i++)
            {
                string obozn_prov = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "textb_" + i).Text;
               
                string trassa_nach = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "tttt1_" + i).Text;
                string trassa_kon = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text2_" + i).Text;
                string truba_obozn = "";
                var textBox_1 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text8_" + i);//текстбокс тип трубы
                if (textBox_1.Visible == true)
                {
                    truba_obozn = textBox_1.Text;
                }
                else
                {

                    var ob = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "combo_" + i);
                    if(ob.SelectedItem == null)
                    {
                        truba_obozn = "";
                        
                    }
                    else
                    {
                        truba_obozn = ob.SelectedItem.ToString();
                    }
                }
                string truba_diam = "";
                var textBox_2 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text9_" + i);//текстбокс диаметр трубы
                if (textBox_2.Visible == true)
                {
                    truba_diam = textBox_2.Text;
                }
                else
                {
                    var diam = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "comb1_" + i);
                    if(diam.SelectedItem==null)
                    {
                        truba_diam = "";
                    }
                    else
                    {
                        truba_diam=diam.SelectedItem.ToString();
                    }    

                }
                string truba_dlin = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text3_" + i).Text;
                string mett_tip = "";//тип металлорукава
                var textBox_3 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text10_" + i);//текстбокс тип металлорукава
                if (textBox_3.Visible == true)
                {
                    mett_tip = textBox_3.Text;
                }
                else
                {
                    var mett = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "comb2_" + i);
                    if(mett.SelectedItem==null)
                    {
                        mett_tip = "";
                    }
                    else
                    {
                        mett_tip=mett.SelectedItem.ToString();
                    }
                }
                string mett_dlin = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text4_" + i).Text;
                string protyazh_yash = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text5_" + i).Text;
                string kab_proekt = "";
                var textBox_4 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text11_" + i);// кабель проект
                if (textBox_4.Visible == true)
                {
                    kab_proekt = textBox_4.Text;
                }
                else
                {
                    var kab = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "comb3_" + i);
                    if(kab.SelectedItem==null)
                    {
                        kab_proekt = "";
                    }
                    else
                    {
                        kab_proekt= kab.SelectedItem.ToString();
                    }
                }
                string zhil_proekt = "";
                var textBox_5 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text12_" + i);//текстбокс сечение проект
                if (textBox_5.Visible == true)
                {
                    zhil_proekt = textBox_5.Text;
                }
                else
                {
                    var zhil = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "comb4_" + i);
                    if(zhil.SelectedItem==null)
                    {
                        zhil_proekt = "";
                    }
                    else
                    {
                        zhil_proekt=zhil.SelectedItem.ToString();// кабель сечение проект
                    }
                }
                string kab_dlin = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text6_" + i).Text;
                string provod_fact = "";
                var textBox_6 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text13_" + i);//текстбокс кабель тип факт
                if (textBox_6.Visible == true)
                {
                    provod_fact = textBox_6.Text;
                }
                else
                {
                    var prov = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "comb5_" + i);
                    if(prov.SelectedItem==null)
                    {
                        provod_fact = "";
                    }
                    else
                    {
                        provod_fact= prov.SelectedItem.ToString();// кабель тип факт
                    }
                }
                string provod_sech_fact = "";
                var textBox_7 = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text14_" + i);//текстбокс кабель сечен факт
                if (textBox_7.Visible == true)
                {
                    provod_sech_fact = textBox_7.Text;
                }
                else
                {
                    var prov = Controls.OfType<ComboBox>().FirstOrDefault(x => x.Name == "comb6_" + i);
                    if(prov.SelectedItem==null)
                    {
                        provod_sech_fact = "";
                    }
                    else
                    {
                        provod_sech_fact= prov.SelectedItem.ToString();// кабель сечен факт
                    }
                }
                string fact_dlin = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == "text7_" + i).Text;//текстбокс длина кабель факт
                KabLine line = new KabLine()
                {

                    Obozn_provoda = obozn_prov,
                    Trassa_nachalo = trassa_nach,
                    Trassa_konec = trassa_kon,
                    Truba_oboznach = truba_obozn,
                    Truba_diametr = truba_diam,
                    Truba_dlina = truba_dlin,
                    Metalloruk_tip = mett_tip,
                    Metalloruk_dlina = mett_dlin,
                    Protyazh_yashik = protyazh_yash,
                    Provod_Proekt_marka = kab_proekt,
                    Provod_Proekt_kol_zhil = zhil_proekt,
                    Provod_Proekt_dlina = kab_dlin,
                    Provod_Fakt_marka = provod_fact,
                    Provod_Fakt_kol_zhil = provod_sech_fact,
                    Provod_Fakt_dlina = fact_dlin

                };
                lines.Add(line);
            }

            ExelWork work = new ExelWork();
            work.Kab_Trub(lines);
        }
    }
}
