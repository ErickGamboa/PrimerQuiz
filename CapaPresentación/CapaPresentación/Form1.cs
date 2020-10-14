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
using capaEntidad;

namespace CapaPresentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        nComentario comentario = new nComentario();
        NGeografía geografía = new NGeografía();

        
        private void Form1_Load(object sender, EventArgs e)
        {
            listarComentarios();
            LProvincias();
        }

        public void listarPersonas() {

            
        }

        public void listarComentarios()
        {
            dataGridViewComentarios.DataSource = comentario.ListadoComentarios();

        }

        private void LProvincias() {
            List<EGeografía> provincia = geografía.listadoProvincia(1);
            cboProvincias.DataSource = provincia;
            cboProvincias.ValueMember = "id";
            cboProvincias.DisplayMember = "nombre";
        }

        private void LCanton() {
            cboCanton.DataSource = null;
            string provincia = cboProvincias.SelectedValue.ToString();
            int dato = int.Parse(provincia);
            List<EGeografía> canton = geografía.listadoCanton(2,dato);
            cboCanton.DataSource = canton;
            cboCanton.ValueMember = "id";
            cboCanton.DisplayMember = "nombre";

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCanton_Click(object sender, EventArgs e)
        {
            LCanton();
        }

        private void cboProvincias_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cboProvincias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LCanton();
        }
    }
}
