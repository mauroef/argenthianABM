using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio.Modelos
{
    public partial class EquipoModel
    {
        public short MaxDaño { get; set; }
        public short MinDaño { get; set; }
        public short MaxDañoMagico { get; set; }
        public short MinDañoMagico { get; set; }
        public short MaxDefCasco { get; set; }
        public short MinDefCasco { get; set; }
        public short MaxDefCuerpo { get; set; }
        public short MinDefCuerpo { get; set; }
        public short MaxDefMagica { get; set; }
        public short MinDefMagica { get; set; }

        public static EquipoModel Mapear(short minDanio, short maxDanio, short minDanioMagico, short maxDanioMagico, short minDefensaCasco, short maxDefensaCasco, short minDefensaCuerpo, short maxDefensaCuerpo, short minDefensaMagica, short maxDefensaMagica)
        {
            EquipoModel em = new EquipoModel();

            em.MaxDaño = maxDanio;
            em.MinDaño = minDanio;
            em.MaxDañoMagico = maxDanioMagico;
            em.MinDañoMagico = minDanioMagico;
            em.MaxDefCasco = maxDefensaCasco;
            em.MinDefCasco = minDefensaCasco;
            em.MaxDefCuerpo = maxDefensaCuerpo;
            em.MinDefCuerpo = minDefensaCuerpo;
            em.MaxDefMagica = maxDefensaMagica;
            em.MinDefMagica = minDefensaMagica;

            return em;
        }
    }
}
