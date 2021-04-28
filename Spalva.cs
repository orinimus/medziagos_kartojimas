using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    public class Spalva : ISpalva
    {
        public Spalva()
        {
            Red = Green = Blue = 255;
        }

        public Spalva(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }

        public void SetColors(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public void GreyScaleValue(byte red, byte green, byte blue)
        {
            Console.WriteLine($"Greyscale value is {(byte)((red+green+blue)/3)}");    
        }

    }
}
