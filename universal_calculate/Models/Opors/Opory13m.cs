using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{
    public  class Opory13m
    {
        public string Name { get; set; }

        public int Stoyka_13 { get; set; }

        public int Plita_P3 { get; set; }

        public int Traversa_2 { get; set; }

        public int Traversa_11 { get; set; }

        public int Traversa_12 { get; set; }

        public int Traversa_14 { get; set; }
        public int Nakladka_OG_2 { get; set; }

        public int Kronshtein_RA4 { get; set; }

        public int Nakladka_OG_6 { get; set; }

        public int Nakladka_OG_10 { get; set; }

        public int Styr_OG_11 { get; set; }

        public int Bolt_b1 { get; set; }
        public int Homut_x4 { get; set; }
        public int Homut_x5 { get; set; }
        public int Homut_x6 { get; set; }
        public int Homut_x37 { get; set; }
        public int Kronshtein_y2 { get; set; }

        public int Styazhka_G1 { get; set; }
        public double Provodnik_ZP1 { get; set; }
        public double Stal_Ves { get; set; }
        public int Izolyator_SHF20 { get; set; }
        public int Kolpachek_k9 { get; set; }
        public int Zazhim_PS2 { get; set; }
        public int Zazhimy { get; set; }
        public int Kreplenie_provoda { get; set; }
        public int Podveska_Natyazhnaya { get; set; }
        public int Podveska_Podderzh { get; set; }
        public int Podveska_Podderzh2 { get; set; }
        public int ZZveno_Promezhut { get; set; }
        public int Skoba_SK7 { get; set; }
        public int Serga_SRS7 { get; set; }
        public int Uzel_krepl { get; set; }
        public string[] GetName()
        {
            string[] name = new string[] { "Тип", "Стойка СНВ-7-13", "Плита П3-И", "Траверса ТМ2", "Траверса ТМ11", "Траверса ТМ12", "Траверса ТМ14",  "Накладка ОГ2","Кронштейн РА4",
            "Накладка ОГ6","Накладка ОГ10","Штырь ОГ11","Болт Б1",  "Хомут Х4","Хомут Х5","Хомут Х6","Хомут Х37", "Кронштейн У2","Стяжка Г1","Проводник ЗП1","Всего на опору , кг","Изолятор ШФ20-В ГОСТ 22863-77",
            "Колпачёк К9 ГОСТ 18380-80","Зажим ПС-2 ГОСТ 4261-82","Зажимы", "Крепление провода", "Подвеска натяжная изолирующая","Подвеска поддерживающая изолирующая","Подвеска поддерживающая изолирующая", "Промежуточное звено ПРТ-7 ГОСТ 2728-82","Скоба СК-7 ГОСТ 2724-78","Серьга СРС-7-17 ГОСТ2725-78",
            "Узел крепления КГП-7-26 ГОСТ14122-76"};
            return name;
        }

    }
}
