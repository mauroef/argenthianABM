using CapaDatos.Carpinteria;
using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaDatos.Carpinteria
{
    public class CarpinteriaRepository : BaseRepository<Carpinteria>, ICarpinteriaRepository
    {
        public CarpinteriaRepository(string nombreRuta = "C:\\argenthian\\json\\carpinteria.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Carpinteria> ObtenerTodos()
        {
            List<Carpinteria> lista = JsonConvert.DeserializeObject<List<Carpinteria>>(LeerDatos());

            return lista;
        }

        public Carpinteria ObtenerPorId(short id)
        {
            Carpinteria carpinteria = JsonConvert.DeserializeObject<List<Carpinteria>>(LeerDatos()).Where(o => o.id == id).FirstOrDefault();

            return carpinteria;
        }

        public short ObtenerUltimoId()
        {
            List<Carpinteria> lista = JsonConvert.DeserializeObject<List<Carpinteria>>(LeerDatos());

            try
            {
                return lista.LastOrDefault().id;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void Guardar(Carpinteria carpinteria)
        {
            List<Carpinteria> lista = JsonConvert.DeserializeObject<List<Carpinteria>>(LeerDatos());

            lista.Add(carpinteria);

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Editar(short id, Carpinteria carpinteriaEditado)
        {
            List<Carpinteria> lista = JsonConvert.DeserializeObject<List<Carpinteria>>(LeerDatos());
            Carpinteria objeto = lista.First(o => o.id == id);
            int indice = lista.IndexOf(objeto);

            if (indice >= 0)
            {
                lista[indice] = carpinteriaEditado;
            }

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Eliminar(short id)
        {
            List<Carpinteria> lista = JsonConvert.DeserializeObject<List<Carpinteria>>(LeerDatos());

            EscribirDatos(JsonConvert.SerializeObject(lista.Where(o => o.id != id).ToList(), Formatting.Indented));
        }
    }
}
