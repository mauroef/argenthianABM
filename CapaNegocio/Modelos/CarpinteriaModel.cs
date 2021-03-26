using CapaDatos.Carpinteria;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio.Modelos
{
    public class CarpinteriaModel
    {
        #region Validacion

        public short Id { get; set; }
        public short IdObjeto { get; set; }
        public short Skills { get; set; }
        public short Madera { get; set; }

        #endregion

        private CarpinteriaRepository carpinteriaRepository;

        public CarpinteriaModel()
        {
            carpinteriaRepository = new CarpinteriaRepository();
        }

        public DataTable ObtenerDatos()
        {
            DataTable tablaCarpinteria = new DataTable("carpinteria");

            using (var reader = ObjectReader.Create(carpinteriaRepository.ObtenerTodos(), "id", "idObjeto", "skills", "madera"))
            {
                tablaCarpinteria.Load(reader);
            }

            return tablaCarpinteria;
        }

        public CarpinteriaModel ObtenerPorId(short id)
        {
            Carpinteria c = carpinteriaRepository.ObtenerPorId(id);

            return MapearCarpinteriaModel(c);
        }

        public bool GuadarDatos(CarpinteriaModel carpinteriaModel)
        {
            try
            {
                Carpinteria carpinteria = MapearCarpinteria(carpinteriaModel);

                carpinteriaRepository.Guardar(carpinteria);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CarpinteriaModel MapearCarpinteriaModel(string idObjeto, string skills, string madera)
        {
            CarpinteriaModel cm = new CarpinteriaModel();

            try
            {
                cm.IdObjeto = Convert.ToInt16(idObjeto);
                cm.Skills = Convert.ToInt16(skills);
                cm.Madera = Convert.ToInt16(madera);
            }
            catch (Exception)
            {
                return new CarpinteriaModel();
            }

            return cm;
        }

        public CarpinteriaModel MapearCarpinteriaModel(Carpinteria c)
        {
            CarpinteriaModel cm = new CarpinteriaModel();

            try
            {
                cm.Id = c.id;
                cm.IdObjeto = c.idObjeto;
                cm.Skills = c.skills;
                cm.Madera = c.madera;
            }
            catch (Exception)
            {
                return new CarpinteriaModel();
            }

            return cm;
        }

        public Carpinteria MapearCarpinteria(CarpinteriaModel cm, short id = 0)
        {
            Carpinteria c = new Carpinteria();

            c.id = id == 0 ? GenerarId() : id;
            c.idObjeto = cm.IdObjeto;
            c.skills = cm.Skills;
            c.madera = cm.Madera;

            return c;
        }

        private short GenerarId()
        {
            return (short)(carpinteriaRepository.ObtenerUltimoId() + 1);
        }

        public bool ValidarDatos(CarpinteriaModel cm)
        {
            return cm.IdObjeto > 0 && cm.Skills > -1 && cm.Madera > -1;
        }

        public bool EliminarPorId(short id)
        {
            try
            {
                carpinteriaRepository.Eliminar(id);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarPorId(short id, CarpinteriaModel carpinteriaModel)
        {
            try
            {
                Carpinteria carpinteria = MapearCarpinteria(carpinteriaModel, id);

                carpinteriaRepository.Editar(id, carpinteria);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
