using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
  public class ePersona
    {
        public int IdPersona { get; set; }

        public int Codigo { get; set; }

        public string Cedula { get; set; }

        public string nombre { get; set; }

        public string genero { get; set; }

        public ePersona(int idPersona, int codigo, string cedula, string nombre, string genero)
        {
            IdPersona = idPersona;
            Codigo = codigo;
            Cedula = cedula;
            this.nombre = nombre;
            this.genero = genero;
        }
    }

}
