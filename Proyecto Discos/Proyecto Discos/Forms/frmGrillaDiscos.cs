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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form agregarDisco = new frmAgregarDisco();
            agregarDisco.ShowDialog();
            cargar();
        }
    }
}
