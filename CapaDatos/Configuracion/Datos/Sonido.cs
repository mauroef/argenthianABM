using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion.Datos
{
    public class Sonido
    {
        [JsonProperty("volumenSonido")]
        public float volumenSonido { get; set; }

        [JsonProperty("volumenMusica")]
        public float volumenMusica { get; set; }
    }
}
