using CapaDatos.Habilidad;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio.Modelos
{
    public class HabilidadModel
    {
        #region Validacion

        public short Id { get; set; }
        public string Nombre { get; set; }

        #endregion

        private HabilidadRepository habilidadRepository;

        public HabilidadModel()
        {
            habilidadRepository = new HabilidadRepository();
        }

        public DataTable ObtenerDatos()
        {
            DataTable tablaHabilidad = new DataTable("habilidad");

            using (var reader = ObjectReader.Create(habilidadRepository.ObtenerTodos(), "id", "nombre"))
            {
                tablaHabilidad.Load(reader);
            }

            return tablaHabilidad;
        }

        public HabilidadModel ObtenerPorId(short id)
        {
            Habilidad h = habilidadRepository.ObtenerPorId(id);

            return MapearHabilidadModel(h);
        }

        public bool GuadarDatos(HabilidadModel habilidadModel)
        {
            try
            {
                Habilidad habilidad = MapearHabilidad(habilidadModel);

                habilidadRepository.Guardar(habilidad);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public HabilidadModel MapearHabilidadModel(string nombre)
        {
            HabilidadModel hm = new HabilidadModel();

            try
            {
                hm.Nombre = nombre;
            }
            catch (Exception)
            {
                return new HabilidadModel();
            }

            return hm;
        }

        public HabilidadModel MapearHabilidadModel(Habilidad h)
        {
            HabilidadModel hm = new HabilidadModel();

            try
            {
                hm.Id = h.id;
                hm.Nombre = h.nombre;
            }
            catch (Exception)
            {
                return new HabilidadModel();
            }

            return hm;
        }

        public Habilidad MapearHabilidad(HabilidadModel hm, short id = 0)
        {
            Habilidad h = new Habilidad();

            h.id = id == 0 ? GenerarId() : id;
            h.nombre = hm.Nombre;

            return h;
        }

        private short GenerarId()
        {
            return (short)(habilidadRepository.ObtenerUltimoId() + 1);
        }

        public bool ValidarDatos(HabilidadModel hm)
        {
            return !String.IsNullOrEmpty(hm.Nombre);
        }

        public bool EliminarPorId(short id)
        {
            try
            {
                habilidadRepository.Eliminar(id);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarPorId(short id, HabilidadModel habilidadModel)
        {
            try
            {
                Habilidad habilidad = MapearHabilidad(habilidadModel, id);

                habilidadRepository.Editar(id, habilidad);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
