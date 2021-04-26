using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace medziagos_kartojimas
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int parametras)
        {
            throw new NotImplementedException();
        }

        public override string NameMetodas()
        {
            var balses = "aeėiouy".ToList();
            foreach (var raide in Name)
            {
                balses.Contains(raide) ? a = int(raide) : raide;
               
            }
        }
    }
}
