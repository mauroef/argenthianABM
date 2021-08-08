using CapaNegocio;
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
    public partial class FormularioHechizo : FormularioBase
    {
        #region Propiedades

        HechizoModel hechizoModel = new HechizoModel();

        private readonly GrillaHechizo grilla;

        #endregion

        #region Inicializacion

        public FormularioHechizo(HechizoModel h, GrillaHechizo grilla)
        {
            // TODO: debuggear nuevo
            // manejar el eliminar | editar
            InitializeComponent();
            InicializarCombos();

            if (h != null)
            {
                hechizoModel.Id = h.Id;
                MapearFormulario(h);
            }

            this.grilla = grilla;
            this.grilla.Enabled = false;
        }

        private void MapearFormulario(HechizoModel h)
        {
            MapearFormularioBase(h);
            MapearFormularioConsumo(h.Consumo);
            MapearFormularioTemporales(h.Temporales);
            MapearFormularioAtaque(h.Ataque);
        }

        private void MapearFormularioAtaque(AtaqueModel ataque)
        {
            throw new NotImplementedException();
        }

        private void MapearFormularioTemporales(TemporalesModel temporales)
        {
            throw new NotImplementedException();
        }

        private void MapearFormularioConsumo(ConsumoModel consumo)
        {
            throw new NotImplementedException();
        }

        private void MapearFormularioBase(HechizoModel h)
        {
            throw new NotImplementedException();
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
                short id = hechizoModel.Id;
                hechizoModel = hechizoModel.MapearHechizoModel(CbTipo.SelectedValue.ToString(), TxNombre.Text, CbImagen.SelectedValue.ToString(), CbImagen.SelectedValue.ToString(), CbSonido.SelectedValue.ToString(),
                                                                TxDescripcion.Text, TxPalabrasMagicas.Text, TxMaxMana.Text, TxMinMana.Text, TxMaxEnergia.Text,
                                                                TxMinEnergia.Text, TxParalizar.Text, TxInmovilizar.Text, TxCongelar.Text, TxMaxDaño.Text,
                                                                TxMinDaño.Text, CbEnvenar.Checked);

                if (hechizoModel.ValidarDatos(hechizoModel))
                {
                    if (id == 0 && hechizoModel.GuadarDatos(hechizoModel))
                    {
                        MessageBox.Show("El hechizo fue agregado correctamente.", "Éxito", MessageBoxButtons.OK);
                        RefrescarGrillaPrincipal();
                        LimpiarFormulario();
                    }
                    else if (hechizoModel.EditarPorId(id, hechizoModel))
                    {
                        MessageBox.Show("El hechizo fue editado correctamente.", "Éxito", MessageBoxButtons.OK);
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
                    MessageBox.Show("Hubo un problema al validar los datos del hechizo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CbTipo.SelectedItem = null;
            TxNombre.Text = String.Empty;
            CbTipo.SelectedItem = null;
            CbSonido.SelectedItem = null;
            CbImagen.SelectedItem = null;
            CbEfecto.SelectedItem = null;
            CbSonido.SelectedItem = null;
            TxDescripcion.Text = String.Empty;
            TxPalabrasMagicas.Text = String.Empty;
            TxMaxMana.Text = String.Empty;
            TxMinMana.Text = String.Empty;
            TxMaxEnergia.Text = String.Empty;
            TxMinEnergia.Text = String.Empty;
            TxParalizar.Text = String.Empty;
            TxInmovilizar.Text = String.Empty;
            TxCongelar.Text = String.Empty;
            TxMaxDaño.Text = String.Empty;
            TxMinDaño.Text = String.Empty;
            CbEnvenar.Checked = false;
        }

        #endregion

        #region Validaciones

        private bool ValidarDatosFormulario()
        {
            return !(String.IsNullOrEmpty(TxNombre.Text) || String.IsNullOrEmpty(TxDescripcion.Text) || String.IsNullOrEmpty(TxPalabrasMagicas.Text) || String.IsNullOrEmpty(TxMaxMana.Text) || String.IsNullOrEmpty(TxMinMana.Text) ||
                    String.IsNullOrEmpty(TxMaxMana.Text) || String.IsNullOrEmpty(TxMinMana.Text) || String.IsNullOrEmpty(TxParalizar.Text) || String.IsNullOrEmpty(TxInmovilizar.Text) || String.IsNullOrEmpty(TxCongelar.Text) ||
                    String.IsNullOrEmpty(TxMaxDaño.Text) || String.IsNullOrEmpty(TxMinDaño.Text));
        }

        #endregion

        #region Combos

        private void InicializarCombos()
        {
            CbTipo.DataSource = new BindingSource(ObtenerDatosTipoHechizo(), null);
            CbTipo.DisplayMember = "Value";
            CbTipo.ValueMember = "Key";

            CbImagen.DataSource = new BindingSource(ObtenerDatosImagen(), null);
            CbImagen.DisplayMember = "Value";
            CbImagen.ValueMember = "Key";

            CbEfecto.DataSource = new BindingSource(ObtenerDatosEfecto(), null);
            CbEfecto.DisplayMember = "Value";
            CbEfecto.ValueMember = "Key";

            CbSonido.DataSource = new BindingSource(ObtenerDatosSonido(), null);
            CbSonido.DisplayMember = "Value";
            CbSonido.ValueMember = "Key";
        }

        private Dictionary<short, string> ObtenerDatosTipoHechizo()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.TipoHechizo.Ataque, "Ataque");
            d.Add((short)Enumeraciones.TipoHechizo.Sanacion, "Sanción");
            d.Add((short)Enumeraciones.TipoHechizo.Paralizar, "Paralizar");
            d.Add((short)Enumeraciones.TipoHechizo.Inmovilizar, "Inmovilizar");
            d.Add((short)Enumeraciones.TipoHechizo.Envenenar, "Envenenar");
            d.Add((short)Enumeraciones.TipoHechizo.CurarVeneno, "Curar Veneno");
            d.Add((short)Enumeraciones.TipoHechizo.Otro, "Otro");

            return d;
        }

        private Dictionary<short, string> ObtenerDatosImagen()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.Imagen.Espada, "Espada");
            d.Add((short)Enumeraciones.Imagen.EscudoSeguro, "Escudo Seguro");

            return d;
        }

        private Dictionary<short, string> ObtenerDatosEfecto()
        {
            Dictionary<short, string> d = new Dictionary<short, string>();

            d.Add((short)Enumeraciones.EfectoParticulas.sinParticulas, "Sin Partículas");
            d.Add((short)Enumeraciones.EfectoParticulas.dardoMagico, "Daño Mágico");
            d.Add((short)Enumeraciones.EfectoParticulas.misilMagico, "Misil Mágico");
            d.Add((short)Enumeraciones.EfectoParticulas.apocalipsis, "Apocalipsis");
            d.Add((short)Enumeraciones.EfectoParticulas.paralisis, "Parálisis");
            d.Add((short)Enumeraciones.EfectoParticulas.meditacionEstandar, "Meditación Estandar");
            d.Add((short)Enumeraciones.EfectoParticulas.efectoMuerto, "Efecto Muerto");
            d.Add((short)Enumeraciones.EfectoParticulas.seleccion, "Selección");
            d.Add((short)Enumeraciones.EfectoParticulas.espadazoNormalAzul, "Espadazo Normal Azul");
            d.Add((short)Enumeraciones.EfectoParticulas.espadazoNormalRojo, "Espadazo Normal Rojo");
            d.Add((short)Enumeraciones.EfectoParticulas.dañoRecibido, "Daño Recibido");
            d.Add((short)Enumeraciones.EfectoParticulas.efectoMorir, "Efecto Morir");
            d.Add((short)Enumeraciones.EfectoParticulas.dañoRecibidoUsuario, "Daño Recibido Usuario");

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

        #endregion
    }
}
