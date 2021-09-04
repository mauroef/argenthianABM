using CapaDatos.Objeto;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio.Modelos
{
    public class ObjetoModel
    {
        #region Validacion

        public short Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public short Tipo { get; set; }
        public int IdSonido { get; set; }
        public int IdImagen { get; set; }
        public int IdModelo3d { get; set; }
        public short IdHechizo { get; set; }
        public int IdSkin { get; set; }
        public bool NoCae { get; set; }
        public short TipoArma { get; set; }
        public List<short> ClasesNoPermitidas { get; set; }
        public EquipoModel Equipo { get; set; }
        public EstadisticasModel Estadisticas { get; set; }

        #endregion

        private ObjetoRepository objetoRepository;

        public ObjetoModel()
        {
            objetoRepository = new ObjetoRepository();
        }

        public DataTable ObtenerDatos()
        {
            DataTable tablaObjeto = new DataTable("objetos");

            using (var reader = ObjectReader.Create(objetoRepository.ObtenerTodos(), "id", "nombre", "descripcion", "precio", "tipo", "idSonido", "idImagen", "idModelo3d", "idHechizo", "idSkin", "noCae"))
            {
                tablaObjeto.Load(reader);
            }

            return tablaObjeto;
        }

        public static IEnumerable<Objeto> ObtenerListado()
        {
            ObjetoRepository or = new ObjetoRepository();

            return or.ObtenerTodos();
        }

        public ObjetoModel ObtenerPorId(short id)
        {
            Objeto o = objetoRepository.ObtenerPorId(id);

            return MapearObjetoModel(o);
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

        public ObjetoModel MapearObjetoModel(string nombre, string descripcion, string precio, string idTipo, string idSonido, string idImagen,
                                            string idModelo, string idHechizo, string idSkin, bool noCae, string tipoArma, List<short> clasesNoPermitidas, string salud, string mana, string hambre,
                                            string sed, string fuerza, string agilidad, string peso, string minDanio,
                                            string maxDanio, string minDanioMagico, string maxDanioMagico, string minDefensaCasco, string maxDefensaCasco,
                                            string minDefensaCuerpo, string maxDefensaCuerpo, string minDefensaMagica, string maxDefensaMagica)
        {
            ObjetoModel om = new ObjetoModel();

            try
            {
                om.Nombre = nombre;
                om.Descripcion = descripcion;
                om.Precio = Convert.ToDecimal(precio);
                om.Tipo = Convert.ToInt16(idTipo);
                om.IdSonido = Convert.ToInt16(idSonido);
                om.IdImagen = Convert.ToInt32(idImagen);
                om.IdModelo3d = Convert.ToInt32(idModelo);
                om.IdHechizo = Convert.ToInt16(idHechizo);
                om.IdSkin = Convert.ToInt32(idSkin);
                om.NoCae = noCae;
                om.TipoArma = Convert.ToInt16(tipoArma);
                om.ClasesNoPermitidas = clasesNoPermitidas;
                om.Equipo = EquipoModel.Mapear(Convert.ToInt16(minDanio), Convert.ToInt16(maxDanio), Convert.ToInt16(minDanioMagico), Convert.ToInt16(maxDanioMagico), Convert.ToInt16(minDefensaCasco), Convert.ToInt16(maxDefensaCasco), Convert.ToInt16(minDefensaCuerpo), Convert.ToInt16(maxDefensaCuerpo), Convert.ToInt16(minDefensaMagica), Convert.ToInt16(maxDefensaMagica));
                om.Estadisticas = EstadisticasModel.Mapear(Convert.ToInt16(salud), Convert.ToInt16(mana), Convert.ToInt16(hambre), Convert.ToInt16(sed), Convert.ToInt16(fuerza), Convert.ToInt16(agilidad), Convert.ToInt16(peso));
            }
            catch (Exception)
            {
                return new ObjetoModel();
            }

            return om;
        }

        // lectura de informacion
        public ObjetoModel MapearObjetoModel(Objeto o)
        {
            ObjetoModel om = new ObjetoModel();

            try
            {
                om.Id = o.id;
                om.Nombre = o.nombre;
                om.Descripcion = o.descripcion;
                om.Precio = Convert.ToDecimal(o.precio);
                om.Tipo = Convert.ToInt16(o.tipo);
                om.IdSonido = Convert.ToInt16(o.idSonido);
                om.IdImagen = Convert.ToInt32(o.idImagen);
                om.IdModelo3d = Convert.ToInt32(o.idModelo3d);
                om.IdHechizo = Convert.ToInt16(o.idHechizo);
                om.IdSkin = Convert.ToInt16(o.idSkin);
                om.NoCae = o.noCae;
                om.TipoArma = Convert.ToInt16(o.tipoArma);
                om.ClasesNoPermitidas = o.clasesNoPermitidas;
                om.Equipo = EquipoModel.Mapear(Convert.ToInt16(o.equipo.minDaño), Convert.ToInt16(o.equipo.maxDaño), Convert.ToInt16(o.equipo.minDañoMagico), Convert.ToInt16(o.equipo.maxDañoMagico), Convert.ToInt16(o.equipo.minDefCasco), Convert.ToInt16(o.equipo.maxDefCasco), Convert.ToInt16(o.equipo.minDefCuerpo), Convert.ToInt16(o.equipo.maxDefCuerpo), Convert.ToInt16(o.equipo.minDefMagica), Convert.ToInt16(o.equipo.maxDefMagica));
                om.Estadisticas = EstadisticasModel.Mapear(Convert.ToInt16(o.estadisticas.salud), Convert.ToInt16(o.estadisticas.mana), Convert.ToInt16(o.estadisticas.hambre), Convert.ToInt16(o.estadisticas.sed), Convert.ToInt16(o.estadisticas.fuerza), Convert.ToInt16(o.estadisticas.agilidad), Convert.ToInt16(o.estadisticas.peso));               

            }
            catch (Exception)
            {
                return new ObjetoModel();
            }

            return om;
        }

        // guardo nuevo o ya existente por id
        public Objeto MapearObjeto(ObjetoModel om, short id = 0)
        {
            Objeto o = new Objeto();

            o.id = id == 0 ? GenerarId() : id;
            o.nombre = om.Nombre;
            o.descripcion = om.Descripcion;
            o.precio = om.Precio;
            o.tipo = om.Tipo;
            o.idSonido = om.IdSonido;
            o.idImagen = om.IdImagen;
            o.idModelo3d = om.IdModelo3d;
            o.idHechizo = om.IdHechizo;
            o.idSkin = om.IdSkin;
            o.noCae = om.NoCae;
            o.tipoArma = om.TipoArma;
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

        private short GenerarId()
        {
            return (short)(objetoRepository.ObtenerUltimoId() + 1);
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

        public bool EditarPorId(short id, ObjetoModel objetoModel)
        {
            try
            {
                Objeto objeto = MapearObjeto(objetoModel, id);

                objetoRepository.Editar(id, objeto);

                return true;                
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}