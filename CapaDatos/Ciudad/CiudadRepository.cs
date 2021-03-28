using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos.Ciudad
{
    public class CiudadRepository : BaseRepository<Ciudad>, ICiudadRepository
    {
        public CiudadRepository(string nombreRuta = "C:\\argenthian\\json\\ciudades.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Ciudad> ObtenerTodos()
        {
            List<Ciudad> lista = JsonConvert.DeserializeObject<List<Ciudad>>(LeerDatos());

            return lista;
        }

        public Ciudad ObtenerPorId(short id)
        {
            Ciudad ciudad = JsonConvert.DeserializeObject<List<Ciudad>>(LeerDatos()).Where(c => c.id == id).FirstOrDefault();

            return ciudad;
        }

        public short ObtenerUltimoId()
        {
            List<Ciudad> lista = JsonConvert.DeserializeObject<List<Ciudad>>(LeerDatos());

            try
            {
                return lista.LastOrDefault().id;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void Guardar(Ciudad ciudad)
        {
            List<Ciudad> lista = JsonConvert.DeserializeObject<List<Ciudad>>(LeerDatos());

            lista.Add(ciudad);

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Editar(short id, Ciudad ciudadEditado)
        {
            List<Ciudad> lista = JsonConvert.DeserializeObject<List<Ciudad>>(LeerDatos());
            Ciudad ciudad = lista.First(o => o.id == id);
            int indice = lista.IndexOf(ciudad);

            if (indice >= 0)
            {
                lista[indice] = ciudadEditado;
            }

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Eliminar(short id)
        {
            List<Ciudad> lista = JsonConvert.DeserializeObject<List<Ciudad>>(LeerDatos());

            EscribirDatos(JsonConvert.SerializeObject(lista.Where(o => o.id != id).ToList(), Formatting.Indented));
        }
    }
}
