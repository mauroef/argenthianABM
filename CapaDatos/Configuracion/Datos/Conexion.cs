using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion.Datos
{
    public class Conexion
    {
        [JsonProperty("ip")]
        public string ip;
        [JsonProperty("puerto")]
        public int puerto;
    }
}
