using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos.Admin;

namespace WindowsPubs
{
    public partial class frmPublicadores : Form
    {
        public frmPublicadores()
        {
            InitializeComponent();
        }

        private void frmPublicadores_Load(object sender, EventArgs e)
        {
            mostrarPublicadores();
        }

        private void mostrarPublicadores()
        {
            gridPublicadores.DataSource = AdmPublisher.listarPublicadores();
        }

        private void btnMostrarPublicadores_Click(object sender, EventArgs e)
        {
            mostrarPublicadores();
        }

        private void btnMostrarXCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            gridPublicadores.DataSource = AdmPublisher.listarPublicadores(ciudad);
        }

        private void btnMostrarCiudadEstado_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            gridPublicadores.DataSource = AdmPublisher.listarPublicadores(ciudad,estado);
        }

        private void btnMostrarXCiudadEstadoPais_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            gridPublicadores.DataSource = AdmPublisher.listarPublicadores(ciudad, estado,pais);
        }
    }
}
