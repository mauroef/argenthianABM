using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using CapaDatos.Objeto;
using System.Data;
using FastMember;

namespace CapaNegocio.Modelos
{
    public class ObjetoModel
    {
        public short id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public short tipo { get; set; }
        public int idSonido { get; set; }
        public int idImagen { get; set; }
        public int idModelo3d { get; set; }
        public short idHechizo { get; set; }
        EstadisticasModel estadisticas { get; set; }
        EquipoModel equipo { get; set; }

        private ObjetoRepository objetoRepository;

        public ObjetoModel()
        {
            objetoRepository = new ObjetoRepository();
        }

        public DataTable MostrarDatos()
        {
            DataTable tablaObjeto = new DataTable("objetos");

            using (var reader = ObjectReader.Create(objetoRepository.ObtenerTodos(), "id", "nombre", "precio", "tipo", "idSonido", "idImagen", "idModelo3d"))
            {
                tablaObjeto.Load(reader);                
            }

            return tablaObjeto;
        }
    }
}
