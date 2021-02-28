using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Objeto ObtenerPorId(short id)
        { 
            Objeto objeto = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos()).Where(o => o.id == id).FirstOrDefault();

            return objeto;
        }

        public short ObtenerUltimoId()
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            try
            {
                return lista.LastOrDefault().id;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public void Guardar(Objeto objeto)
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            lista.Add(objeto);

            EscribirDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Editar(short id, Objeto objeto)
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            List<Objeto> listaEditada = lista.Select(o => o = objeto).Where(o => o.id == id).ToList();


            EscribirDatos(JsonConvert.SerializeObject(listaEditada, Formatting.Indented));
        }

        public void Eliminar(short id)
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            EscribirDatos(JsonConvert.SerializeObject(lista.Where(o => o.id != id).ToList(), Formatting.Indented));
        }
    }
}
