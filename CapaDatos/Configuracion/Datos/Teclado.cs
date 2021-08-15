using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion.Datos
{
    public class Teclado
    {
        [JsonProperty("inventario")]
        public int inventario { get; set; }
        [JsonProperty("inventarioHechizo")]
        public int inventariohechizo { get; set; }
        [JsonProperty("golpear")]
        public int golpear { get; set; }
        [JsonProperty("utilizar")]
        public int utilizar { get; set; }
        [JsonProperty("tirarObjeto")]
        public int tirarObjeto { get; set; }
    }
}
