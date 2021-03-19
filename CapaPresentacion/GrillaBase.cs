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
    public partial class GrillaBase : Form
    {
        public GrillaBase()
        {
            InitializeComponent();
        }

        #region UI

        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return cp;
            }
        }

        public virtual void Refrescar() { }

        public virtual void Cargar() { }

        public void SetearAcciones(DataGridView dataGridView, int nroColumna)
        {
            if (dataGridView.Columns.Count == nroColumna)
            {
                dataGridView.Columns.Add(SetearBoton("btEliminar", "Eliminar"));
                dataGridView.Columns.Add(SetearBoton("btEditar", "Editar"));
            }
        }

        public DataGridViewButtonColumn SetearBoton(string nombre, string texto)
        {
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();

            boton.Name = nombre;
            boton.HeaderText = texto;
            boton.Text = texto;
            boton.UseColumnTextForButtonValue = true;

            return boton;
        }

        public virtual void Deshabilitar(bool flag)
        {
            this.Enabled = flag;
        }

        #endregion

        #region Eventos

        public virtual void BtNuevo_Click(object sender, EventArgs e) { }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion
    }
}
