using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Raza
{
    public class RazaRepository: BaseRepository<Raza>, IRazaRepository
    {
        public RazaRepository(string nombreRuta = "C:\\argenthian\\json\\raza.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Raza> ObtenerTodos()
        {
            List<Raza> lista = JsonConvert.DeserializeObject<List<Raza>>(LeerDatos());

            return lista;
        }
    }
}
