using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface IRazaRepository
    {
        IEnumerable<Raza.Raza> ObtenerTodos();
    }
}
