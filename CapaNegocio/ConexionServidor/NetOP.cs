using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio.ConexionServidor
{
    public class NetOP
    {
        public const int None = 0;
        //public const int CrearCuenta = 1;
        public const int IngresarUsuario = 2;
        public const int ConsultarPosicionUsuario = 3;
        public const int MovimientoUsuario = 4;
        public const int Usuario = 5;
        public const int UtilizarObjetoSlot = 6;
        public const int AccionFisica = 7;
        public const int LanzarHechizo = 8;
        public const int Click = 9;
        public const int Hablar = 10;
        public const int CrearCuenta = 11;
        public const int IngresarCuenta = 12;
        public const int CrearPersonaje = 13;
        public const int Consulta = 14; //No se envia nada, solo es una consulta sobre datos
        public const int MoverHechizo = 15;
        public const int InteractuarNpc = 16;
        public const int Atacar = 17;
        public const int Construir = 18;
        public const int Configuracion = 19;
        public const int AccionObjetoMapa = 20;
        public const int RotacionUsuario = 21;

        //Mensajes del servidor hacia el cliente
        public const int Respuesta_MensajeMenu = 10000;
        public const int Respuesta_PosicionUsuario = 10001;
        public const int Respuesta_MovimientoUsuarioRed = 1002;
        public const int Respuesta_MovimientoCriatura = 1003;
        public const int Respuesta_Animacion = 1004;
        public const int Respuesta_EstadisticasUsuario = 1005;
        public const int Respuesta_MensajeConsola = 1006;
        public const int Respuesta_Sonido = 1007;
        public const int Respuesta_Inventario = 1008;
        public const int Respuesta_InfoUsuarioRed = 1009;
        public const int Respuesta_Hablar = 1010;
        public const int Respuesta_Cursor = 1011;
        public const int Respuesta_InventarioHechizo = 1012;
        public const int Respuesta_CrearCuenta = 1013;
        public const int Respuesta_IngresarCuenta = 1014;
        public const int Respuesta_PanelCuenta = 1015;
        public const int Respuesta_Aviso = 1016;
        public const int Respuesta_MenuCrearPersonaje = 1017;
        public const int Respuesta_Informacion = 1018;
        public const int Respuesta_EnergiaEfecto = 1019;
        public const int Respuesta_EstadoUsuario = 1020;
        public const int Respuesta_ObjetosNpc = 1021;
        public const int Respuesta_InfoMapa = 1022;
        public const int Respuesta_MovimientoCriaturaReducido = 1023;
        public const int Respuesta_MovimientoUsuario = 1024;
        public const int Respuesta_EliminarObjetoMapa = 1025;
        public const int Respuesta_InventarioTrabajo = 1026;
        public const int Respuesta_MensajePantalla = 1027;
        public const int Respuesta_InfoClima = 1028;
        public const int Respuesta_RotacionUsuario = 1029;
        public const int Respuesta_ObjetosMapa = 1030;
    }
}
