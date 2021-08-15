using CapaDatos.Raza.Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Raza
{
    public class Raza
    {
        public short id { get; set; }
        public List<string> nombre { get; set; }
        public short fuerza { get; set; }
        public short agilidad { get; set; }
        public short inteligencia { get; set; }
        public short carisma { get; set; }
        public short constitucion { get; set; }

        public SkinRaza skinRaza { get; set; }

        //public Raza()
        //{
        //    this.nombre = new List<string>();
        //    this.cuerpo = new Cuerpo();
        //}

 
    }
}
