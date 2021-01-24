using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDI03Componente
{
    class Reloj
    {
        public Boolean formato{ get; set; }
        public override string ToString()
        {
            return $"{formato}";
        }
    }
}
