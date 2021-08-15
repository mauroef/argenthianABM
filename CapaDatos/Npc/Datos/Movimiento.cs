using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Npc.Datos
{
    public class Movimiento
    {
        public float velocidadGolpe { get; set; }
        public float intervaloGolpe { get; set; }
        public float velocidadNormal { get; set; }
        public float velocidadCorriendo { get; set; }
        public float velocidadRotacion { get; set; }
        public float distanciaMaxima { get; set; }
        public float distanciaCorrer { get; set; }
        public float distanciaMinima { get; set; }
        public float distanciaGolpeMaxima { get; set; }
        public float distanciaGolpeMinima { get; set; }
    }
}
