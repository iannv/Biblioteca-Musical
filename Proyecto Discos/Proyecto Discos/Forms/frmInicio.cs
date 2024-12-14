using Proyecto_Discos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Discos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnListadoDiscos_Click(object sender, EventArgs e)
        {
            Form listadoDiscos = new frmGrillaDiscos();
            listadoDiscos.Show();
            this.Hide();
        }
    }
}
