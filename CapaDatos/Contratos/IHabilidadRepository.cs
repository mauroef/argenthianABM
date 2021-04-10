using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface IHabilidadRepository
    {
        IEnumerable<Habilidad.Habilidad> ObtenerTodos();
        short ObtenerUltimoId();
        void Guardar(Habilidad.Habilidad habilidad);
    }
}
