using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Configuracion
{
    public class General
    {
        public const int CantidaMaximaSlot = 10000;
        public const int CantidadMaximaInventario = 15;
        public const float IntervaloLimiteEliminarCriatura = 1.5f;
        public const int skillsInicio = 10;

        public class Escenas
        {
            public const string escenaPrincipal = "Conexion";
            public const string escenaJuego = "PantallaJuego";
            public const string escenaMapa = "Principal";
        }

        public class Rutas
        {
            public static string path = "";
            public const string pathCarpinteria = "\\json\\carpinteria.json";
            public const string pathConfiguracion = "\\json\\configuracion.json";
            public const string pathHabilidades = "\\json\\habilidades.json";
            public const string pathClases = "\\json\\clases.json";
            public const string pathRazas = "\\json\\razas.json";
            public const string pathCiudades = "\\json\\ciudades.json";
            public const string pathObjetos = "\\json\\objetos.json";
            public const string pathHechizos = "\\json\\hechizos.json";
            public const string pathNpcs = "\\json\\npcs.json";
        }
    }
}
