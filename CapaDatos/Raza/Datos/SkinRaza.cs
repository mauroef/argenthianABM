using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Raza.Datos
{
    public class SkinRaza
    {
        [JsonProperty("hombre")]
        public SkinRazaGenero hombre { get; set; }

        [JsonProperty("mujer")]
        public SkinRazaGenero mujer { get; set; }
    }
}
