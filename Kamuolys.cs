using System.Collections.Generic;

namespace medziagos_kartojimas
{
    public class Kamuolys : Zaislas
    {
        public List<Spalva> SpalvosKodas { get; set; }

        public Kamuolys(byte dydis) : base(dydis)
        {
        }
    }
}
