using CapaDatos.Ciudad;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio.Modelos
{
    public class CiudadModel
    {
        #region Validacion

        public short Id { get; set; }
        public string Nombre { get; set; }

        #endregion

        private CiudadRepository ciudadRepository;

        public CiudadModel()
        {
            ciudadRepository = new CiudadRepository();
        }

        public DataTable ObtenerDatos()
        {
            DataTable tablaCiudad = new DataTable("ciudad");

            using (var reader = ObjectReader.Create(ciudadRepository.ObtenerTodos(), "id", "nombre"))
            {
                tablaCiudad.Load(reader);
            }

            return tablaCiudad;
        }

        public CiudadModel ObtenerPorId(short id)
        {
            Ciudad c = ciudadRepository.ObtenerPorId(id);

            return MapearCiudadModel(c);
        }

        public bool GuadarDatos(CiudadModel ciudadModel)
        {
            try
            {
                Ciudad ciudad = MapearCiudad(ciudadModel);

                ciudadRepository.Guardar(ciudad);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CiudadModel MapearCiudadModel(string nombre)
        {
            CiudadModel cm = new CiudadModel();

            try
            {
                cm.Nombre = nombre;
            }
            catch (Exception)
            {
                return new CiudadModel();
            }

            return cm;
        }

        public CiudadModel MapearCiudadModel(Ciudad c)
        {
            CiudadModel cm = new CiudadModel();

            try
            {
                cm.Id = c.id;
                cm.Nombre = c.nombre;
            }
            catch (Exception)
            {
                return new CiudadModel();
            }

            return cm;
        }

        public Ciudad MapearCiudad(CiudadModel cm, short id = 0)
        {
            Ciudad c = new Ciudad();

            c.id = id == 0 ? GenerarId() : id;
            c.nombre = cm.Nombre;

            return c;
        }

        private short GenerarId()
        {
            return (short)(ciudadRepository.ObtenerUltimoId() + 1);
        }

        public bool ValidarDatos(CiudadModel cm)
        {
            return !String.IsNullOrEmpty(cm.Nombre);
        }

        public bool EliminarPorId(short id)
        {
            try
            {
                ciudadRepository.Eliminar(id);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarPorId(short id, CiudadModel ciudadModel)
        {
            try
            {
                Ciudad ciudad = MapearCiudad(ciudadModel, id);

                ciudadRepository.Editar(id, ciudad);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
