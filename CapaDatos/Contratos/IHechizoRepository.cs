using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface IHechizoRepository
    {
        IEnumerable<Hechizo.Hechizo> ObtenerTodos();
        short ObtenerUltimoId();
        void Guardar(Hechizo.Hechizo hechizo);
    }
}
