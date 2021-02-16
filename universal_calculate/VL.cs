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
using universal_calculate.Models.Opors;

namespace universal_calculate
{
    public partial class VL : Form
    {
        public VL()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            
            comb1_0.SelectionChangeCommitted += ComboEvent;
            
            comb1Z0.SelectionChangeCommitted += ComboRZEvent;
            var seria = Seria_1();
            var seria_2 = Seria_2();
            comb1_0.Items.AddRange(seria);
            comb1Z0.Items.AddRange(seria_2);
        }
        //событие выбора серии опор
        public void ComboEvent(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            string znach = combo.SelectedItem.ToString();
            ComboBox comOp = new ComboBox();// список опор
            Point point = new Point();
            point.X = 176;
            point.Y = combo.Location.Y;
            //Находим имя существующего комбобокса типами опор 
            foreach (ComboBox com in this.Controls.OfType<ComboBox>())
            {
                if(com.Location==point)
                {
                    comOp = com;
                }
            }
            comOp.Items.Clear();
            var list = NameOpory(znach);
            comOp.Items.AddRange(list);
        }
        //
        //событие выбора серии разъединителей
        public void ComboRZEvent(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;
            string znach = combo.SelectedItem.ToString();
            ComboBox comRz = new ComboBox();// список РАЗЪЕДИНИТЕЛЕЙ
            Point point = new Point();
            point.X = 821;
            point.Y = combo.Location.Y;
            //Находим имя существующего комбобокса типами опор 
            foreach (ComboBox com in this.Controls.OfType<ComboBox>())
            {
                if (com.Location == point)
                {
                    comRz = com;
                }
            }
            comRz.Items.Clear();
            var list = NameRazediniteli(znach);
            comRz.Items.AddRange(list);
        }
        //инициализация серии опор ВЛ
        public string [] Seria_1()
        {
            string[] seria = new string[] { "Вып.1", "Вып.2", "Вып.3", "Вып.4", "Вып.5" };
            return seria;
        }
        public string[] Seria_2()
        {
            string[] seria = new string[] { "Вып.1", "Вып.2", "Вып.3" };
            return seria;
        }

        //инициализация названия опор ВЛ
        public string [] NameOpory(string znach)
        {
            VLDataBase dt = new VLDataBase();
            if (znach == "Вып.1")
            {
                var opory = dt.GetNameOp_1();
                return opory.ToArray();
            }
            else if(znach == "Вып.2")
            {
                var opory = dt.GetNameOp_2();
                return opory.ToArray();
            }
            else if(znach == "Вып.3")
            {
                var opory = dt.GetNameOp_3();
                return opory.ToArray();
            }
            else if (znach == "Вып.4")
            {
                var opory = dt.GetNameOp_4();
                return opory.ToArray();
            }
            else 
            {
                var opory = dt.GetNameOp_5();
                return opory.ToArray();
            }


        }
        //инициализация названия разъединителей
        public string [] NameRazediniteli(string znach)
        {
            VLDataBase dt = new VLDataBase();
            if (znach == "Вып.1")
            {
                var razyed = dt.GetNameRazyed_1();
                return razyed.ToArray();
            }
            else if (znach == "Вып.2")
            {
                var razyed = dt.GetNameRazyed_2();
                return razyed.ToArray();
            }
            else
            {
                var razyed = dt.GetNameRazyed_3();
                return razyed.ToArray();
            }
                

        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\Серия 3.407.1-143 Вып.1. ЖБ оп. ВЛ 10кВ. Оп. на жб стойках длиной 10,5м.PDF");
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
                Process.Start(file + @"\Серия 3.407.1-143 Вып.2. ЖБ оп. ВЛ 10кВ. Оп. на жб стойках длиной 11м.pdf");
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
                Process.Start(file + @"\Серия 3.407.1-143 Вып.3. ЖБ оп. ВЛ 10кВ. Оп. на жб стойках длиной 13м.pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\Серия 3.407.1-143 Вып.4. ЖБ оп. ВЛ 10кВ. Оп. на жб стойках длиной 16,4м.pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\Серия 3.407.1-143 Вып.5. ЖБ оп. ВЛ 10кВ. ЖБ опоры для пересечений с инж. ком..pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string file = Environment.CurrentDirectory;
                Process.Start(file + @"\Серия 3.407-150 Ззаемляющие устройства опор ВЛ.pdf");
            }
            catch
            {
                MessageBox.Show("что-то пошло не так((");
            }
        }

        //список выбранных в комбобоксе имён 
        public List<string> ListNameELement = new List<string>();
        //список найденных в xml опор 1 серии по списку имён
        public List<OporyVL> CurrentOpory = new List<OporyVL>();
        //список найденных в xml разъединителей 1 серии по списку имён
        public List<RazedVL> CurrentRZ = new List<RazedVL>();

        //список найденных в xml опор 2 серии по списку имён
        public List<Opory11m> CurrentOpory11m = new List<Opory11m>();
        //список найденных в xml разъединителей 2 серии по списку имён
        public List<Razyed11m> CurrentRZ11m = new List<Razyed11m>();

        //список найденных в xml опор 3 серии по списку имён
        public List<Opory13m> CurrentOpory13m = new List<Opory13m>();
        //список найденных в xml разъединителей 2 серии по списку имён
        public List<Razyed3> CurrentRZ13m = new List<Razyed3>();

        //список найденных в xml опор 4 серии по списку имён
        public List<Opory16m> CurrentOpory16m = new List<Opory16m>();
        //список найденных в xml опор 5 серии по списку имён
        public List<OporyPP> CurrentOporyPP = new List<OporyPP>();


        //список количества штук элементов 
        public List<int> ColELement = new List<int>();
        ///добавление опоры
        private void button2_Click(object sender, EventArgs e)
        {
            

            var seria = Seria_1();// список типовых серий

            string symbol = "_"; // символ в конце названия элемента,после которого стоит номер элемента(уникальный)
            int index = 6;// индекс z в имени элемента

            int max;// нашли максимальное число в имени элементов
            int loc; // координата Y существующего элемента комбобокс
            int location = 176;// координата x для списка опор

            SearchMaxNumberName(symbol, index, out max, out loc,location);
            max += 1;
            loc += 30;

            //создаём элементы для добавления на форму

            var comboBox0 = new ComboBox();
            var label_x1 = new Label();
            var comboBox = new ComboBox();
            var label_x2 = new Label();
            var textbox = new TextBox();
            var label_x3 = new Label();
            var button = new Button();

            comboBox0.Name = "comb1_" + max;
            comboBox0.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox0.Size = new System.Drawing.Size(80, 24);
            comboBox0.Location = new Point(3, loc);
            comboBox0.Items.AddRange(seria);
            this.Controls.Add(comboBox0);


            label_x1.Name = "labelx1_" + max ;
            label_x1.Size = new System.Drawing.Size(83, 16);
            label_x1.Text = "Тип опоры:";
            label_x1.Location = new Point(83, loc);
            this.Controls.Add(label_x1);

            comboBox.Name = "combo_" + max;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Size = new System.Drawing.Size(132, 24);
            comboBox.Location = new Point(176, loc);
            this.Controls.Add(comboBox);


            label_x2.Name = "labelx2_" + max;
            label_x2.Size = new System.Drawing.Size(56, 16);
            label_x2.Text = "Кол-во:";
            label_x2.Location = new Point(317, loc);
            this.Controls.Add(label_x2);

            textbox.Name = "textbox_" + max;
            textbox.Size = new System.Drawing.Size(44, 22);
            textbox.Location = new Point(384, loc);
            this.Controls.Add(textbox);

            label_x3.Name = "labelx3_" + max;
            label_x3.Size = new System.Drawing.Size(27, 16);
            label_x3.Text = "шт.";
            label_x3.Location = new Point(437, loc);
            this.Controls.Add(label_x3);

            button.Name = "buttonx_" + max;
            button.Size = new System.Drawing.Size(100, 28);
            button.Text = "удалить";
            button.Location = new Point(476, loc);
            button.Click += Button_DelOpora_Click;
            this.Controls.Add(button);

            comboBox0.SelectionChangeCommitted += ComboEvent;


        }
       
        ////удаление опоры 
        public void Button_DelOpora_Click(object sender, EventArgs e)
        {
            
            string name = (sender as Button).Name;// имя нажатой кнопки
            string subString = "_";
            int indexOfSubstring = name.IndexOf(subString);//индекс вхождения подстроки в название элемента
            indexOfSubstring += 1;//индекс цифры после черточки в имени элемента
            int num = Convert.ToInt32(name.Substring(indexOfSubstring));// номер в имени элемента

            foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
            {
                if (cb.Name == "comb1_" + num)
                {
                    this.Controls.Remove(cb);
                }
            }

            foreach (Label x1 in this.Controls.OfType<Label>())
            {
                if (x1.Name == "labelx1_" + num)
                {
                    this.Controls.Remove(x1);
                }
            }


            foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
            {
                if (cb.Name == "combo_" + num)
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

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Name == "textbox_" + num)
                {
                    this.Controls.Remove(textBox);
                }
            }

            foreach (Label x3 in this.Controls.OfType<Label>())
            {
                if (x3.Name == "labelx3_" + num)
                {
                    this.Controls.Remove(x3);
                }
            }

            foreach ( Button btn in this.Controls.OfType<Button>())
            {
                if(btn.Name== "buttonx_"+num)
                {
                    this.Controls.Remove(btn);
                }
            }


        }
        //удаление разъединителя
        public void Button_DelRazyed_Click(object sender, EventArgs e)
        {

            string name = (sender as Button).Name;// имя нажатой кнопки
            string subString = "Z";
            int indexOfSubstring = name.IndexOf(subString);//индекс вхождения подстроки в название элемента
            indexOfSubstring += 1;//индекс цифры после черточки в имени элемента
            int num = Convert.ToInt32(name.Substring(indexOfSubstring));// номер в имени элемента

            foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
            {
                if (cb.Name == "comb1Z" + num)
                {
                    this.Controls.Remove(cb);
                }
            }

            foreach (Label x1 in this.Controls.OfType<Label>())
            {
                if (x1.Name == "labelZ" + num)
                {
                    this.Controls.Remove(x1);
                }
            }


            foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
            {
                if (cb.Name == "comboZ" + num)
                {
                    this.Controls.Remove(cb);
                }
            }

            foreach (Label x2 in this.Controls.OfType<Label>())
            {
                if (x2.Name == "label8Z" + num)
                {
                    this.Controls.Remove(x2);
                }
            }

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Name == "textboxZ" + num)
                {
                    this.Controls.Remove(textBox);
                }
            }

            foreach (Label x3 in this.Controls.OfType<Label>())
            {
                if (x3.Name == "label7Z" + num)
                {
                    this.Controls.Remove(x3);
                }
            }

            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name == "buttonZ" + num)
                {
                    this.Controls.Remove(btn);
                }
            }


        }


        ///добавление разъединителя
        private void button4_Click(object sender, EventArgs e)
        {
            var seria = Seria_2();// список типовых серий
            string symbol = "Z"; // символ в конце названия элемента,после которого стоит номер элемента(уникальный)
            int index = 6;// индекс z в имени элемента

            int max;// нашли максимальное число в имени элементов
            int loc; // координата Y существующего элемента комбобокс
            int location = 821;// координата x для списка опор

            SearchMaxNumberName( symbol, index, out  max, out  loc,location);
            max += 1;
            loc+= 30;

            //создаём элементы для добавления на форму

            var comboBox0 = new ComboBox();
            var label_x1 = new Label();
            var comboBox = new ComboBox();
            var label_x2 = new Label();
            var textbox = new TextBox();
            var label_x3 = new Label();
            var button = new Button();

            comboBox0.Name = "comb1Z" + max;
            comboBox0.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox0.Size = new System.Drawing.Size(80, 24);
            comboBox0.Location = new Point(584, loc);
            comboBox0.Items.AddRange(seria);
            this.Controls.Add(comboBox0);

            label_x1.Name = "labelZ" + max;
            label_x1.Size = new System.Drawing.Size(142, 16);
            label_x1.Text = "Тип разъединителя:";
            label_x1.Location = new Point(667, loc);
            this.Controls.Add(label_x1);

            comboBox.Name = "comboZ" + max;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Size = new System.Drawing.Size(85, 24);
            comboBox.Location = new Point(821, loc);
            this.Controls.Add(comboBox);

            label_x2.Name = "label8Z" + max;
            label_x2.Size = new System.Drawing.Size(44, 13);
            label_x2.Text = "Кол-во:";
            label_x2.Location = new Point(916, loc);
            this.Controls.Add(label_x2);

            textbox.Name = "textboxZ" + max;
            textbox.Size = new System.Drawing.Size(44, 22);
            textbox.Location = new Point(983, loc);
            this.Controls.Add(textbox);

            label_x3.Name = "label7Z" + max;
            label_x3.Size = new System.Drawing.Size(23, 13);
            label_x3.Text = "шт.";
            label_x3.Location = new Point(1036, loc);
            this.Controls.Add(label_x3);

            button.Name = "buttonZ" + max;
            button.Size = new System.Drawing.Size(100, 28);
            button.Text = "удалить";
            button.Location = new Point(1075, loc);
            button.Click += Button_DelRazyed_Click;
            this.Controls.Add(button);

            comboBox0.SelectionChangeCommitted += ComboRZEvent;



        }
        // поиск максимального числа в названии имени элемента и координаты "Y"
        public void SearchMaxNumberName(string symbol, int index, out int max, out int loc,int location)
        {
            string name = null;//название элемента
            int num = 0;// номер элемента
            string subString = symbol;// искомый символ (для опор это "_", для разъединителей "Z")
            int indexOfSubstring = 0;//индекс вхождения подстроки в название элемента
            var combo = new ComboBox();// найденный элемент
            List<int> numbers = new List<int>();
            //Находим имя существующего комбобокса с разъединителями
            foreach (ComboBox com in this.Controls.OfType<ComboBox>())
            {
                if(com.Location.X==location)
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

        // составление списков оборудования и их количества
        private void button1_Click(object sender, EventArgs e)
        {
            string name = null;// название элемента
            string opora = null; // выбранная опора
            string str = null;
            string kol = null;// количество
            if (ListNameELement.Count != 0)
            {
                ListNameELement.Clear();
            }
            if (ColELement.Count != 0)
            {
                ColELement.Clear();
            }

            foreach (ComboBox com in this.Controls.OfType<ComboBox>())
            {

                if (com.SelectedItem != null)
                {

                    opora = com.SelectedItem.ToString();
                    name = com.Name.Substring(5);
                    str = "textbox" + name;
                    ListNameELement.Add(com.SelectedItem.ToString());
                    foreach (TextBox text in this.Controls.OfType<TextBox>())
                    {

                        if (text.Name == str)
                        {
                            ColELement.Add(Convert.ToInt32(text.Text));
                        }
                    }

                }
            }

            SearchOborud();
            SearchOborud11m();
            SearchOborud13m();
            SearchOborud16m();
            SearchOborudPP();

            ExelWork exel = new ExelWork();
            exel.Element(ListNameELement, ColELement);
            exel.ListName(CurrentOpory, CurrentRZ);
            exel.ListName11m(CurrentOpory11m, CurrentRZ11m);
            exel.ListName13m(CurrentOpory13m, CurrentRZ13m);
            exel.ListName16m(CurrentOpory16m);
            exel.ListNamePP(CurrentOporyPP);
            exel.Specification();
        }

        //поиск оборудования в базе данных

        public void SearchOborud()
        {
            VLDataBase vl = new VLDataBase();
            //получаем список опор 1-й серии  из базы данных
            var opory = vl.GetOp();
            OporyVL selectOpora = new OporyVL();
            //получаем список разъединителей 1 - й серии из базы данных
            var razyed = vl.GetRaz();
            RazedVL selectRZ = new RazedVL();

            foreach (var s in ListNameELement)
            {
                selectOpora = opory.FirstOrDefault(x => x.Name == s);
                if (selectOpora != null)
                {
                    CurrentOpory.Add(selectOpora);
                }
                selectRZ = razyed.FirstOrDefault(x => x.Name == s);
                if (selectRZ != null)
                {
                    CurrentRZ.Add(selectRZ);
                }

            }
            


        }

        //поиск оборудования  для второй серии
        public void SearchOborud11m()
        {
            VLDataBase vl = new VLDataBase();
            //получаем список опор 2-й серии  из базы данных
            var opory = vl.GetOp_2();
            Opory11m selectOpora = new Opory11m();
            //получаем список разъединителей 1-й серии из базы данных
            var razyed = vl.GetRaz_2();
            Razyed11m selectRZ = new Razyed11m();

            foreach (var s in ListNameELement)
            {
                selectOpora = opory.FirstOrDefault(x => x.Name == s);
                if (selectOpora != null)
                {
                    CurrentOpory11m.Add(selectOpora);
                }
                selectRZ = razyed.FirstOrDefault(x => x.Name == s);
                if (selectRZ != null)
                {
                    CurrentRZ11m.Add(selectRZ);
                }

            }


        }
        //поиск оборудования  для третьей серии
        public void SearchOborud13m()
        {
            VLDataBase vl = new VLDataBase();
            //получаем список опор 3-й серии  из базы данных
            var opory = vl.GetOp_3();
            Opory13m selectOpora = new Opory13m();
            //получаем список разъединителей 3-й серии из базы данных
            var razyed = vl.GetRaz_3();
            Razyed3 selectRZ = new Razyed3();

            foreach (var s in ListNameELement)
            {
                selectOpora = opory.FirstOrDefault(x => x.Name == s);
                if (selectOpora != null)
                {
                    CurrentOpory13m.Add(selectOpora);
                }
                selectRZ = razyed.FirstOrDefault(x => x.Name == s);
                if (selectRZ != null)
                {
                    CurrentRZ13m.Add(selectRZ);
                }

            }


        }
        //поиск оборудования  для четвёртой серии
        public void SearchOborud16m()
        {
            VLDataBase vl = new VLDataBase();
            //получаем список опор 4-й серии  из базы данных
            var opory = vl.GetOp_4();
            Opory16m selectOpora = new Opory16m();
            

            foreach (var s in ListNameELement)
            {
                selectOpora = opory.FirstOrDefault(x => x.Name == s);
                if (selectOpora != null)
                {
                    CurrentOpory16m.Add(selectOpora);
                }
               

            }


        }
        //поиск оборудования  для пятой серии
        public void SearchOborudPP()
        {
            VLDataBase vl = new VLDataBase();
            //получаем список опор 5-й серии  из базы данных
            var opory = vl.GetOp_5();
            OporyPP selectOpora = new OporyPP();


            foreach (var s in ListNameELement)
            {
                selectOpora = opory.FirstOrDefault(x => x.Name == s);
                if (selectOpora != null)
                {
                    CurrentOporyPP.Add(selectOpora);
                }


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

    }
}
