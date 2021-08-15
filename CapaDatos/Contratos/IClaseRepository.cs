using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface IClaseRepository
    {
        IEnumerable<Clase.Clase> ObtenerTodos();
    }
}
