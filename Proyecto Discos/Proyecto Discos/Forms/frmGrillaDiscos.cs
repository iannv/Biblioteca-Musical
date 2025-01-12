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


        // El form se inicia con la lista de albums cargados
        private void frmGrillaDiscos_Load(object sender, EventArgs e)
        {
            cargar();

            cboFiltroCampo.Items.Add("Título");
            //cboFiltroCampo.Items.Add("Fecha de lanzamiento");
            cboFiltroCampo.Items.Add("Cantidad de canciones");
            cboFiltroCampo.Items.Add("Género");
        }


        // Método para cargar la lista de albums en el DataGridView
        private void cargar()
        {
            DiscoConexion disco = new DiscoConexion();
            listaDeDiscos = disco.listar();
            dgvListado.DataSource = listaDeDiscos;
            ocultarColumnas();
            cargarImagen(listaDeDiscos[0].UrlImagenTapa);
        }


        // Método para ocultar las columnas del DataGridView
        private void ocultarColumnas()
        {
            dgvListado.Columns["UrlImagenTapa"].Visible = false;
            dgvListado.Columns["Id"].Visible = false;
        }


        // Método para cambiar la imagen al tocar cada fila
        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListado.CurrentRow != null)
            {
                Disco discoSeleccionado = (Disco)dgvListado.CurrentRow.DataBoundItem;
                cargarImagen(discoSeleccionado.UrlImagenTapa);
            }
        }

        // Método para cargar imágenes en el PictureBox
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


        // Botón de agregar un nuevo album
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form agregarDisco = new frmAgregarDisco();
            agregarDisco.ShowDialog();
            cargar();
        }


        // Botón para modificar un album
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            if (dgvListado.CurrentRow != null)
            {
                seleccionado = (Disco)dgvListado.CurrentRow.DataBoundItem;

                Form modificarDisco = new frmAgregarDisco(seleccionado);
                modificarDisco.ShowDialog();
                cargar();
            }

        }


        // Botón para eliminar un album
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }


        // Método para eliminar un album
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


        // Método para buscar por título del album, estilo musical y tipo de edición
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro != null)
            {
                listaFiltrada = listaDeDiscos.FindAll(
                    x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) ||
                    x.Genero.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                    x.Edicion.Descripcion.ToUpper().Contains(filtro.ToUpper())
                    );
            }
            else { listaFiltrada = listaDeDiscos; }
            dgvListado.DataSource = null;
            dgvListado.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboFiltroCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboFiltroCampo.SelectedItem.ToString();

            if (opcion == "Cantidad de canciones")
            {
                cboFiltroCiterio.Items.Clear();
                cboFiltroCiterio.Items.Add("Mayor a");
                cboFiltroCiterio.Items.Add("Menor a");
                cboFiltroCiterio.Items.Add("Igual a");
            }
            //else if (opcion == "Fecha de lanzamiento")
            //{
            //    cboFiltroCiterio.Items.Clear();
            //    cboFiltroCiterio.Items.Add("Desde");
            //    cboFiltroCiterio.Items.Add("Hasta");
            //}
            else
            {
                cboFiltroCiterio.Items.Clear();
                cboFiltroCiterio.Items.Add("Comienza con");
                cboFiltroCiterio.Items.Add("Termina con");
                cboFiltroCiterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscoConexion disco = new DiscoConexion();
            try
            {
                string campo = cboFiltroCampo.SelectedItem.ToString();
                string criterio = cboFiltroCiterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvListado.DataSource = disco.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
