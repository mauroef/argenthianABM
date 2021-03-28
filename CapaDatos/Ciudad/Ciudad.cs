using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Ciudad
{
    public class Ciudad
    {
        [JsonProperty("id")]
        public short id { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
    }
}
