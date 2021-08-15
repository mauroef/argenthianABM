using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Npc
{
    public class Npc
    {
        [JsonProperty("id")]
        public short id { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }

        [JsonProperty("humanoide")]
        public bool humanoide { get; set; }
        [JsonProperty("tipoNpc")]
        public short tipoNpc { get; set; }
        [JsonProperty("tipoObjetos")]
        public List<int> tipoObjetos { get; set; }
        [JsonProperty("idModelo3d")]
        public short idModelo3d { get; set; }
        [JsonProperty("texto")]
        public string texto { get; set; }

        [JsonProperty("objetosVendedor")]
        public List<Datos.ObjetosVendedor> objetosVendedor { get; set; }
        public Datos.Estadisticas estadisticas { get; set; }
        public Datos.Movimiento movimiento { get; set; }

        //public Npc()
        //{
        //    this.tipoObjetos = new List<int>();
        //    this.objetosVendedor = new List<ObjetosVendedor>();
        //    this.estadisticas = new Estadisticas();
        //    this.movimiento = new Movimiento();

        //}


    }
}
