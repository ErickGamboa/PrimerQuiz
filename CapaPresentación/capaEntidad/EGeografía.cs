using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
   public class EGeografía
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public EGeografía(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }


}
