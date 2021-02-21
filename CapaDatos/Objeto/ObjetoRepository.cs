﻿using CapaDatos.Contratos;
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

        public void Guardar(Objeto objeto)
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            lista.Add(objeto);

            GuardarDatos(JsonConvert.SerializeObject(lista, Formatting.Indented));
        }

        public void Eliminar(short id)
        {
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(LeerDatos());

            GuardarDatos(JsonConvert.SerializeObject(lista.Where(o => o.id != id).ToList(), Formatting.Indented));
        }
    }
}
