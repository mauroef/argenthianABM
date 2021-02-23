﻿using CapaNegocio.Modelos;
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

        #endregion

        #region Inicializacion

        public FormularioObjeto()
        {
            InitializeComponent();
            InicializarCombos();
            InicializarListBox();
        }

        #endregion

        #region Eventos

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtGuardarEquipo_Click(object sender, EventArgs e)
        {
            ObtenerValoresListBox();

            if (ValidarDatosFormulario())
            {
                objetoModel = objetoModel.MapearObjetoModel(TxNombre.Text, TxPrecio.Text, CbTipo.SelectedValue.ToString(), CbSonido.SelectedValue.ToString(), CbImagen.SelectedValue.ToString(),
                                                            CbModelo3d.SelectedValue.ToString(), CbHechizo.SelectedValue.ToString(), ObtenerValoresListBox(), TxSalud.Text, TxMana.Text, 
                                                            TxHambre.Text, TxSed.Text, TxFuerza.Text, TxAgilidad.Text, TxPeso.Text,
                                                            TxMinDanio.Text, TxMaxDanio.Text, TxMinDanioMagico.Text, TxMaxDanioMagico.Text, TxMinDefensaCasco.Text, 
                                                            TxMaxDefensaCasco.Text, TxMinDefensaCuerpo.Text, TxMaxDefensaCuerpo.Text, TxMinDefensaMagica.Text, TxMaxDefensaMagica.Text);

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
                MessageBox.Show("No se permiten campos vacíos!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        #region Validaciones

        private bool ValidarDatosFormulario()
        {
            return !(String.IsNullOrEmpty(TxNombre.Text) && String.IsNullOrEmpty(TxPrecio.Text) && String.IsNullOrEmpty(TxSalud.Text) && String.IsNullOrEmpty(TxMana.Text) &&
                String.IsNullOrEmpty(TxMana.Text) && String.IsNullOrEmpty(TxHambre.Text) && String.IsNullOrEmpty(TxSed.Text) && String.IsNullOrEmpty(TxFuerza.Text) &&
                String.IsNullOrEmpty(TxAgilidad.Text) && String.IsNullOrEmpty(TxPeso.Text) && String.IsNullOrEmpty(TxMinDanio.Text) && String.IsNullOrEmpty(TxMaxDanio.Text) &&
                String.IsNullOrEmpty(TxMinDanioMagico.Text) && String.IsNullOrEmpty(TxMaxDanioMagico.Text) && String.IsNullOrEmpty(TxMinDefensaCasco.Text) && String.IsNullOrEmpty(TxMaxDefensaCasco.Text) &&
                String.IsNullOrEmpty(TxMinDefensaCuerpo.Text) && String.IsNullOrEmpty(TxMaxDefensaCuerpo.Text) && String.IsNullOrEmpty(TxMinDefensaMagica.Text) && String.IsNullOrEmpty(TxMaxDefensaMagica.Text));
        }

        #endregion

        #region Combos

        private void InicializarCombos()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(100, "Uno");
            dict.Add(200, "Dos");
            dict.Add(300, "Tres");

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
            d.Add((short)Enumeraciones.TipoObjeto.HachaLeñador, "HachaLeñador");
            d.Add((short)Enumeraciones.TipoObjeto.PiqueteMinero, "PiqueteMinero");
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
