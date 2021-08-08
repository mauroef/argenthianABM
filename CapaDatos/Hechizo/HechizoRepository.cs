using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos.Hechizo
{
    public class HechizoRepository : BaseRepository<Hechizo>, IHechizoRepository
    {
        public HechizoRepository(string nombreRuta = "C:\\argenthian\\json\\hechizos.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Hechizo> ObtenerTodos()
        {
            List<Hechizo> lista = JsonConvert.DeserializeObject<List<Hechizo>>(LeerDatos());

            return lista;
        }

        public Hechizo ObtenerPorId(short id)
        {
            Hechizo objeto = JsonConvert.DeserializeObject<List<Hechizo>>(LeerDatos()).Where(o => o.id == id).FirstOrDefault();

            return objeto;
        }

        public short ObtenerUltimoId()
        {
            List<Hechizo> lista = JsonConvert.DeserializeObject<List<Hechizo>>(LeerDatos());

            try
            {
                return lista.LastOrDefault().id;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void Guardar(Hechizo objeto)
        {
            List<Hechizo> lista = JsonConvert.DeserializeObject<List<Hechizo>>(LeerDatos());

            lista.Add(objeto);

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Editar(short id, Hechizo objetoEditado)
        {
            List<Hechizo> lista = JsonConvert.DeserializeObject<List<Hechizo>>(LeerDatos());
            Hechizo objeto = lista.First(o => o.id == id);
            int indice = lista.IndexOf(objeto);

            if (indice >= 0)
            {
                lista[indice] = objetoEditado;
            }

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Eliminar(short id)
        {
            List<Hechizo> lista = JsonConvert.DeserializeObject<List<Hechizo>>(LeerDatos());

            EscribirDatos(JsonConvert.SerializeObject(lista.Where(o => o.id != id).ToList(), Formatting.Indented));
        }
    }
}
