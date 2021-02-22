using CapaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormularioObjeto : Form
    {
        ObjetoModel objetoModel = new ObjetoModel();

        public FormularioObjeto()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (ValidarDatosFormulario())
            {
                objetoModel = objetoModel.MapearObjetoModel(TxNombre.Text, TxPrecio.Text, /*CbTipo.SelectedValue.ToString()*/"1", /*CbSonido.SelectedValue.ToString()*/"1", /*CbImagen.SelectedValue.ToString()*/"1",
                                        /*CbModelo3d.SelectedValue.ToString()*/"1", /*CbHechizo.SelectedValue.ToString()*/"1", TxSalud.Text, TxMana.Text, TxHambre.Text,
                                        TxSed.Text, TxFuerza.Text, TxAgilidad.Text, TxPeso.Text, TxMinDanio.Text,
                                        TxMaxDanio.Text, TxMinDanioMagico.Text, TxMaxDanioMagico.Text, TxMinDefensaCasco.Text, TxMaxDefensaCasco.Text,
                                        TxMinDefensaCuerpo.Text, TxMaxDefensaCuerpo.Text, TxMinDefensaMagica.Text, TxMaxDefensaMagica.Text);

                if (objetoModel.ValidarDatos(objetoModel) && objetoModel.GuadarDatos(objetoModel))
                {
                    MessageBox.Show("El objeto fue agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar el objeto.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se permite campos vacíos!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private bool ValidarDatosFormulario()
        {
            return !(String.IsNullOrEmpty(TxNombre.Text) && String.IsNullOrEmpty(TxPrecio.Text) && String.IsNullOrEmpty(TxSalud.Text) && String.IsNullOrEmpty(TxMana.Text) &&
                String.IsNullOrEmpty(TxMana.Text) && String.IsNullOrEmpty(TxHambre.Text) && String.IsNullOrEmpty(TxSed.Text) && String.IsNullOrEmpty(TxFuerza.Text) &&
                String.IsNullOrEmpty(TxAgilidad.Text) && String.IsNullOrEmpty(TxPeso.Text) && String.IsNullOrEmpty(TxMinDanio.Text) && String.IsNullOrEmpty(TxMaxDanio.Text) &&
                String.IsNullOrEmpty(TxMinDanioMagico.Text) && String.IsNullOrEmpty(TxMaxDanioMagico.Text) && String.IsNullOrEmpty(TxMinDefensaCasco.Text) && String.IsNullOrEmpty(TxMaxDefensaCasco.Text) &&
                String.IsNullOrEmpty(TxMinDefensaCuerpo.Text) && String.IsNullOrEmpty(TxMaxDefensaCuerpo.Text) && String.IsNullOrEmpty(TxMinDefensaMagica.Text) && String.IsNullOrEmpty(TxMaxDefensaMagica.Text));
        }
    }
}
