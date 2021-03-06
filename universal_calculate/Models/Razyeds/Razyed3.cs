﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{
    public class Razyed3
    {
        public string Name { get; set; }
        public int Kronstein_RA1 { get; set; }
        public int Kronstein_RA2 { get; set; }
        public int Kronstein_RA4 { get; set; }
        public int Kronstein_RA5 { get; set; }
        public int Val_RA7 { get; set; }
        public int Val_RA8 { get; set; }
        public int Kronstein_R2 { get; set; }
        public int Kronstein_R6 { get; set; }
        public int Kronstein_KM1 { get; set; }
        public int Skoba_KM4 { get; set; }
        public int Skoba_KM5 { get; set; }
        public int Ugolok_80 { get; set; }
       
        public int Homut_X37 { get; set; }
        public int Homut_X38 { get; set; }
        public int Homut_X39 { get; set; }
        public int Homut_X40 { get; set; }
        public int Homut_X41 { get; set; }
        public int Shtyr_OG11{ get; set; }

        public double Provodnik_ZP1 { get; set; }
        public double Krug_10 { get; set; }
        public double Stal_Ves { get; set; }
        public int Razed_RLND { get; set; }
        public int Privod_PRNZ { get; set; }
        public int Mufta_KMA { get; set; }
        public int Mufta_KN { get; set; }
        public int Razryad_vent { get; set; }
        public int Izol_SHF20 { get; set; }
        public int Kolpachek_K9 { get; set; }
        public int Zazhim_PA { get; set; }
        public int Zazhim_apparat { get; set; }
        public int Zazhim_apparat2 { get; set; }
        public int Nakonech_7_8 { get; set; }
        public double Oshinovka { get; set; }
        public int Provod_zazeml { get; set; }
        public int Bolt_M12 { get; set; }
        public int Bolt_M8 { get; set; }
        public int Gayka_M12 { get; set; }
        public int Gayka_M8 { get; set; }
        public int Shayba_12 { get; set; }
        public int Shayba_8 { get; set; }
        public int Shayba_pruzhin { get; set; }
        public int Kreplenie_provoda { get; set; }
        public string[] GetName()
        {
            string[] name = new string[] { "Тип", "Кронштейн РА1" , "Кронштейн РА2" , "Кронштейн РА4" , "Кронштейн РА5" , "Вал привода РА7" , "Вал привода РА8" , "Кронштейн Р2" , "Кронштейн Р6" , 
            "Кронштейн КМ1","Скоба КМ4","Скоба КМ5", "Уголок 80х80х6 L=2300 ГОСТ 8509-86","Хомут Х37","Хомут Х38","Хомут Х39","Хомут Х40","Хомут Х41","Штырь ОГ11", "Проводник ЗП1","Круг 10 ГОСТ 2509-71","Всего на опору стальных конструкций, кг","Разъединитель РЛНД1-10/400У1 ТУ16-520.151-83",
            "Привод ПРНЗ-10У1 ТУ16-520.151-83","Муфта КМА, КМ4 ТУ16-538.337-79","Муфта КН ТУ16-538.280-79","Разрядник вентильный РВО-10 ГОСТ 16 357-83","Изолятор ШФ20-В ГОСТ 22863-77","Колпачек К9 ГОСТ 18380-80","Зажим ПА ГОСТ 4261-82",
            "Зажим аппаратный А1А ГОСТ 23065-78","Зажим аппаратный А2А ГОСТ 23065-78","Наконечник 7-8 ГОСТ 7386-80","Ошиновка  (проводов ВЛ) ГОСТ 839-80","Провод заземляющий медный гибкий МГГ, L=1000 ГОСТ 20685-75", "Болт М12х40 ГОСТ 7798-70",
            "Болт М8х60 ГОСТ 7798-70","Гайка М12 ГОСТ 5915-70","Гайка М8 ГОСТ 5915-70","Шайба 12 ГОСТ 11371-78","Шайба 8 ГОСТ 11371-78","Шайба пружинная 8Н ГОСТ 6402-70","Крепление провода"};
            return name;
        }
    }
}
