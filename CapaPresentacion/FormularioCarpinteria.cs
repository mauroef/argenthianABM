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
    public partial class FormularioCarpinteria : FormularioBase
    {
        #region Propiedades

        CarpinteriaModel carpinteriaModel = new CarpinteriaModel();

        private readonly GrillaCarpinteria grilla;

        #endregion

        #region Inicializacion

        public FormularioCarpinteria(CarpinteriaModel c, GrillaCarpinteria grilla)
        {
            InitializeComponent();
            InicializarCombos();

            if (c != null)
            {
                carpinteriaModel.Id = c.Id;
                MapearFormulario(c);
            }

            this.grilla = grilla;
            this.grilla.Enabled = false;
        }

        private void MapearFormulario(CarpinteriaModel c)
        { 
        
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
                short id = carpinteriaModel.Id;
                carpinteriaModel = carpinteriaModel.MapearCarpinteriaModel(TxSkills.Text, TxMadera.Text, CbObjeto.SelectedValue.ToString());

                if (carpinteriaModel.ValidarDatos(carpinteriaModel))
                {
                    if (id == 0 && carpinteriaModel.GuadarDatos(carpinteriaModel))
                    {
                        MessageBox.Show("El objeto fue agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                        RefrescarGrillaPrincipal();
                        LimpiarFormulario();
                    }
                    else if (carpinteriaModel.EditarPorId(id, carpinteriaModel))
                    {
                        MessageBox.Show("El objeto fue editado correctamente.", "Éxito", MessageBoxButtons.OK);
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
            TxSkills.Text = String.Empty;
            TxMadera.Text = String.Empty;
            CbObjeto.SelectedItem = null;
        } 

        #endregion

        #region Validaciones

        private bool ValidarDatosFormulario()
        {
            return !(String.IsNullOrEmpty(TxSkills.Text) && String.IsNullOrEmpty(TxMadera.Text)) &&
                    (CbObjeto.SelectedValue != null);
        }

        #endregion

        #region Combos

        private void InicializarCombos()
        {
            CbObjeto.DataSource = new BindingSource(ObtenerDatosObjeto(), null);
            CbObjeto.DisplayMember = "Value";
            CbObjeto.ValueMember = "Key";
        }

        private Dictionary<short, string> ObtenerDatosObjeto()
        {
            Dictionary<short, string> o = new Dictionary<short, string>();

            foreach (var item in ObjetoModel.ObtenerListado())
            {
                o.Add(item.id, item.nombre);
            }

            return o;
        }

        #endregion
    }
}
