using Proyecto_Discos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Discos.Forms
{
    public partial class frmGrillaDiscos : Form
    {
        private List<Disco> listaDeDiscos;
        public frmGrillaDiscos()
        {
            InitializeComponent();
        }

        private void frmGrillaDiscos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            DiscoConexion disco = new DiscoConexion();
            listaDeDiscos = disco.listar();
            dgvListado.DataSource = listaDeDiscos;
            dgvListado.Columns["UrlImagenTapa"].Visible = false;
            dgvListado.Columns["Id"].Visible = false;

            cargarImagen(listaDeDiscos[0].UrlImagenTapa);
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            Disco discoSeleccionado = (Disco)dgvListado.CurrentRow.DataBoundItem;
            cargarImagen(discoSeleccionado.UrlImagenTapa);
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                picDisco.Load(imagen);
            }
            catch (Exception e)
            {
                picDisco.Load("https://e7.pngegg.com/pngimages/955/252/png-clipart-white-and-multicolored-music-logo-apple-music-itunes-streaming-media-music-purple-logo-thumbnail.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form agregarDisco = new frmAgregarDisco();
            agregarDisco.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvListado.CurrentRow.DataBoundItem;

            Form modificarDisco = new frmAgregarDisco(seleccionado);
            modificarDisco.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool eliminar = false)
        {
            DiscoConexion disco = new DiscoConexion();
            Disco seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar definiticamente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes) {
                    seleccionado = (Disco)dgvListado.CurrentRow.DataBoundItem;
                    disco.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex) { throw ex; }
        }
    }
}
