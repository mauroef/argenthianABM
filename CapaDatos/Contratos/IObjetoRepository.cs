using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos.Objeto;

namespace CapaDatos.Contratos
{
    public interface IObjetoRepository
    {
        IEnumerable<Objeto.Objeto> ObtenerTodos();
        void Guardar(Objeto.Objeto objeto);
        void Editar(Objeto.Objeto objeto);
    }
}
