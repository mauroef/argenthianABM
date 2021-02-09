using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CapaDatos.Objeto
{
    public class Objeto
    {       
        [JsonProperty("id")]
        public short id { get; set; }

        [JsonProperty("nombre")]
        public string nombre { get; set; }

        [JsonProperty("precio")]
        public decimal precio { get; set; }

        [JsonProperty("tipo")]
        public short tipo { get; set; }

        [JsonProperty("idSonido")]
        public int idSonido { get; set; }

        [JsonProperty("idImagen")]
        public int idImagen { get; set; }

        [JsonProperty("idModelo3d")]
        public int idModelo3d { get; set; }

        [JsonProperty("idHechizo")]
        public short idHechizo { get; set; }

        public Equipo equipo { get; set; }
        public Estadisticas estadisticas { get; set; }       
    }

    public class Estadisticas
    {
        [JsonProperty("salud")]
        public short salud { get; set; }
        [JsonProperty("mana")]
        public short mana { get; set; }
        [JsonProperty("hambre")]
        public short hambre { get; set; }
        [JsonProperty("sed")]
        public short sed { get; set; }
        [JsonProperty("fuerza")]
        public short fuerza { get; set; }
        [JsonProperty("agilidad")]
        public short agilidad { get; set; }
        [JsonProperty("peso")]
        public short peso { get; set; }
    }

    public class Equipo
    {
        [JsonProperty("maxDaño")]
        public short maxDaño { get; set; }
        [JsonProperty("minDaño")]
        public short minDaño { get; set; }
        [JsonProperty("maxDañoMagico")]
        public short maxDañoMagico { get; set; }
        [JsonProperty("minDañoMagico")]
        public short minDañoMagico { get; set; }
        [JsonProperty("maxDefCasco")]
        public short maxDefCasco { get; set; }
        [JsonProperty("minDefCasco")]
        public short minDefCasco { get; set; }
        [JsonProperty("maxDefCuerpo")]
        public short maxDefCuerpo { get; set; }
        [JsonProperty("minDefCuerpo")]
        public short minDefCuerpo { get; set; }
        [JsonProperty("maxDefMagica")]
        public short maxDefMagica { get; set; }
        [JsonProperty("minDefMagica")]
        public short minDefMagica { get; set; }
    }
}
