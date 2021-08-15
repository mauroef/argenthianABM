using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Habilidad
{
    public class Habilidad
    {
        [JsonProperty("id")]
        public short id { get; set; }
        [JsonProperty("nombre")]
        public List<string> nombre { get; set; }
    }
}
