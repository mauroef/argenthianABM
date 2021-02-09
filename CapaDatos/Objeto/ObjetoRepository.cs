using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Objeto
{
    public class ObjetoRepository : BaseRepository<Objeto>, IObjetoRepository
    {
        public ObjetoRepository(string nombreRuta = "C:\\argenthian\\json\\objetos.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Objeto> ObtenerTodos()
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            return lista;
        }

        public void Editar(Objeto objeto)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Objeto objeto)
        {
            throw new NotImplementedException();
        }

        public void EditarObjeto(Objeto objeto)
        {
            throw new NotImplementedException();
        }
    }
}
