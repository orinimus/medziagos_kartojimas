using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    interface ISpalva
    {
        byte Red { get; set; }
        byte Green { get; set; }
        byte Blue { get; set; }
    }
}
