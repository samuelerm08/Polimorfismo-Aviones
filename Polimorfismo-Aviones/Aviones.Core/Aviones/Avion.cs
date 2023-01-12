using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones.Core.Aviones
{
    public abstract class Avion
    {
        protected Avion(string piloto, string copiloto, string azafata = null)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafata = azafata;
        }

        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public abstract string Despegar();
        public abstract string Aterriza();

        public virtual string VerPropiedades()
        {
            return $"Detalles Avion:\n" +
                   $"\nPiloto: {Piloto}\n" +
                   $"Copiloto: {Copiloto}\n" +
                   $"Azafata: {Azafata}\n";
        }
    }
}
