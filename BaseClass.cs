﻿using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    public abstract class BaseClass
    {
        protected BaseClass(string name)
        {
            Name = name;
        }

        public string Name { get;}

        public abstract string NameMetodas();

        public abstract int NameKodas(int parametras);
        
    }
}
