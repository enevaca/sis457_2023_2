using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    class Inmutable
    {
        readonly int year;
        public Inmutable(int year)
        {
            this.year = year;
        }
        void changeYear()
        {
            // year = 2023;
        }
    }
}
