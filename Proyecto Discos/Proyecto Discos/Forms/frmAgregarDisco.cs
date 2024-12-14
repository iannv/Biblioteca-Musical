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
    public partial class frmAgregarDisco : Form
    {
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoConexion discoConexion = new DiscoConexion();

            try
            {
                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.CantidadCanciones = (int)nudCantidadCanciones.Value;
                disco.UrlImagenTapa = txtTapaDisco.Text;
                disco.Genero = (Estilo)cmbEstilo.SelectedItem;
                disco.Edicion = (TipoEdicion)cmbTipoEdicion.SelectedItem;

                discoConexion.agregar(disco);
                MessageBox.Show("Disco agregado exitosamente");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show($"Ocurrió un error: {ex.Message}"); }
        }


        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            GeneroConexion generoConexion = new GeneroConexion();
            TipoEdicionConexion edicionConexion = new TipoEdicionConexion();
            try
            {
                cmbEstilo.DataSource = generoConexion.listar();
                cmbTipoEdicion.DataSource = edicionConexion.listar();


            }
            catch (Exception ex) { throw ex; }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTapaDisco_Leave(object sender, EventArgs e)
        {
           cargarImagen(txtTapaDisco.Text);
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
    }
}
