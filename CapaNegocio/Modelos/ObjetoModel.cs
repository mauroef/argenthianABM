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

        public short Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public short Tipo { get; set; }
        public int IdSonido { get; set; }
        public int IdImagen { get; set; }
        public int IdModelo3d { get; set; }
        public short IdHechizo { get; set; }
        EstadisticasModel Estadisticas { get; set; }
        EquipoModel Equipo { get; set; }

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

            o.nombre = objetoModel.Nombre;

            return o;
        }

        public bool ValidarDatos(ObjetoModel objeto)
        {
            return !String.IsNullOrEmpty(objeto.Nombre);
        }

        public bool EliminarPorId(short id)
        {
            try
            {
                objetoRepository.Eliminar(id);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
