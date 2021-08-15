using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface INpcRepository
    {
        IEnumerable<Npc.Npc> ObtenerTodos();
    }
}
