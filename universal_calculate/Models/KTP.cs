using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universal_calculate
{
    //описание ктп
    public class KTP
    {
        public int Power { get; set; } //мощность трансформатора
        public int Losses_XX { get; set; } //потери хх, Вт.
        public int Losses_KZ { get; set; } // потери кз ,Вт
        public double Voltage { get; set; }// напряжение хх, %Uн
        public double Amperage { get; set; } // ток хх, %Iн

    }
}
