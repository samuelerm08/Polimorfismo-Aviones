using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones.Core.Aviones
{
    //Clase base
    public abstract class Avion
    {        
        //Propiedades
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }
    
        //Metodos abstractos
        public abstract string Despegar();
        public abstract string Aterriza();

        //Metodo virtual
        public virtual string ToString()
        {
            return $"Detalles Avion:\n" +
                   $"\nPiloto: {Piloto}\n" +
                   $"Copiloto: {Copiloto}\n";
        }
    }
}
