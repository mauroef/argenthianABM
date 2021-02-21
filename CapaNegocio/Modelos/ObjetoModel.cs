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
        #region Validacion

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

        #endregion

        private ObjetoRepository objetoRepository;

        public ObjetoModel()
        {
            objetoRepository = new ObjetoRepository();
        }

        public DataTable ObtenerDatos()
        {
            DataTable tablaObjeto = new DataTable("objetos");

            using (var reader = ObjectReader.Create(objetoRepository.ObtenerTodos(), "id", "nombre", "precio", "tipo", "idSonido", "idImagen", "idModelo3d"))
            {
                tablaObjeto.Load(reader);                
            }

            return tablaObjeto;
        }

        public bool GuadarDatos(ObjetoModel objetoModel)
        {
            if (ValidarDatos(objetoModel))
            {
                Objeto objeto = MapearObjeto(objetoModel);
                
                objetoRepository.Guardar(objeto);

                return true;
            }
            else
            {
                return false;
            }
        }

        private Objeto MapearObjeto(ObjetoModel objetoModel)
        {
            Objeto o = new Objeto();

            o.nombre = objetoModel.nombre;

            return o;
        }

        public bool ValidarDatos(ObjetoModel objeto)
        {
            return !String.IsNullOrEmpty(objeto.nombre);
        }
    }
}
