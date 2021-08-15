using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Clase
{
    public class ClaseRepository : BaseRepository<Clase>, IClaseRepository
    {
        public ClaseRepository(string nombreRuta = "C:\\argenthian\\json\\clase.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Clase> ObtenerTodos()
        {
            List<Clase> lista = JsonConvert.DeserializeObject<List<Clase>>(LeerDatos());

            return lista;
        }
    }
}
