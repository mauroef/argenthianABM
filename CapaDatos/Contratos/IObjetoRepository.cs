using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos.Objeto;

namespace CapaDatos.Contratos
{
    public interface IObjetoRepository
    {
        IEnumerable<Objeto.Objeto> ObtenerTodos();
        short ObtenerUltimoId();
        void Guardar(Objeto.Objeto objeto);
    }
}
