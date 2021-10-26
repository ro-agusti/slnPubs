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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarautores();
            llenarComboCiudad();
        }
        private void llenarComboCiudad()
        {
            DataTable Ciudad = AdmAuthor.listarSoloCiudades();
            cbTraerXCiudad.DataSource = Ciudad;

            cbTraerXCiudad.DisplayMember = Ciudad.Columns["city"].ToString();

            cbTraerXCiudad.ValueMember = Ciudad.Columns["city"].ToString();

            DataRow fila = Ciudad.NewRow();
            fila["city"] = "[TODAS]";
            Ciudad.Rows.InsertAt(fila, 0);
        }

        private void mostrarautores()
        {
            gridDataAutores.DataSource = AdmAuthor.listar();
        }

        private void btnFiltrarPorCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            gridDataAutores.DataSource = AdmAuthor.listar(ciudad);
        }

        private void btnMostrarAutores_Click(object sender, EventArgs e)
        {
            mostrarautores();
        }

        private void btnFiltrarPorEstado_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            gridDataAutores.DataSource = AdmAuthor.listar(ciudad, estado);
        }

        private void cbTraerXCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ciudad = cbTraerXCiudad.SelectedValue.ToString();
            if (ciudad == "[TODAS]")
            {
                mostrarautores();
            }
            else
            {
                gridDataAutores.DataSource = AdmAuthor.listarDT(ciudad);
            }
        }
    }
}
