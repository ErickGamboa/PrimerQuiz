using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace capaServicios
{
    public class SGeografía
    {
        private string urlGeografía;

        public string obtenerGeografía (int tipo, int provincia = 1) {

            if (tipo == 1) {
                urlGeografía = "https://ubicaciones.paginasweb.cr/provincias.json";
            }
            if (tipo==2) {
                urlGeografía = "https://ubicaciones.paginasweb.cr/provincia/" + provincia + "/cantones.json";
            }

            WebRequest solicitud = WebRequest.Create(this.urlGeografía);
            WebResponse respuesta = solicitud.GetResponse();
            StreamReader sr = new StreamReader(respuesta.GetResponseStream());
            return sr.ReadToEnd().ToString();



        }

    }
}
