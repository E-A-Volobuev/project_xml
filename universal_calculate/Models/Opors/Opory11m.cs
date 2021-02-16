using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{
   
    public class Opory11m
    {


        public string Name { get; set; }


        public int Stoyka_105 { get; set; }

        public int Plita_P3 { get; set; }


        public int Traversa_2 { get; set; }

        public int Traversa_3 { get; set; }

        public int Traversa_5 { get; set; }

        public int Traversa_6 { get; set; }

        public int Traversa_9 { get; set; }

        public int Traversa_10 { get; set; }

        public int Ogolovok_OG_1 { get; set; }

        public int Nakladka_OG_2 { get; set; }

        public int Nakladka_OG_5 { get; set; }

        public int Nakladka_OG_8 { get; set; }

        public int Nakladka_OG_9 { get; set; }

        public int Homut_x1 { get; set; }

        public int Homut_x2 { get; set; }

        public int Homut_x42 { get; set; }

        public int Bolt_b5 { get; set; }

        public int Kronshtein_y4 { get; set; }

        public int Styazka_G1 { get; set; }

        public int Kronshtein_RA4 { get; set; }

        public int Homut_x7 { get; set; }


        public double Provodnik_ZP1 { get; set; }

        public double Stal_Ves { get; set; }

        public int Izolyator_SHF20 { get; set; }

        public int Kolpachek_k6 { get; set; }

        public int Kreplenie_provoda { get; set; }

        public int Zazhim_PS { get; set; }

        public int Zazhimy { get; set; }

        public int Podveska_Natyazhnaya { get; set; }

        public int ZZveno_Promezhut { get; set; }

        public int Skoba_SK7 { get; set; }

        public int Serga_SRS7 { get; set; }

        public string [] GetName()
        {
            string[] name = new string[] { "Тип", "Стойка СВ110-3.5", "Плита П3-И", "Траверса ТМ2", "Траверса ТМ3", "Траверса ТМ6", "Траверса ТМ5", "Траверса ТМ9", "Траверса ТМ10", "Оголовок ОГ1", "Накладка ОГ2",
            "Накладка ОГ5","Накладка ОГ8","Накладка ОГ9","Хомут Х1","Хомут Х2","Хомут Х42","Болт Б5","Кронштейн У4","Стяжка Г1","Кронштейн РА4", "Хомут Х7","Проводник ЗП1","Всего на опору , кг","Изолятор ШФ20-В ГОСТ 22863-77",
            "Колпачёк К6 ГОСТ 18380-80","Крепление провода","Зажим ПС-2 ГОСТ 4261-82","Зажимы","Подвеска натяжная изолирующая","Промежуточное звено ПРТ-7 ГОСТ 2728-82","Скоба СК-7 ГОСТ 2724-78","Серьга СРС-7-17"};
            return name;
        }

    }
}
