using System;
using System.Collections.Generic;
using System.Text;

namespace medziagos_kartojimas
{
    abstract class BaseClass
    {
        protected BaseClass(string name)
        {
            Name = name;
        }

        public string Name { get;}


        abstract string NameMetodas()
        {
        }

        abstract int NameKodas(int parametras)
        {

        } 
    }
}
