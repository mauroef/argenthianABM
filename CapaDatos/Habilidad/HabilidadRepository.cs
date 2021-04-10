using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos.Habilidad
{
    public class HabilidadRepository : BaseRepository<Habilidad>, IHabilidadRepository
    {
        public HabilidadRepository(string nombreRuta = "C:\\argenthian\\json\\habilidades.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Habilidad> ObtenerTodos()
        {
            List<Habilidad> lista = JsonConvert.DeserializeObject<List<Habilidad>>(LeerDatos());

            return lista;
        }

        public Habilidad ObtenerPorId(short id)
        {
            Habilidad habilidad = JsonConvert.DeserializeObject<List<Habilidad>>(LeerDatos()).Where(c => c.id == id).FirstOrDefault();

            return habilidad;
        }

        public short ObtenerUltimoId()
        {
            List<Habilidad> lista = JsonConvert.DeserializeObject<List<Habilidad>>(LeerDatos());

            try
            {
                return lista.LastOrDefault().id;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void Guardar(Habilidad habilidad)
        {
            List<Habilidad> lista = JsonConvert.DeserializeObject<List<Habilidad>>(LeerDatos());

            lista.Add(habilidad);

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Editar(short id, Habilidad habilidadEditado)
        {
            List<Habilidad> lista = JsonConvert.DeserializeObject<List<Habilidad>>(LeerDatos());
            Habilidad habilidad = lista.First(o => o.id == id);
            int indice = lista.IndexOf(habilidad);

            if (indice >= 0)
            {
                lista[indice] = habilidadEditado;
            }

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Eliminar(short id)
        {
            List<Habilidad> lista = JsonConvert.DeserializeObject<List<Habilidad>>(LeerDatos());

            EscribirDatos(JsonConvert.SerializeObject(lista.Where(o => o.id != id).ToList(), Formatting.Indented));
        }
    }
}
