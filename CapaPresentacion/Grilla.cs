using CapaNegocio.Modelos;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Grilla : Form
    {
        #region Propiedades

        ObjetoModel objeto = new ObjetoModel();

        #endregion

        #region Inicializacion

        public Grilla()
        {
            InitializeComponent();
            MostrarObjetos();
        }

        private void MostrarObjetos()
        {
            DataGridViewObjeto.DataSource = objeto.ObtenerDatos();
            DataGridViewObjeto.Columns.Add(SetearBoton("btEliminar", "Eliminar"));
            DataGridViewObjeto.Columns.Add(SetearBoton("btEditar", "Editar"));
        }

        private DataGridViewButtonColumn SetearBoton(string nombre, string texto)
        {
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();

            boton.Name = nombre;
            boton.HeaderText = texto;
            boton.Text = texto;
            boton.UseColumnTextForButtonValue = true;

            return boton;
        }

        #endregion

        #region Eventos

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioObjeto formulario = new FormularioObjeto();

            formulario.Show();
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

            if (e.ColumnIndex == DataGridViewObjeto.Columns["btEditar"].Index)
            {
                short id = (short)DataGridViewObjeto.Rows[e.RowIndex].Cells["id"].Value;                

                if (id > 0)
                {
                    FormularioObjeto formulario = new FormularioObjeto(objeto.ObtenerPorId(id));

                    formulario.Show();
                    
                }
            }
        }

        #endregion
    }
}
