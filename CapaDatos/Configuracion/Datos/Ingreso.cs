using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion.Datos
{
    public class Ingreso
    {
        [JsonProperty("nombreCuenta")]
        public string cuenta = "";
        [JsonProperty("claveCuenta")]
        public string clave = "";
        [JsonProperty("mostrarContraseña")]
        public bool mostrarContraseña = false;
        [JsonProperty("guardarContraseña")]
        public bool guardarContraseña = false;
    }
}
