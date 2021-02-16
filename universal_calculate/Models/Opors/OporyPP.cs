using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate.Models.Opors
{
    public class OporyPP
    {
        public string Name { get; set; }

        public int Stoyka_105 { get; set; }
        public int Stoyka_7_13 { get; set; }
        public int Stoyka_164_12 { get; set; }
        public int Pristavka_PT_45 { get; set; }
        public int Pristavka_PT43_2 { get; set; }

        public int Plita_P3 { get; set; }
        public int Anker { get; set; }

        public int Ves_Zh { get; set; }

        public int Traversa_2 { get; set; }

        public int Traversa_3 { get; set; }

        public int Traversa_4 { get; set; }

        public int Traversa_6 { get; set; }
        public int Traversa_13 { get; set; }
        public int Traversa_14 { get; set; }
        public int Traversa_17 { get; set; }
        public int Traversa_21 { get; set; }
        public int Traversa_22 { get; set; }
        public int Traversa_23 { get; set; }
        public int Traversa_30 { get; set; }
        public int Nadstavka_1 { get; set; }
        public int Nadstavka_4 { get; set; }
        public int Nadstavka_6 { get; set; }
        public int Ogolovok_OG1 { get; set; }
        public int Nakladka_OG5 { get; set; }
        public int Ogolovok_OG7 { get; set; }
        public int Nakladka_OG8 { get; set; }
        public int Shtyr_OG11 { get; set; }
        public int Kronstein_OG12 { get; set; }
        public int Ogolovok_OG13 { get; set; }
        public int Ogolovok_OG14 { get; set; }
        public int Ogolovok_OG15 { get; set; }
        public int Bolt_b1 { get; set; }
        public int Bolt_b5 { get; set; }
        public int Bolt_b6 { get; set; }
        public int Homut_x1 { get; set; }
        public int Homut_x4 { get; set; }
        public int Homut_x5 { get; set; }
        public int Homut_x24 { get; set; }
        public int Homut_x25 { get; set; }
        public int Homut_x33 { get; set; }
        public int Homut_x34 { get; set; }
        public int Homut_x36 { get; set; }
        public int Kronshtein_U1 { get; set; }
        public int Kronshtein_U2 { get; set; }
        public int Kronshtein_U5 { get; set; }
        public int Styazhka_G1 { get; set; }
        public int Upor_G6 { get; set; }
        public int Ottyazhka_OT3 { get; set; }
        public int Ottyazhka_OT4 { get; set; }
        public int Styazhka_OT5 { get; set; }
        public int Nakladka_OT6 { get; set; }
        public double Provodnik_ZP1 { get; set; }
        public double Stal_Ves { get; set; }
        public int Izolyator_SHF20 { get; set; }
        public int Kolpachek_k6 { get; set; }
        public int Kolpachek_k9 { get; set; }
        public int Kreplenie_provoda { get; set; }
        public int Zazhim_PS2 { get; set; }
        public int Zazhim_PS3 { get; set; }
        public int Zazhimy { get; set; }
        public int Podveska_Natyazhnaya_izol { get; set; }
        public int Podveska_Natyazhnaya_izol_1 { get; set; }
        public int Podveska_Natyazhnaya_podderzh { get; set; }
        public int ZZveno_Promezhut { get; set; }
        public int Skoba_SK7 { get; set; }
        public int Serga_SRS7 { get; set; }


        public string[] GetName()
        {
            string[] name = new string[] { "Тип", "Стойка СВ 105", "Стойка СНВ-7-13" ,"Стойка СВ164-12","Приставка ПТ45 ГОСТ14295-75", "Приставка ПТ43-2", "Плита П3-И","Анкер АЦ-1", "Всего на опору , кг", "Траверса ТМ2", "Траверса ТМ3", "Траверса ТМ4", "Траверса ТМ6", "Траверса ТМ13", "Траверса ТМ14", "Траверса ТМ17", "Траверса ТМ21", "Траверса ТМ22", "Траверса ТМ23", "Траверса ТМ30",
            "Надставка ТС1","Надставка ТС4","Надставка ТС6","Оголовок ОГ1","Накладка ОГ5","Оголовок ОГ7","Накладка ОГ8","Штырь ОГ11","Кронштейн ОГ12","Оголовок ОГ13","Оголовок ОГ14","Оголовок ОГ15","Болт Б1","Болт Б5","Болт Б6","Хомут Х1","Хомут Х4","Хомут Х5","Хомут Х24","Хомут Х25","Хомут Х33","Хомут Х34","Хомут Х36","Кронштейн У1","Кронштейн У2","Кронштейн У5","Стяжка Г1","Упор Г6","Оттяжка ОТ3",
            "Оттяжка ОТ4","Стяжка ОТ5","Накладка ОТ6","Проводник ЗП1","Всего на опору , кг","Изолятор ШФ20-В ГОСТ 22863-77", "Колпачёк К6 ГОСТ 18380-80", "Колпачёк К9 ГОСТ 18380-80", "Крепление провода","Зажим ПС-2 ГОСТ 4261-82","Зажим ПС-3 ГОСТ 4261-82","Зажимы","Подвеска натяжная изолирующая","Подвеска натяжная изолирующая 2","Подвеска поддерживающая изолирующая","Промежуточное звено ПРТ-7 ГОСТ 2728-82",
            "Скоба СК-7 ГОСТ 2724-78","Серьга СРС-7-17 ГОСТ2725-78"};

            return name;
        }
    }
}
