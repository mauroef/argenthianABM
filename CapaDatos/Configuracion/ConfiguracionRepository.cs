using CapaDatos.Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion
{
    public class ConfiguracionRepository : BaseRepository<Configuracion>, IConfiguracionRepository
    {
        public ConfiguracionRepository(string nombreRuta = "C:\\argenthian\\json\\configuracion.json")
        : base(nombreRuta)
        {
        }

        public Configuracion Obtener()
        {
            Configuracion lista = JsonConvert.DeserializeObject<Configuracion>(LeerDatos());

            return lista;
        }
    }
}
