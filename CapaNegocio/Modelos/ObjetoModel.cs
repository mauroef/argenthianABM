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
        public List<short> ClasesNoPermitidas { get; set; }
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
            try
            {
                Objeto objeto = MapearObjeto(objetoModel);

                objetoRepository.Guardar(objeto);

                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public Objeto MapearObjeto(ObjetoModel om)
        {
            Objeto o = new Objeto();

            o.nombre = om.Nombre;
            o.precio = om.Precio;
            o.tipo = om.Tipo;
            o.idSonido = om.IdSonido;
            o.idImagen = om.IdImagen;
            o.idModelo3d = om.IdModelo3d;
            o.idHechizo = om.IdHechizo;
            o.clasesNoPermitidas = om.ClasesNoPermitidas;
            o.estadisticas.salud = om.Estadisticas.Salud;
            o.estadisticas.mana = om.Estadisticas.Mana;
            o.estadisticas.hambre = om.Estadisticas.Hambre;
            o.estadisticas.sed = om.Estadisticas.Sed;
            o.estadisticas.fuerza = om.Estadisticas.Fuerza;
            o.estadisticas.agilidad = om.Estadisticas.Agilidad;
            o.estadisticas.peso = om.Estadisticas.Peso;
            o.equipo.minDaño = om.Equipo.MinDaño;
            o.equipo.maxDaño = om.Equipo.MaxDaño;
            o.equipo.minDañoMagico = om.Equipo.MinDañoMagico;
            o.equipo.maxDañoMagico = om.Equipo.MaxDañoMagico;
            o.equipo.minDefCasco = om.Equipo.MinDefCasco;
            o.equipo.maxDefCasco = om.Equipo.MaxDefCasco;
            o.equipo.minDefCuerpo = om.Equipo.MinDefCuerpo;
            o.equipo.maxDefCuerpo = om.Equipo.MaxDefCuerpo;
            o.equipo.minDefMagica = om.Equipo.MinDefMagica;
            o.equipo.maxDefMagica = om.Equipo.MaxDefMagica;

            return o;
        }

        public ObjetoModel MapearObjetoModel(string nombre, string precio, string idTipo, string idSonido, string idImagen, 
                                            string idModelo, string idHechizo, List<short> clasesNoPermitidas, string salud, string mana, string hambre, 
                                            string sed, string fuerza, string agilidad, string peso, string minDanio, 
                                            string maxDanio, string minDanioMagico, string maxDanioMagico, string minDefensaCasco, string maxDefensaCasco, 
                                            string minDefensaCuerpo, string maxDefensaCuerpo, string minDefensaMagica, string maxDefensaMagica)
        {
            ObjetoModel om = new ObjetoModel();

            try
            {
                om.Nombre = nombre;
                om.Precio = Convert.ToDecimal(precio);
                om.Tipo = Convert.ToInt16(idTipo);
                om.IdSonido = Convert.ToInt16(idSonido);
                om.IdImagen = Convert.ToInt32(idImagen);
                om.IdModelo3d = Convert.ToInt32(idModelo);
                om.IdHechizo = Convert.ToInt16(idHechizo);
                om.ClasesNoPermitidas = clasesNoPermitidas;
                om.Estadisticas = EstadisticasModel.Mapear(Convert.ToInt16(salud), Convert.ToInt16(mana), Convert.ToInt16(hambre), Convert.ToInt16(sed), Convert.ToInt16(fuerza), Convert.ToInt16(agilidad), Convert.ToInt16(peso));
                om.Equipo = EquipoModel.Mapear(Convert.ToInt16(minDanio), Convert.ToInt16(maxDanio), Convert.ToInt16(minDanioMagico), Convert.ToInt16(maxDanioMagico), Convert.ToInt16(minDefensaCasco), Convert.ToInt16(maxDefensaCasco), Convert.ToInt16(minDefensaCuerpo), Convert.ToInt16(maxDefensaCuerpo), Convert.ToInt16(minDefensaMagica), Convert.ToInt16(maxDefensaMagica));
                
            }
            catch (Exception)
            {
                return new ObjetoModel();
            }

            return om;
        }

        public bool ValidarDatos(ObjetoModel objeto)
        {
            // TODO: validar usando logica de negocio
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
