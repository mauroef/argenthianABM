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
    public partial class FormularioHabilidad : FormularioBase
    {
        #region Propiedades

        HabilidadModel habilidadModel = new HabilidadModel();

        private readonly GrillaHabilidad grilla;

        #endregion

        #region Inicializacion

        public FormularioHabilidad(HabilidadModel h, GrillaHabilidad grilla)
        {
            InitializeComponent();

            if (h != null)
            {
                habilidadModel.Id = h.Id;
                MapearFormulario(h);
            }

            this.grilla = grilla;
            this.grilla.Enabled = false;
        }

        private void MapearFormulario(HabilidadModel h)
        {
            TxNombre.Text = h.Nombre.ToString();
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
                short id = habilidadModel.Id;
                habilidadModel = habilidadModel.MapearHabilidadModel(TxNombre.Text);

                if (habilidadModel.ValidarDatos(habilidadModel))
                {
                    if (id == 0 && habilidadModel.GuadarDatos(habilidadModel))
                    {
                        MessageBox.Show("La habilidad fue agregada correctamente.", "Éxito", MessageBoxButtons.OK);
                        RefrescarGrillaPrincipal();
                        LimpiarFormulario();
                    }
                    else if (habilidadModel.EditarPorId(id, habilidadModel))
                    {
                        MessageBox.Show("La habilidad fue editada correctamente.", "Éxito", MessageBoxButtons.OK);
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
