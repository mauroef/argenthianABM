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
    public partial class FormularioCiudad : FormularioBase
    {
        #region Propiedades

        CiudadModel ciudadModel = new CiudadModel();

        private readonly GrillaCiudad grilla;

        #endregion

        #region Inicializacion

        public FormularioCiudad(CiudadModel c, GrillaCiudad grilla)
        {
            InitializeComponent();

            if (c != null)
            {
                ciudadModel.Id = c.Id;
                MapearFormulario(c);
            }

            this.grilla = grilla;
            this.grilla.Enabled = false;
        }

        private void MapearFormulario(CiudadModel c)
        {
            TxNombre.Text = c.Nombre.ToString();
        }

        #endregion

        #region Eventos

        public override void BtCancelar_Click(object sender, EventArgs e)
        {
            this.CerrarFormulario();
        }

        public override void BtGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosFormulario())
            {
                short id = ciudadModel.Id;
                ciudadModel = ciudadModel.MapearCiudadModel(TxNombre.Text);

                if (ciudadModel.ValidarDatos(ciudadModel))
                {
                    if (id == 0 && ciudadModel.GuadarDatos(ciudadModel))
                    {
                        MessageBox.Show("La ciudad fue agregada correctamente.", "Éxito", MessageBoxButtons.OK);
                        RefrescarGrillaPrincipal();
                        LimpiarFormulario();
                    }
                    else if (ciudadModel.EditarPorId(id, ciudadModel))
                    {
                        MessageBox.Show("La ciudad fue editada correctamente.", "Éxito", MessageBoxButtons.OK);
                        RefrescarGrillaPrincipal();
                        CerrarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al procesar la operación.", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un problema al validar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se permiten campos vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CerrarFormulario()
        {
            this.grilla.Deshabilitar(true);
            this.grilla.Focus();
            this.Hide();
        }

        private void RefrescarGrillaPrincipal()
        {
            this.grilla.Refrescar();
        }

        private void LimpiarFormulario()
        {
            TxNombre.Text = string.Empty;
        }

        #endregion

        #region Validaciones

        private bool ValidarDatosFormulario()
        {
            return !String.IsNullOrEmpty(TxNombre.Text);
        }

        #endregion
    }
}
