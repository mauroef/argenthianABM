using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface ICiudadRepository
    {
        IEnumerable<Ciudad.Ciudad> ObtenerTodos();
        short ObtenerUltimoId();
        void Guardar(Ciudad.Ciudad ciudad);
    }
}
