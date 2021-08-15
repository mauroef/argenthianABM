using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion.Datos
{
    public class Video
    {
        [JsonProperty("idResolucion")]
        public int idResolucion = 0;
        [JsonProperty("pantallaCompletaActivada")]
        public bool pantallaCompletaActivada = true;
    }
}
