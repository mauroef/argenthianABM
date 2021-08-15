using CapaDatos.Configuracion.Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion
{
    public class Configuracion
    {
        [JsonProperty("conexion")]
        public Conexion conexion { get; set; }

        [JsonProperty("ingreso")]
        public Ingreso ingreso { get; set; }

        [JsonProperty("teclado")]
        public Teclado teclado { get; set; }

        [JsonProperty("video")]
        public Video video { get; set; }

        [JsonProperty("sonido")]
        public Sonido sonido { get; set; }

        [JsonProperty("idLenguaje")]
        public short idLenguaje { get; set; }

        [JsonProperty("rutaLogsError")]
        public string rutaLogsError { get; set; }

        [JsonProperty("rutaLogsAdvertencia")]
        public string rutaLogsAdvertencia { get; set; }

        [JsonProperty("nombreCaracteresMinimos")]
        public int nombreCaracteresMinimos { get; set; }

        [JsonProperty("velocidadTooltip")]
        public float velocidadTooltip { get; set; }

        [JsonProperty("personajeMaxPorCuenta")]
        public short personajeMaxPorCuenta { get; set; }

        public Configuracion()
        {
            this.ingreso = new Ingreso();
            this.video = new Video();
            this.teclado = new Teclado();
            this.sonido = new Sonido();
        }
    }


}
