using CapaDatos.Clase.Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Clase
{
    public class Clase
    {
        public short id { get; set; }
        public List<string> nombre { get; set; }
        public Modificadores modificadores { get; set; }
        public Salud salud { get; set; }
        public GolpeDaño golpeDaño { get; set; }
        public PuntosMana mana { get; set; }
        public PuntosEnergia energia { get; set; }
        public List<string> descripcionCorta { get; set; }

        public Clase()
        {
            //this.nombre = new List<string>();
            ////this.modificadores = new Modificadores();
            //this.salud = new Salud();
            ////this.golpeDaño = new GolpeDaño();
            //this.mana = new PuntosMana();
            //this.energia = new PuntosEnergia();
            //this.descripcionCorta = new List<string>();
        }


    }
}
