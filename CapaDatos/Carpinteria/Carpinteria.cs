using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Carpinteria
{
    public class Carpinteria
    {
        [JsonProperty("id")]
        public short id { get; set; }
        [JsonProperty("idObjeto")]
        public short idObjeto { get; set; }
        [JsonProperty("skills")]
        public short skills { get; set; }
        [JsonProperty("madera")]
        public short madera { get; set; }
    }
}
