using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    public class Spalva : ISpalva
    {
        public Spalva(byte red=0, byte green=0, byte blue=0)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Green { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Blue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    }
}
