using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{
    //разъединитель ВЛ

    public class RazedVL
    {


        public string Name { get; set; }

        public int Kronstein_RA1 { get; set; }

        public int Kronstein_RA2 { get; set; }

        public int Kronstein_RA3 { get; set; }

        public int Kronstein_RA4 { get; set; }

        public int Kronstein_RA5 { get; set; }
 
        public int Kronstein_R1 { get; set; }

        public int Kronstein_R2 { get; set; }

        public int Kronstein_R4 { get; set; }

        public int Kronstein_KM1 { get; set; }

        public int Ugolok_80 { get; set; }

        public int Skoba_KM3 { get; set; }

        public int Homut_X7 { get; set; }

        public int Homut_X8 { get; set; }

        public int Homut_X9 { get; set; }

        public int Homut_X23 { get; set; }

        public double Provodnik_ZP1 { get; set; }

        public double Krug_10 { get; set; }

        public double Stal_Ves { get; set; }

        public int Izol_SHF20 { get; set; }

        public int Kolpachek_K6 { get; set; }
 
        public int Kreplenie_provoda { get; set; }

        public int Zazhim_PA { get; set; }
     
        public int Razed_RLND { get; set; }
       
        public int Privod_PRNZ { get; set; }
      
        public int Mufta_KMA { get; set; }
        
        public int Mufta_KN{ get; set; }
       
        public int Razryad_vent { get; set; }
       
        public int Zazhim_apparat { get; set; }
     
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
     
        public int Zazhim_apparatniy { get; set; }
        public string[] GetName()
        {
            string[] name = new string[] { "Тип", "Кронштейн РА1", "Кронштейн РА2", "Кронштейн РА3", "Кронштейн РА4" , "Кронштейн РА5" , "Кронштейн Р1", "Кронштейн Р2", "Кронштейн Р4", "Кронштейн КМ1", "Уголок 80х80х6, L=2300 ГОСТ 8509-86",
             "Скоба КМ3","Хомут Х7","Хомут Х8","Хомут Х9","Хомут Х23","Проводник ЗП1","Круг10 ГОСТ2590-71","Сталь Всего на опору","Изолятор ШФ20-8 ГОСТ22863-77","Колпачок К-6 ГОСТ 18380-80","Крепление провода","Зажим ПА ГОСТ 4261-82","Разъединитель РЛНД1-10/400 У1 ТУ16-520.151-83",
            "Привод ПРНЗ-10У1 ТУ16-520.151-83","Муфта КМА, КМ4 ТУ16-538.337-79","Муфта КН ТУ16-538.280-79","Разрядник вентильный РВО-10 ТУ16.521.232-77","Зажим аппаратный А1А ГОСТ23065-78","Наконечник 7-8 ГОСТ 7385-80","Ошиновка (провод ВЛ) ГОСТ 839-80",
            "Провод заземляющий медный гибкий МГГ L=1000 ГОСТ 20685-75","Болт М12Х40 ГОСТ 7798-70","Болт М8Х60 ГОСТ 7798-70","Гайка М12 ГОСТ 5915-70","Гайка М8 ГОСТ 5915-70","Шайба 12 ГОСТ11371-78","Шайба 8 ГОСТ11371-78","Шайба пружинная 8Н ГОСТ 6402-70",
            "Зажим аппаратный А2А ГОСТ 23065-78"};
            return name;
        }

    }
}
