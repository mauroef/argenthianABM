using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CapaDatos
{
    public class BaseRepository<T> where T : class
    {
        private readonly string _nombreRuta;

        public BaseRepository(string nombreRuta)
        {
            _nombreRuta = nombreRuta;
        }

        public string LeerDatos()
        {
            using (StreamReader jsonStream = File.OpenText(_nombreRuta))
            {
                string json = jsonStream.ReadToEnd();

                return json;
            }
        }
    }
}
