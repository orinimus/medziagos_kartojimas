using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    public abstract class Zaislas: Spalva
    {
        public int Metimas { get; set; }
        public byte Dydis { get; set; }

        protected Zaislas(int metimas)
        {
            Metimas = metimas;
        }

        protected Zaislas(byte dydis)
        {
            Dydis = dydis;
        }

        public virtual int Mesti() => Metimas + 1;

        public virtual int Susprogdinti() => Dydis = 0;
    }
}
