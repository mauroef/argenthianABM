using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class selectorBotonera : Form
    {
        #region Propiedades

        private GrillaObjeto grillaObjeto = new GrillaObjeto();

        #endregion

        #region Inicializacion

        public selectorBotonera()
        {
            InitializeComponent();
            InicializarBotones();
        }

        private void InicializarBotones()
        {
            foreach (short tipo in Enum.GetValues(typeof(Enumeraciones.TipoJson)).Cast<Enumeraciones.TipoJson>().ToList())
            {
                switch (tipo)
                {
                    case (short)Enumeraciones.TipoJson.Carpinteria:
                        this.Controls.Add(SetearBoton(tipo, 50, "Carpintería"));
                        break;
                    case (short)Enumeraciones.TipoJson.Ciudades:
                        this.Controls.Add(SetearBoton(tipo, 100, "Ciudades"));
                        break;
                    case (short)Enumeraciones.TipoJson.Clases:
                        this.Controls.Add(SetearBoton(tipo, 150, "Clases"));
                        break;
                    case (short)Enumeraciones.TipoJson.Configuracion:
                        this.Controls.Add(SetearBoton(tipo, 200, "Configuración"));
                        break;
                    case (short)Enumeraciones.TipoJson.Habilidades:
                        this.Controls.Add(SetearBoton(tipo, 250, "Habilidades"));
                        break;
                    case (short)Enumeraciones.TipoJson.Hechizos:
                        this.Controls.Add(SetearBoton(tipo, 300, "Hechizos"));
                        break;
                    case (short)Enumeraciones.TipoJson.Npcs:
                        this.Controls.Add(SetearBoton(tipo, 350, "NPCS"));
                        break;
                    case (short)Enumeraciones.TipoJson.Objetos:
                        this.Controls.Add(SetearBoton(tipo, 400, "Objetos"));
                        break;
                    case (short)Enumeraciones.TipoJson.Razas:
                        this.Controls.Add(SetearBoton(tipo, 450, "Razas"));
                        break;
                    default:
                        break;
                }
            }
        }

        private Button SetearBoton(short tipo, short top, string nombre)
        {
            Button b = new Button();

            b.Top = top;
            b.Left = 100;
            b.Width = 100;
            b.Text = nombre;        
            b.Click += (obj, eArgs) =>
            {
                AbrirFormulario(tipo);
            };

            return b;
        }

        private void AbrirFormulario(short tipo)
        {
            try
            {
                switch (tipo)
                {
                    case (short)Enumeraciones.TipoJson.Carpinteria:

                        break;
                    case (short)Enumeraciones.TipoJson.Ciudades:

                        break;
                    case (short)Enumeraciones.TipoJson.Clases:

                        break;
                    case (short)Enumeraciones.TipoJson.Configuracion:

                        break;
                    case (short)Enumeraciones.TipoJson.Habilidades:

                        break;
                    case (short)Enumeraciones.TipoJson.Hechizos:

                        break;
                    case (short)Enumeraciones.TipoJson.Npcs:

                        break;
                    case (short)Enumeraciones.TipoJson.Objetos:
                        this.grillaObjeto.Show();
                        break;
                    case (short)Enumeraciones.TipoJson.Razas:

                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Se ha cerrado la ventana. Cierre la aplicación y vuelva a ejecutar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
