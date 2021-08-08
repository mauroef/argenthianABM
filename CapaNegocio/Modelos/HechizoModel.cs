using CapaDatos.Hechizo;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio.Modelos
{
    public class HechizoModel
    {
        #region Validacion

        public short Id { get; set; }
        public short Tipo { get; set; }
        public string Nombre { get; set; }
        public short IdImagen { get; set; }
        public short IdEfecto { get; set; }
        public short IdSonido { get; set; }
        public string Descripcion { get; set; }
        public string PalabrasMagicas { get; set; }
        public ConsumoModel Consumo { get; set; }
        public TemporalesModel Temporales { get; set; }
        public AtaqueModel Ataque { get; set; }

        #endregion

        private HechizoRepository hechizoRepository;

        public HechizoModel()
        {
            hechizoRepository = new HechizoRepository();
        }

        public DataTable ObtenerDatos()
        {
            DataTable tablaObjeto = new DataTable("hechizo");

            using (var reader = ObjectReader.Create(hechizoRepository.ObtenerTodos(), "id", "tipo", "nombre", "idImagen", "idEfecto", "idSonido", "descripcion", "palabrasMagicas"))
            {
                tablaObjeto.Load(reader);
            }

            return tablaObjeto;
        }

        public HechizoModel ObtenerPorId(short id)
        {
            Hechizo h = hechizoRepository.ObtenerPorId(id);

            return MapearHechizoModel(h);
        }

        public bool GuadarDatos(HechizoModel hechizoModel)
        {
            try
            {
                Hechizo hechizo = MapearObjeto(hechizoModel);

                hechizoRepository.Guardar(hechizo);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public HechizoModel MapearHechizoModel(string tipo, string nombre, string idImagen, string idEfecto, string idSonido, string descripcion,
                                                string palabrasMagicas, string maxMana, string minMana, string maxEnergia, string minEnergia, string paralizar,
                                                string inmovilizar, string congelar, string maxDaño, string minDaño, bool envenenar)
        {
            HechizoModel hm = new HechizoModel();

            try
            {
                hm.Tipo = Convert.ToInt16(tipo);
                hm.Nombre = nombre;
                hm.IdImagen = Convert.ToInt16(idImagen);
                hm.IdEfecto = Convert.ToInt16(idEfecto);
                hm.IdSonido = Convert.ToInt16(idSonido);
                hm.Descripcion = descripcion;
                hm.PalabrasMagicas = palabrasMagicas;
                hm.Consumo = ConsumoModel.Mapear(Convert.ToInt16(maxMana), Convert.ToInt16(minMana), Convert.ToInt16(maxEnergia), Convert.ToInt16(minEnergia));
                hm.Temporales = TemporalesModel.Mapear(Convert.ToInt16(paralizar), Convert.ToInt16(inmovilizar), Convert.ToInt16(congelar));
                hm.Ataque = AtaqueModel.Mapear(Convert.ToInt16(maxDaño), Convert.ToInt16(minDaño), envenenar);
            }
            catch (Exception)
            {
                return new HechizoModel();
            }

            return hm;
        }

        public HechizoModel MapearHechizoModel(Hechizo h)
        {
            HechizoModel hm = new HechizoModel();

            try
            {
                hm.Id = h.id;
                hm.Tipo = Convert.ToInt16(h.tipo);
                hm.Nombre = h.nombre;
                hm.IdImagen = Convert.ToInt16(h.idImagen);
                hm.IdEfecto = Convert.ToInt16(h.idEfecto);
                hm.IdSonido = Convert.ToInt16(h.idSonido);
                hm.Descripcion = h.descripcion;
                hm.PalabrasMagicas = h.palabrasMagicas;
                hm.Consumo = ConsumoModel.Mapear(h.consumo.maxMana, h.consumo.minMana, h.consumo.maxEnergia, h.consumo.minEnergia);
                hm.Temporales = TemporalesModel.Mapear(h.temporales.paralizar, h.temporales.inmovilizar, h.temporales.congelar);
                hm.Ataque = AtaqueModel.Mapear(h.ataque.maxDaño, h.ataque.minDaño, h.ataque.envenenar);

            }
            catch (Exception)
            {
                return new HechizoModel();
            }

            return hm;
        }

        public Hechizo MapearObjeto(HechizoModel hm, short id = 0)
        {
            Hechizo h = new Hechizo();

            h.id = id == 0 ? GenerarId() : id;
            h.tipo = hm.Tipo;
            h.nombre = hm.Nombre;
            h.idImagen = hm.IdImagen;
            h.idEfecto = hm.IdEfecto;
            h.idSonido = hm.IdSonido;
            h.descripcion = hm.Descripcion;
            h.palabrasMagicas = hm.PalabrasMagicas;
            h.consumo.maxMana = hm.Consumo.MaxMana;
            h.consumo.minMana = hm.Consumo.MinMana;
            h.consumo.maxEnergia = hm.Consumo.MaxEnergia;
            h.consumo.minEnergia = hm.Consumo.MinEnergia;
            h.temporales.paralizar = hm.Temporales.Paralizar;
            h.temporales.inmovilizar = hm.Temporales.Inmovilizar;
            h.temporales.congelar = hm.Temporales.Congelar;
            h.ataque.maxDaño = hm.Ataque.MaxDaño;
            h.ataque.minDaño = hm.Ataque.MinDaño;
            h.ataque.envenenar = hm.Ataque.Envenenar;

            return h;
        }

        private short GenerarId()
        {
            return (short)(hechizoRepository.ObtenerUltimoId() + 1);
        }

        public bool ValidarDatos(HechizoModel hechizo)
        {
            // TODO: validar usando logica de negocio
            return !String.IsNullOrEmpty(hechizo.Nombre);
        }

        public bool EliminarPorId(short id)
        {
            try
            {
                hechizoRepository.Eliminar(id);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarPorId(short id, HechizoModel hechizoModel)
        {
            try
            {
                Hechizo hechizo = MapearObjeto(hechizoModel, id);

                hechizoRepository.Editar(id, hechizo);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public partial class ConsumoModel
    {
        public short MaxMana { get; set; }
        public short MinMana { get; set; }
        public short MaxEnergia { get; set; }
        public short MinEnergia { get; set; }

        public static ConsumoModel Mapear(short maxMana, short minMana, short maxEnergia, short minEnergia)
        {
            ConsumoModel co = new ConsumoModel();

            co.MaxMana = maxMana;
            co.MinMana = minMana;
            co.MaxEnergia = maxEnergia;
            co.MinEnergia = minEnergia;

            return co;
        }
    }

    public partial class TemporalesModel
    {
        public float Paralizar { get; set; }
        public float Inmovilizar { get; set; }
        public float Congelar { get; set; }

        public static TemporalesModel Mapear(float paralizar, float inmovilizar, float congelar)
        {
            TemporalesModel te = new TemporalesModel();

            te.Paralizar = paralizar;
            te.Inmovilizar = inmovilizar;
            te.Congelar = congelar;

            return te;
        }
    }

    public partial class AtaqueModel
    {
        public short MaxDaño { get; set; }
        public short MinDaño { get; set; }
        public bool Envenenar { get; set; }

        public static AtaqueModel Mapear(short maxDaño, short minDaño, bool envenenar)
        {
            AtaqueModel at = new AtaqueModel();

            at.MaxDaño = maxDaño;
            at.MinDaño = minDaño;
            at.Envenenar = envenenar;

            return at;
        }
    }
}
