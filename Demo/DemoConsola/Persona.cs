using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsola
{
    internal class Persona
    {
        public string cedulaIdentidad { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public long celular { get; set; }

        public virtual void saludar()
        {
            Console.WriteLine($"Soy {nombres} {primerApellido} y mi CI es {cedulaIdentidad}");
        }

        public int edad()
        {
            return (DateTime.Now - fechaNacimiento).Days / 365;
        }
    }
}
