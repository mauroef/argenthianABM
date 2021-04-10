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
    public partial class GrillaHabilidad : GrillaBase
    {
        #region Propiedades

        HabilidadModel habilidad = new HabilidadModel();

        #endregion

        #region Inicializacion

        public GrillaHabilidad()
        {
            InitializeComponent();
            Cargar();
        }

        public override void Refrescar()
        {
            Cargar();
            DataGridViewHabilidad.Refresh();
        }

        public override void Cargar()
        {
            DataGridViewHabilidad.DataSource = habilidad.ObtenerDatos();

            SetearAcciones(DataGridViewHabilidad, 2);
        }

        #endregion

        #region Eventos

        public override void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioHabilidad formulario = new FormularioHabilidad(null, this);

            formulario.Show();
        }

        private void DataGridViewHabilidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DataGridViewHabilidad.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == DataGridViewHabilidad.Columns["btEliminar"].Index)
            {
                short id = (short)DataGridViewHabilidad.Rows[e.RowIndex].Cells["id"].Value;
                string nombre = (string)DataGridViewHabilidad.Rows[e.RowIndex].Cells["nombre"].Value;
                DialogResult preguntaResultado = MessageBox.Show("Está a punto de eliminar la habilidad " + nombre + ". ¿Está seguro?", "Atención", MessageBoxButtons.YesNo);

                if (preguntaResultado == DialogResult.Yes && id > 0)
                {
                    if (habilidad.EliminarPorId(id))
                    {
                        MessageBox.Show("La habilidad " + nombre + " fue eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar la habilidad " + nombre + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.ColumnIndex == DataGridViewHabilidad.Columns["btEditar"].Index)
            {
                short id = (short)DataGridViewHabilidad.Rows[e.RowIndex].Cells["id"].Value;

                if (id > 0)
                {
                    FormularioHabilidad formulario = new FormularioHabilidad(habilidad.ObtenerPorId(id), this);

                    formulario.Show();
                }
            }
        }

        #endregion
    }
}
