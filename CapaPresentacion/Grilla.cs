using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Objeto;
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
            DataTable tabla = objeto.ObtenerDatos();

            var btEliminar = SetearBotonEliminar();

            DataGridViewObjeto.DataSource = tabla;
            DataGridViewObjeto.Columns.Add(btEliminar);
            
        }

        private DataGridViewButtonColumn SetearBotonEliminar()
        {
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();

            boton.Name = "btEliminar";
            boton.HeaderText = "Eliminar";
            boton.Text = "Eliminar";
            boton.UseColumnTextForButtonValue = true;

            return boton;
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            objeto.nombre = "nuevo";

            if (!objeto.GuadarDatos(objeto))
            {
                MessageBox.Show("Hubvo un problema al guardar el objeto", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewObjeto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == DataGridViewObjeto.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == DataGridViewObjeto.Columns["btEliminar"].Index)
            {
                int indice = e.RowIndex;
            }
        }
    }
}
