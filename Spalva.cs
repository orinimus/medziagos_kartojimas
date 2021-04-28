using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    public class Spalva : ISpalva
    {
        public Spalva(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }


    }
}
