using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Hechizo
{
    public class Hechizo
    {
        [JsonProperty("id")]
        public short id { get; set; }

        [JsonProperty("tipo")]
        public short tipo { get; set; }

        [JsonProperty("nombre")]
        public string nombre { get; set; }

        [JsonProperty("idImagen")]
        public short idImagen { get; set; }

        [JsonProperty("idEfecto")]
        public short idEfecto { get; set; }

        [JsonProperty("idSonido")]
        public short idSonido { get; set; }

        [JsonProperty("descripcion")]
        public string descripcion { get; set; }

        [JsonProperty("palabrasMagicas")]
        public string palabrasMagicas { get; set; }

        public Consumo consumo { get; set; }
        public Temporales temporales { get; set; }
        public Ataque ataque { get; set; }
    }

    public class Consumo
    {
        public short maxMana { get; set; }
        public short minMana { get; set; }
        public short maxEnergia { get; set; }
        public short minEnergia { get; set; }
    }

    public class Temporales
    {
        public float paralizar { get; set; }
        public float inmovilizar { get; set; }
        public float congelar { get; set; }
    }

    public class Ataque
    {
        public short maxDaño { get; set; }
        public short minDaño { get; set; }
        public bool envenenar { get; set; }
    }
}
