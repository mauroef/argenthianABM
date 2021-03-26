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
    public partial class GrillaCarpinteria : GrillaBase
    {
        #region Propiedades

        CarpinteriaModel carpinteria = new CarpinteriaModel();

        #endregion

        #region Inicializacion

        public GrillaCarpinteria()
        {
            InitializeComponent();
            Cargar();
        }

        public override void Refrescar()
        {
            Cargar();
            DataGridViewCarpinteria.Refresh();
        }

        public override void Cargar()
        {
            DataGridViewCarpinteria.DataSource = carpinteria.ObtenerDatos();

            SetearAcciones(DataGridViewCarpinteria, 4);
        }

        #endregion

        #region Eventos

        public override void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioCarpinteria formulario = new FormularioCarpinteria(null, this);

            formulario.Show();
        }

        private void DataGridViewCarpinteria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DataGridViewCarpinteria.NewRowIndex || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == DataGridViewCarpinteria.Columns["btEliminar"].Index)
            {
                short id = (short)DataGridViewCarpinteria.Rows[e.RowIndex].Cells["id"].Value;
                DialogResult preguntaResultado = MessageBox.Show("Está a punto de eliminar el objeto " + id + ". ¿Está seguro?", "Atención", MessageBoxButtons.YesNo);

                if (preguntaResultado == DialogResult.Yes && id > 0)
                {
                    if (carpinteria.EliminarPorId(id))
                    {
                        MessageBox.Show("El objeto " + id + " fue eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el objeto " + id + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.ColumnIndex == DataGridViewCarpinteria.Columns["btEditar"].Index)
            {
                short id = (short)DataGridViewCarpinteria.Rows[e.RowIndex].Cells["id"].Value;

                if (id > 0)
                {
                    FormularioCarpinteria formulario = new FormularioCarpinteria(carpinteria.ObtenerPorId(id), this);

                    formulario.Show();
                }
            }
        }

        #endregion
    }
}
