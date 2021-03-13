using CapaNegocio.Modelos;
using CapaNegocio;
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
        #region Propiedades

        ObjetoModel objetoModel = new ObjetoModel();

        private readonly GrillaObjeto grilla;

        #endregion

        #region Inicializacion

        public FormularioObjeto(ObjetoModel o, GrillaObjeto grilla)
        {
            InitializeComponent();
            InicializarCombos();
            InicializarListBox();

            if (o != null)
            {
                objetoModel.Id = o.Id;
                MapearFormulario(o);
            }

            this.grilla = grilla;
            this.grilla.Enabled = false;
        }

        private void MapearFormulario(ObjetoModel o)
        {
            MapearFormularioBase(o);
            MapearFormularioEquipo(o.Equipo);
            MapearFormularioEstadisticas(o.Estadisticas);
            MapearFormularioClasesNoPermitidas(o.ClasesNoPermitidas);
        }

        private void MapearFormularioBase(ObjetoModel o)
        {
            TxNombre.Text = o.Nombre;
            TxPrecio.Text = o.Precio.ToString();
            CbTipo.SelectedValue = o.Tipo;
            CbSonido.SelectedValue = (short)o.IdSonido;
            CbImagen.SelectedValue = (short)o.IdImagen;
            CbModelo3d.SelectedValue = (short)o.IdModelo3d;
            CbHechizo.SelectedValue = o.IdHechizo;
        }

        private void MapearFormularioEquipo(EquipoModel e)
        {
            TxMinDanio.Text = e.MinDaño.ToString();
            TxMaxDanio.Text = e.MaxDaño.ToString();
            TxMinDanioMagico.Text = e.MinDañoMagico.ToString();
            TxMaxDanioMagico.Text = e.MaxDañoMagico.ToString();
            TxMinDefensaCasco.Text = e.MinDefCasco.ToString();
            TxMaxDefensaCasco.Text = e.MaxDefCasco.ToString();
            TxMinDefensaCuerpo.Text = e.MinDefCuerpo.ToString();
            TxMaxDefensaCuerpo.Text = e.MaxDefCuerpo.ToString();
            TxMinDefensaMagica.Text = e.MinDefMagica.ToString();
            TxMaxDefensaMagica.Text = e.MaxDefMagica.ToString();
        }

        private void MapearFormularioEstadisticas(EstadisticasModel e)
        {
            TxSalud.Text = e.Salud.ToString();
            TxMana.Text = e.Mana.ToString();
            TxHambre.Text = e.Hambre.ToString();
            TxSed.Text = e.Sed.ToString();
            TxFuerza.Text = e.Fuerza.ToString();
            TxAgilidad.Text = e.Agilidad.ToString();
            TxPeso.Text = e.Peso.ToString();
        }

        private void MapearFormularioClasesNoPermitidas(List<short> clasesNoPermitidas)
        {
            LbxClasesNo.SetSelected(0, false);

            foreach (short clase in clasesNoPermitidas)
            {
                LbxClasesNo.SetSelected((short)(clase - 1), true);
            }
        }

        #endregion

        #region Eventos

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (ValidarDatosFormulario())
            {
                short id = objetoModel.Id;
                objetoModel = objetoModel.MapearObjetoModel(TxNombre.Text, TxPrecio.Text, CbTipo.SelectedValue.ToString(), CbSonido.SelectedValue.ToString(), CbImagen.SelectedValue.ToString(),
                                                            CbModelo3d.SelectedValue.ToString(), CbHechizo.SelectedValue.ToString(), ObtenerValoresListBox(), TxSalud.Text, TxMana.Text,
                                                            TxHambre.Text, TxSed.Text, TxFuerza.Text, TxAgilidad.Text, TxPeso.Text,
                                                            TxMinDanio.Text, TxMaxDanio.Text, TxMinDanioMagico.Text, TxMaxDanioMagico.Text, TxMinDefensaCasco.Text,
                                                            TxMaxDefensaCasco.Text, TxMinDefensaCuerpo.Text, TxMaxDefensaCuerpo.Text, TxMinDefensaMagica.Text, TxMaxDefensaMagica.Text);

                if (objetoModel.ValidarDatos(objetoModel))
                {
                    if (id == 0 && objetoModel.GuadarDatos(objetoModel))
                    {
                        MessageBox.Show("El objeto fue agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                        RefrescarGrillaPrincipal();
                        LimpiarFormulario();
                    }
                    else if (objetoModel.EditarPorId(id, objetoModel))
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
                    MessageBox.Show("Hubo un problema al validar los datos el objeto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se permiten campos vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (caracter == 46 && TxPrecio.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(caracter) && caracter != 8 && caracter != 46)
            {
                e.Handled = true;
            }
        }

        private void CerrarFormulario()
        {
            this.Close();
            this.grilla.Enabled = true;
            this.grilla.Focus();
        }

        private void RefrescarGrillaPrincipal()
        {
            this.grilla.RefrescarGrilla();
        }

        private void LimpiarFormulario()
        {
            TxNombre.Text = String.Empty;
            TxPrecio.Text = String.Empty;
            CbTipo.SelectedItem = null;
            CbSonido.SelectedItem = null;
            CbImagen.SelectedItem = null;
            CbModelo3d.SelectedItem = null;
            CbHechizo.SelectedItem = null;
            TxSalud.Text = String.Empty;
            TxMana.Text = String.Empty;
            TxHambre.Text = String.Empty;
            TxSed.Text = String.Empty;
            TxFuerza.Text = String.Empty;
            TxAgilidad.Text = String.Empty;
            TxPeso.Text = String.Empty;
            TxMinDanio.Text = String.Empty;
            TxMaxDanio.Text = String.Empty;
            TxMinDanioMagico.Text = String.Empty;
            TxMaxDanioMagico.Text = String.Empty;
            TxMinDefensaCasco.Text = String.Empty;
            TxMaxDefensaCasco.Text = String.Empty;
            TxMinDefensaCuerpo.Text = String.Empty;
            TxMaxDefensaCuerpo.Text = String.Empty;
            TxMinDefensaMagica.Text = String.Empty;
            TxMaxDefensaMagica.Text = String.Empty;

            LbxClasesNo.SelectedItem = null;
        }

        #endregion

        #region Validaciones

        private bool ValidarDatosFormulario()
        {
            return !(String.IsNullOrEmpty(TxNombre.Text) || String.IsNullOrEmpty(TxPrecio.Text) || String.IsNullOrEmpty(TxSalud.Text) || String.IsNullOrEmpty(TxMana.Text) ||
                String.IsNullOrEmpty(TxMana.Text) || String.IsNullOrEmpty(TxHambre.Text) || String.IsNullOrEmpty(TxSed.Text) && String.IsNullOrEmpty(TxFuerza.Text) &&
                String.IsNullOrEmpty(TxAgilidad.Text) || String.IsNullOrEmpty(TxPeso.Text) || String.IsNullOrEmpty(TxMinDanio.Text) || String.IsNullOrEmpty(TxMaxDanio.Text) ||
                String.IsNullOrEmpty(TxMinDanioMagico.Text) || String.IsNullOrEmpty(TxMaxDanioMagico.Text) || String.IsNullOrEmpty(TxMinDefensaCasco.Text) || String.IsNullOrEmpty(TxMaxDefensaCasco.Text) &&
                String.IsNullOrEmpty(TxMinDefensaCuerpo.Text) || String.IsNullOrEmpty(TxMaxDefensaCuerpo.Text) || String.IsNullOrEmpty(TxMinDefensaMagica.Text) || String.IsNullOrEmpty(TxMaxDefensaMagica.Text)) &&
                (CbTipo.SelectedValue != null && CbSonido.SelectedValue != null && CbImagen != null && CbModelo3d != null && CbHechizo.SelectedValue != null);
        }

        #endregion

        #region Combos

        private void InicializarCombos()
        {
            var dict = new Dictionary<short, string>();
            dict.Add(1, "Uno");
            dict.Add(2, "Dos");
            dict.Add(3, "Tres");

            CbTipo.DataSource = new BindingSource(ObtenerDatosTipoObjeto(), null);
            CbTipo.DisplayMember = "Value";
            CbTipo.ValueMember = "Key";

            CbSonido.DataSource = new BindingSource(ObtenerDatosSonido(), null);
            CbSonido.DisplayMember = "Value";
            CbSonido.ValueMember = "Key";

            CbImagen.DataSource = new BindingSource(ObtenerDatosImagen(), null);
            CbImagen.DisplayMember = "Value";
            CbImagen.ValueMember = "Key";

            // TODO: falta enumeracion
            CbModelo3d.DataSource = new BindingSource(dict, null);
            CbModelo3d.DisplayMember = "Value";
            CbModelo3d.ValueMember = "Key";

            CbHechizo.DataSource = new BindingSource(ObtenerDatosHechizo(), null);
            CbHechizo.DisplayMember = "Value";
            CbHechizo.ValueMember = "Key";
        }

        private Dictionary<short, string> ObtenerDatosTipoObjeto()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.TipoObjeto.Capa, "Capa");
            d.Add((short)Enumeraciones.TipoObjeto.Colgante, "Colgante");
            d.Add((short)Enumeraciones.TipoObjeto.Anillo, "Anillo");
            d.Add((short)Enumeraciones.TipoObjeto.Escudo, "Escudo");
            d.Add((short)Enumeraciones.TipoObjeto.Arma, "Arma");
            d.Add((short)Enumeraciones.TipoObjeto.Casco, "Casco");
            d.Add((short)Enumeraciones.TipoObjeto.Vestimenta, "Vestimenta");
            d.Add((short)Enumeraciones.TipoObjeto.Guantes, "Guantes");
            d.Add((short)Enumeraciones.TipoObjeto.Pantalon, "Pantalon");
            d.Add((short)Enumeraciones.TipoObjeto.Zapatos, "Zapatos");
            d.Add((short)Enumeraciones.TipoObjeto.Utilizable, "Utilizable");
            d.Add((short)Enumeraciones.TipoObjeto.Hechizo, "Hechizo");
            d.Add((short)Enumeraciones.TipoObjeto.Recurso, "Recurso");
            d.Add((short)Enumeraciones.TipoObjeto.Barco, "Barco");
            d.Add((short)Enumeraciones.TipoObjeto.Flecha, "Flecha");
            d.Add((short)Enumeraciones.TipoObjeto.Arbol, "Arbol");
            d.Add((short)Enumeraciones.TipoObjeto.Mina, "Mina");
            d.Add((short)Enumeraciones.TipoObjeto.HachaLeñador, "Hacha Leñador");
            d.Add((short)Enumeraciones.TipoObjeto.PiqueteMinero, "Piquete Minero");
            d.Add((short)Enumeraciones.TipoObjeto.Otros, "Otros");
            d.Add((short)Enumeraciones.TipoObjeto.Proyectil, "Proyectil");
            d.Add((short)Enumeraciones.TipoObjeto.Madera, "Madera");
            d.Add((short)Enumeraciones.TipoObjeto.Hierro, "Hierro");
            d.Add((short)Enumeraciones.TipoObjeto.Plata, "Plata");
            d.Add((short)Enumeraciones.TipoObjeto.Oro, "Oro");
            d.Add((short)Enumeraciones.TipoObjeto.Serrucho, "Serrucho");
            d.Add((short)Enumeraciones.TipoObjeto.Martillo, "Martillo");

            return d;
        }

        private Dictionary<short, string> ObtenerDatosSonido()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.Sonido.SinSonido, "Sin Sonido");
            d.Add((short)Enumeraciones.Sonido.Fallar, "Fallar");
            d.Add((short)Enumeraciones.Sonido.Sangre, "Sangre");
            d.Add((short)Enumeraciones.Sonido.Golpe, "Golpe");
            d.Add((short)Enumeraciones.Sonido.Escudo, "Escudo");
            d.Add((short)Enumeraciones.Sonido.Muerte, "Muerte");
            d.Add((short)Enumeraciones.Sonido.Equipar, "Equipar");
            d.Add((short)Enumeraciones.Sonido.ClickInventario, "Click Inventario");
            d.Add((short)Enumeraciones.Sonido.ClickMouse, "Click Mouse");
            d.Add((short)Enumeraciones.Sonido.SubirNivel, "Subir Nivel");
            d.Add((short)Enumeraciones.Sonido.GolpearCriatura, "Golpear Criatura");
            d.Add((short)Enumeraciones.Sonido.EspadazoNormal, "Espadazo Normal");

            return d;
        }

        private Dictionary<short, string> ObtenerDatosImagen()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.Imagen.Espada, "Espada");
            d.Add((short)Enumeraciones.Imagen.EscudoSeguro, "Escudo Seguro");

            return d;
        }

        private Dictionary<short, string> ObtenerDatosHechizo()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.TipoHechizo.Ataque, "Ataque");
            d.Add((short)Enumeraciones.TipoHechizo.Sanacion, "Sanación");
            d.Add((short)Enumeraciones.TipoHechizo.Paralizar, "Paralizar");
            d.Add((short)Enumeraciones.TipoHechizo.Inmovilizar, "Inmovilizar");
            d.Add((short)Enumeraciones.TipoHechizo.Envenenar, "Envenenar");
            d.Add((short)Enumeraciones.TipoHechizo.CurarVeneno, "Curar Veneno");
            d.Add((short)Enumeraciones.TipoHechizo.Otro, "Otro");

            return d;
        }

        #endregion

        #region ListBox

        private void InicializarListBox()
        {
            LbxClasesNo.DataSource = new BindingSource(ObtenerDatosClases(), null);
            LbxClasesNo.DisplayMember = "Value";
            LbxClasesNo.ValueMember = "Key";
        }

        private Dictionary<short, string> ObtenerDatosClases()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.Clase.Guerrero, "Guerrero");
            d.Add((short)Enumeraciones.Clase.Paladin, "Paladín");
            d.Add((short)Enumeraciones.Clase.Asesino, "Asesino");
            d.Add((short)Enumeraciones.Clase.Clerigo, "Clérigo");
            d.Add((short)Enumeraciones.Clase.Mago, "Mago");
            d.Add((short)Enumeraciones.Clase.Campesino, "Campesino");

            return d;
        }

        private List<short> ObtenerValoresListBox()
        {
            List<short> lista = new List<short>();

            foreach (KeyValuePair<short, string> item in LbxClasesNo.SelectedItems)
            {
                lista.Add(item.Key);
            }

            return lista;
        }

        #endregion        
    }
}
