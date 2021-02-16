using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{

    public class OporyVL
    {
      
        public string Name { get; set; }

        
        public int Stoyka_105 { get; set; }
       
        public int Plita_P3 { get; set; }
       
        public decimal ZHb_Ves { get; set; }
        
        public int Traversa_1_or_24 { get; set; }
        
        public int Traversa_2 { get; set; }
        
        public int Traversa_3 { get; set; }
        
        public int Traversa_5 { get; set; }
       
        public int Traversa_6 { get; set; }
       
        public int Ogolovok_OG_1 { get; set; }
        
        public int Nakladka_OG_2 { get; set; }
        
        public int Nakladka_OG_5 { get; set; }
        
        public int Nakladka_OG_8 { get; set; }
        
        public int Homut_x1  { get; set; }
        
        public int Homut_x2 { get; set; }
       
        public int Homut_x7 { get; set; }
        
        public int Bolt_b5 { get; set; }
        
        public int Kronshtein_y1 { get; set; }
        
        public int Styazka_G1 { get; set; }
       

        public double Provodnik_ZP1 { get; set; }
        
        public int Kronshtein_RA4 { get; set; }
        
        public double Stal_Ves { get; set; }
      
        public int Izolyator_SHF20 { get; set; }
       
        public int Kolpachek_k6 { get; set; }
        
        public int Kolpachek_k9 { get; set; }
        
        public int Kreplenie_provoda { get; set; }
        
        public int Zazhim_PS { get; set; }
      
        public int Zazhim_PA { get; set; }
        
        public int Podveska_Natyazhnaya { get; set; }
        
        public int ZZveno_Promezhut { get; set; }
       
        public int Skoba_SK7 { get; set; }
        
        public int Serga_SRS7 { get; set; }

        public string [] NameProperties()
        {
            string[] nameProp = new string[] { "Тип", "Стойка СВ105", "Плита П-3И", "Железобетонные конструкции. Всего на опору, кг", "Траверса ТМ1(ТМ24)", "Траверса ТМ2", "Траверса ТМ3", "Траверса ТМ5", "Траверса ТМ6",
            "Оголовок ОГ1", "Накладка ОГ2","Накладка ОГ5","Накладка ОГ8","Хомут Х1","Хомут Х2","Хомут Х7","Болт Б5","Кронштейн У1","Стяжка Г1","Проводник ЗП1","Кронштейн РА4","Стальные конструкции.Всего на опору, кг",
            "Изолятор ШФ20-8 ГОСТ 22863-77","Колпачок К-6 ГОСТ 18380-80","Колпачок К-9 ГОСТ 18380-80","Крепление провода","Зажим ПС-2 ГОСТ 4261-82","Зажим ПА ГОСТ 4261-82","Подвеска натяжная изолирующая","Звено промежуточное ПРТ-7 ГОСТ 2728-82",
            "Скоба СК-7 ГОСТ 2724-78","Серьга СРС-7-17 ГОСТ2725-78"};

            return nameProp;
        }
       
    }
}
