using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    class Generico<T, K>
    {
        public T campo { get; set; }
        public K campo2 { get; set; }

        public T impresion(T campo)
        {
            T local = campo;
            Console.WriteLine($"Método genério: {campo}");
            return local;
        }
    }
}
