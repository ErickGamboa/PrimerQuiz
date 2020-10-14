using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaServicios;
using capaEntidad;
using Newtonsoft.Json;

namespace capaNegocio
{
    public class NGeografía
    {
        SGeografía geografia = new SGeografía();
        List<EGeografía> listProvincia = new List<EGeografía>();
        List<EGeografía> listCanton = new List<EGeografía>();

        public List<EGeografía> listadoProvincia(int tipo, int provincia = 1) {
            listProvincia.Clear();
            string respuesta = geografia.obtenerGeografía(tipo, provincia);
            var dicProvincia = JsonConvert.DeserializeObject<Dictionary<string, string>>(respuesta);
            foreach (var dp in dicProvincia) {
                listProvincia.Add(new EGeografía(dp.Key, dp.Value));
            }
            return listProvincia;

        }

        public List<EGeografía> listadoCanton(int tipo, int provincia = 1)
        {
            listCanton.Clear();
            string respuesta = geografia.obtenerGeografía(tipo, provincia);
            var dicCanton = JsonConvert.DeserializeObject<Dictionary<string, string>>(respuesta);
            foreach (var dc in dicCanton)
            {
                listCanton.Add(new EGeografía(dc.Key, dc.Value));
            }
            return listCanton;

        }


    }
}
