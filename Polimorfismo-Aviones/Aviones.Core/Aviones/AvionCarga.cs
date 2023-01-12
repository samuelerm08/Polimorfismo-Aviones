using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones.Core.Aviones
{
    public class AvionCarga : Avion
    {        
        public string Peso { get; set; }
        public string TipoMercaderia { get; set; }

        public override string Aterriza()
        {
            return "Avion Aterrizando";
        }

        public override string Despegar()
        {
            return "Avion Despegando";
        }
    }
}
