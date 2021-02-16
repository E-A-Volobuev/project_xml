using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate.Models.Opors
{
    public class Opory16m
    {
        public string Name { get; set; }

        public int Stoyka_16 { get; set; }

        public int Plita_P3 { get; set; }
        public int Ancer_AC { get; set; }

        public int Traversa_15 { get; set; }

        public int Traversa_16 { get; set; }

        public int Traversa_17 { get; set; }

        public int Traversa_18 { get; set; }
        public int Ottyazhka_3 { get; set; }
        public int Ottyazhka_4 { get; set; }
        public int Ottyazhka_5 { get; set; }
        public int Bolt_B1{ get; set; }
        public int Bolt_B6 { get; set; }
        public int Nakladka_OG2 { get; set; }
        public int Homut_x33 { get; set; }
        public int Homut_x34 { get; set; }
        public int Homut_x35 { get; set; }
        public double Provodnik_ZP1 { get; set; }
        public double Stal_Ves { get; set; }
        public int Zazhim_ps3 { get; set; }
        public int Zazhim_soedin { get; set; }
        public int Podveska_podderzh_izol { get; set; }
        public int Podveska_podderzh_izol2 { get; set; }
        public int Podveska_natyazh_izol { get; set; }

        public string[] GetName()
        {
            string[] name = new string[] { "Тип", "Стойка СВ16,4-12", "Плита П3-И","Анкер АЦ1", "Траверса ТМ15", "Траверса ТМ16", "Траверса ТМ17", "Траверса ТМ18",  "Оттяжка ОТ3","Оттяжка ОТ4","Стяжка ОТ5","Болт Б1","Болт Б6",
            "Накладка ОГ2","Хомут Х33","Хомут Х34","Хомут Х35","Проводник ЗП1","Всего на опору , кг",
            "Зажим ПС3 ГОСТ 4261-82","Зажим соединительный", "Подвеска поддерживающая изолирующая","Подвеска поддерживающая изолирующая 2","Подвеска натяжная изолирующая" };
            return name;
        }
    }
}
