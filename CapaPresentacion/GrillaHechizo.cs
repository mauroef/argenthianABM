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
    public partial class GrillaHechizo : GrillaBase
    {
        #region Propiedades

        HechizoModel hechizo = new HechizoModel();

        #endregion

        #region Inicializacion

        public GrillaHechizo()
        {
            InitializeComponent();
            Cargar();
        }

        public override void Refrescar()
        {
            Cargar();
            DataGridViewHechizo.Refresh();
        }

        public override void Cargar()
        {
            DataGridViewHechizo.DataSource = hechizo.ObtenerDatos();

            SetearAcciones(DataGridViewHechizo, 8);
        }

        #endregion

        #region Eventos

        public override void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioHechizo formulario = new FormularioHechizo(null, this);

            formulario.Show();
        }

        private void DataGridViewObjeto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DataGridViewHechizo.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == DataGridViewHechizo.Columns["btEliminar"].Index)
            {
                short id = (short)DataGridViewHechizo.Rows[e.RowIndex].Cells["id"].Value;
                string nombre = (string)DataGridViewHechizo.Rows[e.RowIndex].Cells["nombre"].Value;
                DialogResult preguntaResultado = MessageBox.Show("Está a punto de eliminar el objeto " + nombre + ". ¿Está seguro?", "Atención", MessageBoxButtons.YesNo);

                if (preguntaResultado == DialogResult.Yes && id > 0)
                {
                    if (hechizo.EliminarPorId(id))
                    {
                        MessageBox.Show("El objeto " + nombre + " fue eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el objeto " + nombre + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.ColumnIndex == DataGridViewHechizo.Columns["btEditar"].Index)
            {
                short id = (short)DataGridViewHechizo.Rows[e.RowIndex].Cells["id"].Value;

                if (id > 0)
                {
                    FormularioHechizo formulario = new FormularioHechizo(hechizo.ObtenerPorId(id), this);

                    formulario.Show();
                }
            }
        }

        #endregion
    }
}
