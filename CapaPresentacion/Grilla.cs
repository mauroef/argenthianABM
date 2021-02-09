using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Modelos;
using Newtonsoft.Json;

namespace CapaPresentacion
{
    public partial class Grilla : Form
    {
         ObjetoModel objeto = new ObjetoModel();

        public Grilla()
        {
            InitializeComponent();
            MostrarObjetos();
        }

        private void MostrarObjetos()
        {
            dataGridView1.DataSource = objeto.MostrarDatos();
        }
    }
}
