using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
    public class RepositoryComplete
    {
        public IEnumerable<Carpinteria.Carpinteria> carpinteria { get; set; }
        public IEnumerable<Ciudad.Ciudad> ciudades { get; set; }
        public IEnumerable<Clase.Clase> clases { get; set; }
        public Configuracion.Configuracion configuracion { get; set; }
        public IEnumerable<Habilidad.Habilidad> habilidades { get; set; }
        public IEnumerable<Hechizo.Hechizo> hechizos { get; set; }
        public IEnumerable<Npc.Npc> npcs { get; set; }
        public IEnumerable<Objeto.Objeto> objetos { get; set; }
        public IEnumerable<Raza.Raza> razas { get; set; }

        public void CargarDatos (string ruta)
        {
            this.carpinteria = new Carpinteria.CarpinteriaRepository(ruta + "\\json\\carpinteria.json").ObtenerTodos();
            this.ciudades = new Ciudad.CiudadRepository(ruta + "\\json\\ciudades.json").ObtenerTodos();
            this.clases = new Clase.ClaseRepository(ruta + "\\json\\clases.json").ObtenerTodos();
            this.configuracion = new Configuracion.ConfiguracionRepository(ruta + "\\json\\configuracion.json").Obtener();
            this.habilidades = new Habilidad.HabilidadRepository(ruta + "\\json\\habilidades.json").ObtenerTodos();
            this.hechizos = new Hechizo.HechizoRepository(ruta + "\\json\\hechizos.json").ObtenerTodos();
            this.npcs = new Npc.NpcRepository(ruta + "\\json\\npcs.json").ObtenerTodos();
            this.objetos = new Objeto.ObjetoRepository(ruta + "\\json\\objetos.json").ObtenerTodos();
            this.razas = new Raza.RazaRepository(ruta + "\\json\\razas.json").ObtenerTodos();

            this.CargarObjetosEnCarpinteria();
        }
        public Objeto.Objeto ObtenerObjetoPorId(int idObjeto)
        {
            foreach (Objeto.Objeto objeto in this.objetos)
            {
                if (objeto.id == idObjeto)
                    return objeto;
            }

            return null;
        }

        public Hechizo.Hechizo ObtenerHechizoPorId(int idHechizo)
        {
            foreach (Hechizo.Hechizo hechizo in this.hechizos)
            {
                if (hechizo.id == idHechizo)
                    return hechizo;
            }

            return null;
        }

        public Npc.Npc ObtenerNpcPorId(int idNpc)
        {
            foreach (Npc.Npc npc in this.npcs)
            {
                if (npc.id == idNpc)
                    return npc;
            }

            return null;
        }

        public Carpinteria.Carpinteria ObtenerObjetoCarpinteriaPorId(short idCarpinteria)
        {
            foreach (Carpinteria.Carpinteria carpinteria in this.carpinteria)
            {
                if (carpinteria.id == idCarpinteria)
                    return carpinteria;
            }

            return null;
        }

        public List<Carpinteria.Carpinteria> ObtenerObjetosCarpinteriaPorSkills(int skills)
        {
            List<Carpinteria.Carpinteria> listaCarpinteriaResultado = new List<Carpinteria.Carpinteria>();
            foreach (Carpinteria.Carpinteria carpinteria in this.carpinteria)
            {
                if (carpinteria.skills <= skills)
                {
                    listaCarpinteriaResultado.Add(carpinteria);
                }

            }

            return listaCarpinteriaResultado;
        }

        public Carpinteria.Carpinteria ObtenerObjetosCarpinteriaPorIdObjeto(int idObjeto)
        {
            foreach (Carpinteria.Carpinteria carpinteria in this.carpinteria)
            {
                if (carpinteria.objeto.id == idObjeto)
                    return carpinteria;
            }

            return null;
        }

        public void CargarObjetosEnCarpinteria()
        {
            foreach (Carpinteria.Carpinteria carpinteria in this.carpinteria)
            {
                carpinteria.objeto = this.ObtenerObjetoPorId(carpinteria.idObjeto);
            }
        }

        public Ciudad.Ciudad ObtenerCiudadPorId(short idCiudad)
        {
            foreach (Ciudad.Ciudad ciudad in this.ciudades)
            {
                if (ciudad.id == idCiudad)
                    return ciudad;
            }

            return null;
        }

    }
}
