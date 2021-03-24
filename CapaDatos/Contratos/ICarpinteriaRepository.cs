using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface ICarpinteriaRepository
    {
        IEnumerable<Carpinteria.Carpinteria> ObtenerTodos();
        short ObtenerUltimoId();
        void Guardar(Carpinteria.Carpinteria carpinteria);
    }
}
