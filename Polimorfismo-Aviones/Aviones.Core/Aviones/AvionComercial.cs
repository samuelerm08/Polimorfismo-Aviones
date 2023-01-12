using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones.Core.Aviones
{
    public class AvionComercial : Avion
    {        
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }
        
        public override string Aterriza()
        {
            return "Avion Aterrizando";
        }
        
        public override string Despegar()
        {
            return "Avion Despegando";
        }
        
        public override string ToString()
        {
            return base.VerPropiedades() + $"Azafata: {Azafata}\n" +
                                            $"Capacidad: {Capacidad}\n" +
                                            $"Linea Aerea: {LineaAerea}";
        }
    }
}
