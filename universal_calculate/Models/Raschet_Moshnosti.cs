using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{
    public class Raschet_Moshnosti
    {
        public double Power_Ustan { get; set; } //установленная мощность
        public double I_Rasch { get; set; } //ток данного участка для насоса
        public double Line { get; set; } // длина линии
        public double Sechenie { get; set; } //сечение кабеля

        double t = 0.99;// КПД трансформатора ТМПН
        double cy = 0.95;// КПД станции управления
        double f = 0.99;// КПД выходной LC-фильтр
        double p = 0.0175;//Ом*мм²/м, удельное электрическое сопротивление для меди

        public double Rl { get; set; }//активное сопротивление линии
        public double Rk { get; set; }//потери активной мощности 
        public double RR { get; set; }//Расчетная активная мощность 


        public Raschet_Moshnosti(string power, string tok, string dlina,string sechenie)
        {
            Power_Ustan = Convert.ToDouble(power);
            I_Rasch = Convert.ToDouble(tok);
            Line = Convert.ToDouble(dlina);
            Sechenie = Convert.ToDouble(sechenie);
            Rl = p * Line / Sechenie;
            Rk = 3 * Math.Pow(I_Rasch, 2) * Rl * 0.001;
            RR = (Power_Ustan + Rk)/(t * cy * f);

        }
       
    }
}
