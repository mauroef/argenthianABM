using CapaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class GrillaCiudad : GrillaBase
    {
        #region Propiedades

        CiudadModel ciudad = new CiudadModel();

        #endregion

        #region Inicializacion

        public GrillaCiudad()
        {
            InitializeComponent();
            Cargar();
        }

        public override void Refrescar()
        {
            Cargar();
            DataGridViewCiudad.Refresh();
        }

        public override void Cargar()
        {
            DataGridViewCiudad.DataSource = ciudad.ObtenerDatos();

            SetearAcciones(DataGridViewCiudad, 2);
        }

        #endregion

        #region Eventos

        public override void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioCiudad formulario = new FormularioCiudad(null, this);

            formulario.Show();
        }

        private void DataGridViewCarpinteria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DataGridViewCiudad.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == DataGridViewCiudad.Columns["btEliminar"].Index)
            {
                short id = (short)DataGridViewCiudad.Rows[e.RowIndex].Cells["id"].Value;
                string nombre = (string)DataGridViewCiudad.Rows[e.RowIndex].Cells["nombre"].Value;
                DialogResult preguntaResultado = MessageBox.Show("Está a punto de eliminar la ciudad " + nombre + ". ¿Está seguro?", "Atención", MessageBoxButtons.YesNo);

                if (preguntaResultado == DialogResult.Yes && id > 0)
                {
                    if (ciudad.EliminarPorId(id))
                    {
                        MessageBox.Show("La ciudad " + nombre + " fue eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar la ciudad " + nombre + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.ColumnIndex == DataGridViewCiudad.Columns["btEditar"].Index)
            {
                short id = (short)DataGridViewCiudad.Rows[e.RowIndex].Cells["id"].Value;

                if (id > 0)
                {
                    FormularioCiudad formulario = new FormularioCiudad(ciudad.ObtenerPorId(id), this);

                    formulario.Show();
                }
            }
        }

        #endregion
    }
}
