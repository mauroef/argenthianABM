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

        private void DataGridViewObjeto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DataGridViewObjeto.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == DataGridViewObjeto.Columns["btEliminar"].Index)
            {
                short id = (short)DataGridViewObjeto.Rows[e.RowIndex].Cells["id"].Value;
                string nombre = (string)DataGridViewObjeto.Rows[e.RowIndex].Cells["nombre"].Value;

                if (id > 0)
                {
                    if (objeto.EliminarPorId(id))
                    {
                        MessageBox.Show("El objeto " + nombre + " fue eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el objeto " + nombre + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioObjeto formulario = new FormularioObjeto();

            formulario.Show();
        }
    }
}
