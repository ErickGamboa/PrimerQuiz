using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace CapaPresentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        nComentario comentario = new nComentario();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listarComentarios();
        }

        public void listarPersonas() {

            
        }

        public void listarComentarios()
        {
            dataGridViewComentarios.DataSource = comentario.ListadoComentarios();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
