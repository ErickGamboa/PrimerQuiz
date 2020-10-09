using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace capaServicios
{

    

   public class sComentarios
    {
        private string urlPost;

        public string obtieneComentarios() {

            urlPost = "https://jsonplaceholder.typicode.com/posts/1/comments";
            WebRequest solicitud = WebRequest.Create(this.urlPost);
            WebResponse respuesta = solicitud.GetResponse();
            StreamReader sr = new StreamReader(respuesta.GetResponseStream());
            return sr.ReadToEnd().ToString();
          
        }
    }
}
