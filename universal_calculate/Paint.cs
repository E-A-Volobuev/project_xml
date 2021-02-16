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
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double paint = 0;// площадь КРАСКА
            double grunt = 0;// площадь грунт
            if ( textBox1.Text!=null&&textBox1.Text!=""&& textBox2.Text != null && textBox2.Text != "")
            {
                paint = Convert.ToDouble(textBox1.Text);
                grunt = Convert.ToDouble(textBox2.Text);
                double paintResult = paint * 2 * 0.12;//умножаем на 2,потому что окрашиваем в два слоя, 0,12 средний расход в кг (110-130 г/м2) 
                double gruntResult = grunt * 0.08;//0,08 средний расход в кг (60-100 г/м2)
                label5.Text = paintResult.ToString();
                label8.Text = gruntResult.ToString();

            }
            else if (textBox1.Text != null && textBox1.Text != "" )
            {
                paint = Convert.ToDouble(textBox1.Text);
              
                double paintResult = paint * 2 * 0.12;//умножаем на 2,потому что окрашиваем в два слоя, 0,12 средний расход в кг (110-130 г/м2) 
                label5.Text = paintResult.ToString();
                label5.Visible = true;

            }
            else if (textBox2.Text != null && textBox2.Text != "")
            {
                grunt = Convert.ToDouble(textBox2.Text);
                double gruntResult = grunt * 0.08;//0,08 средний расход в кг (60-100 г/м2)
                label8.Text = gruntResult.ToString();

            }

            else
            {
                MessageBox.Show("Проверьте правильность введённых значений");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эмаль ПФ-115 расход – 110–140 грамм на 1 м2. В программе принят 120 грамм на м2.\nГрунт ГФ-021 расход –  60–100 грамм на 1 м2. В программе принят  80 грамм на м2 ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ExelWork ex = new ExelWork();
                ex.Paint(label5.Text, label8.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
