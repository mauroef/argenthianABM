using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Npc
{
    public class NpcRepository: BaseRepository<Npc>, INpcRepository
    {
        public NpcRepository(string nombreRuta = "C:\\argenthian\\json\\npcs.json")
        : base(nombreRuta)
        {
        }

        public IEnumerable<Npc> ObtenerTodos()
        {
            List<Npc> lista = JsonConvert.DeserializeObject<List<Npc>>(LeerDatos());

            return lista;
        }
    }
}
