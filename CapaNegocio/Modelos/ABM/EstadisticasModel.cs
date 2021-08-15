using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio.Modelos
{
    public partial class EstadisticasModel
    {
        public short Salud { get; set; }
        public short Mana { get; set; }
        public short Hambre { get; set; }
        public short Sed { get; set; }
        public short Fuerza { get; set; }
        public short Agilidad { get; set; }
        public short Peso { get; set; }

        public static EstadisticasModel Mapear(short salud, short mana, short hambre, short sed, short fuerza, short agilidad, short peso)
        {
            EstadisticasModel em = new EstadisticasModel();

            em.Salud = salud;
            em.Mana = mana;
            em.Hambre = hambre;
            em.Sed = sed;
            em.Fuerza = fuerza;
            em.Agilidad = agilidad;
            em.Peso = peso;

            return em;
        }
    }
}
