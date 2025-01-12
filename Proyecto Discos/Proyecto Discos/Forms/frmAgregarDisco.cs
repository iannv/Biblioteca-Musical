using Proyecto_Discos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Proyecto_Discos.Forms
{
    public partial class frmAgregarDisco : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        public frmAgregarDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar album.";
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiscoConexion discoConexion = new DiscoConexion();

            try
            {
                if(disco == null)
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.CantidadCanciones = (int)nudCantidadCanciones.Value;
                disco.UrlImagenTapa = txtTapaDisco.Text;
                disco.Genero = (Estilo)cmbEstilo.SelectedItem;
                disco.Edicion = (TipoEdicion)cmbTipoEdicion.SelectedItem;

                if (disco.Id != 0)
                {
                    discoConexion.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else {
                    discoConexion.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }

                // Guarda la img en la carpeta solo si pone aceptar
                if(archivo != null)
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["discos-imagenes"] + archivo.SafeFileName);

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
                cmbEstilo.ValueMember = "Id";
                cmbEstilo.DisplayMember = "Descripcion";

                cmbTipoEdicion.DataSource = edicionConexion.listar();
                cmbTipoEdicion.ValueMember = "Id";
                cmbTipoEdicion.DisplayMember = "Descripcion";


                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                    nudCantidadCanciones.Value = disco.CantidadCanciones;
                    txtTapaDisco.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cmbEstilo.SelectedValue = disco.Genero.Id;
                    cmbTipoEdicion.SelectedValue = disco.Edicion.Id;
                }

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

        private void btnEelgirArchivo_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK) {
                txtTapaDisco.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
