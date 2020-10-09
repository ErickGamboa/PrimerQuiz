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
    public class nComentario
    {
        sComentarios comentario = new sComentarios();
        public List<eComentario> ListadoComentarios(){

            string respuesta = comentario.obtieneComentarios();
            List<eComentario> lista = JsonConvert.DeserializeObject <List<eComentario>>(respuesta);
            return lista;

}
    }
}
