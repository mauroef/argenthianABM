using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio.ConexionServidor
{
        [System.Serializable]
        public class NetRespuestaPanel : NetMensaje
        {

            public bool esCorrecto;
            public string mensaje;
            public Enumeraciones.Color color;
            public string tagTextInput;
            public string tokenEstablecido;
        }

    [System.Serializable]
        public class NetConsultaBasica : NetMensaje
        {

            public NetConsultaBasica(int op)
            {
                OP = op;
            }

        }

        [System.Serializable]
        public class NetMovimientoUsuario : NetMensaje
        {
            public NetMovimientoUsuario()
            {
                OP = NetOP.MovimientoUsuario;
            }

            public short idTipoMovimiento { get; set; }
            public float posicionY { get; set; }
            public float posicionX { get; set; }
            public float posicionZ { get; set; }
            public float rotacionX { get; set; }
            public float rotacionY { get; set; }
            public float rotacionZ { get; set; }
            public float rotacionW { get; set; }
        }

        [System.Serializable]
        public class NetHablar : NetMensaje
        {
            public enum tipoIcono
            {
                sinIcono = 0,
                escribiendo = 1
            }
            public NetHablar()
            {
                OP = NetOP.Hablar;
            }

            public short idTipoIcono;
            public string texto;
            public int color;

        }

        [System.Serializable]
        public class NetRespuestaPosicionUsuario : NetMensaje
        {

            public NetRespuestaPosicionUsuario()
            {
                OP = NetOP.Respuesta_PosicionUsuario;
                this.listaIdObjetoEquipo = new short[10];
            }

            public string idJugadorRed { get; set; }
            public float posicionX { get; set; }
            public float posicionY { get; set; }
            public float posicionZ { get; set; }
            public short[] listaIdObjetoEquipo { get; set; }

        }

        [System.Serializable]
        public class NetRespuestaPosicionUsuarioRed : NetMensaje
        {
            public NetRespuestaPosicionUsuarioRed()
            {
                OP = NetOP.Respuesta_MovimientoUsuarioRed;
            }

            public short idTipoMovimiento { get; set; }
            public float velocidadNormal { get; set; }
            public float velocidadCorriendo { get; set; }
            public float posicionX { get; set; }
            public float posicionY { get; set; }
            public float posicionZ { get; set; }
            public float rotacionX { get; set; }
            public float rotacionY { get; set; }
            public float rotacionZ { get; set; }
            public float rotacionW { get; set; }

            public string nombreUsuario { get; set; }
            public int colorNombre { get; set; }
            public bool muerto { get; set; }
        }


        [System.Serializable]
        public class NetRespuestaCriaturaMovimiento : NetMensaje
        {

            public enum TipoMovimiento
            {
                Quieto = 0,
                Caminar = 1,
                Correr = 2
            }

            public NetRespuestaCriaturaMovimiento()
            {
                OP = NetOP.Respuesta_MovimientoCriatura;
            }

            public int[] idNpc = new int[20];
            public short[] codigoMapa = new short[20];
            public string[] idRespawn = new string[20];
            public int[] idAnimacion = new int[20];
            //public float[] posicionX = new float[10];
            //public float[] posicionY = new float[10];
            //public float[] posicionZ = new float[10];
            public bool[] destruir = new bool[20];
        }


        [System.Serializable]
        public class NetRespuestaAnimacion : NetMensaje
        {
            public enum TipoGameObject
            {
                SinImpacto = 0,
                UsuarioRed = 1,
                CriaturaRed = 2
            }

            public NetRespuestaAnimacion()
            {
                OP = NetOP.Respuesta_Animacion;
            }

            public string id { get; set; } //id de quien realiza la animacion
            public string idImpacto { get; set; } //id de quien recibe un impacto en caso de recibirlo
            public short tipoGameObject { get; set; }
            public short tipoGameObjectImpacto { get; set; }
            public string animacion { get; set; }
            public bool valorAnimacion { get; set; }
            public float posicionX { get; set; }
            public float posicionY { get; set; }
            public float posicionZ { get; set; }
            public float rotacionX { get; set; }
            public float rotacionY { get; set; }
            public float rotacionZ { get; set; }
            public float rotacionW { get; set; }
            public int idSonido { get; set; }
            public int idEfecto { get; set; }
            public int idEfectoImpacto { get; set; }
            public short idParteCuerpoEfecto { get; set; }
            public float delayAnimacion { get; set; }
        }


        [System.Serializable]
        public class NetRespuestaEstadisticaUsuario : NetMensaje
        {

            public NetRespuestaEstadisticaUsuario()
            {
                OP = NetOP.Respuesta_EstadisticasUsuario;
            }
            //Esto se puede dividir en subpaquetes de envio para no actualizar todo si no es necesario y gastar menos ancho de banda
            public string nombre { get; set; }
            public short hpMin { get; set; }
            public short hpMax { get; set; }
            public short manaMin { get; set; }
            public short manaMax { get; set; }
            public short energiaMax { get; set; }
            public short energiaMin { get; set; }
            public short hambreMin { get; set; }
            public short hambreMax { get; set; }
            public short sedMin { get; set; }
            public short sedMax { get; set; }
            public long expMin { get; set; }
            public long expMax { get; set; }
            public short nivel { get; set; }
            public short fuerza { get; set; }
            public short agilidad { get; set; }
            public int monedasOro { get; set; }
            public float velocidadNormal { get; set; }
            public float velocidadCorriendo { get; set; }
        }

        [System.Serializable]
        public class NetRespuestaEstadoUsuario : NetMensaje
        {

            public NetRespuestaEstadoUsuario()
            {
                OP = NetOP.Respuesta_EstadoUsuario;
            }

            public bool estaParalizado { get; set; }
            public bool estaMeditando { get; set; }
            public bool muerto { get; set; }
        }

        [System.Serializable]
        public class NetRespuestaMensajeConsola : NetMensaje
        {

            public NetRespuestaMensajeConsola()
            {
                OP = NetOP.Respuesta_MensajeConsola;
            }

            //Los mensajes y colores estan separados por comas secuncialmente
            public string listaMensajes;
        }

        [System.Serializable]
        public class NetRespuestaSonidoParticula : NetMensaje
        {
            public enum TipoGameObject
            {
                UsuarioRed = 1,
                CriaturaRed = 2
            }

            public NetRespuestaSonidoParticula()
            {
                OP = NetOP.Respuesta_Sonido;
            }

            public string idGameObjectRed;
            public int sonido;
            public float volumen;
            public float maxDistancia;
            public float minDistancia;
            public short tipoGameObject;
            public int idParticula;

            //Esto nos sirve para mandar aca mismo en un solo mensaje las palabras magicas si el efecto es un hechizo
            /*Para palabras magicas*/
            public string chatIdObjeto;
            public short chatTipoGameObject;
            public string chatTexto;
            public int chatColor;

        }

        [System.Serializable]
        public class NetRespuestaInventario : NetMensaje
        {
            public NetRespuestaInventario()
            {
                OP = NetOP.Respuesta_Inventario;
            }

            public int[] idObjetoInventario = new int[15];
            public short[] idObjetoInventarioAccesoDirecto = new short[15];
            public short[] cantidadInventario = new short[15];
            public int[] idObjetoEquipo = new int[10];

        }

        [System.Serializable]
        public class NetUtilizarObjetoSlot : NetMensaje
        {
            public enum TipoAccion
            {
                utilizar = 1,
                utilizarDobleClick = 2,
                equipar = 3,
                desequipar = 4,
                agregarAccesoDirecto = 5,
                mover = 6,
                tirar = 7,
                vender = 8
            }
            public NetUtilizarObjetoSlot()
            {
                OP = NetOP.UtilizarObjetoSlot;
            }

            public short idSlot;
            public short idSlotDestino; //Para mover o asignar acceso directo
            public short tipoAccion;
            public int cantidad; //Para tirar y vender
            public float posicionX;
            public float posicionY;
            public float posicionZ;
        }

        [System.Serializable]
        public class NetRespuestaUsuarioRedInfo : NetMensaje
        {
            public NetRespuestaUsuarioRedInfo()
            {
                OP = NetOP.Respuesta_InfoUsuarioRed;
                cuerpoIdSkin = new short[10];
                cuerpoIdTipoSkin = new short[10];
                idTexturaSkin = new short[10];
            }




            public string idUsuario;
            public short skin1;
            public short skin2;
            public short skin3;
            public short skin4;
            public short skin5;
            public short skin6;
            public string nombre;
            public short idRaza;
            public short colorNombre;
            public string clan;
            public bool muerto;
            public float x;
            public float y;
            public float z;
            public short codigoMapa;
            public bool estaMuerto;
            public bool estaMeditando;

            public short[] cuerpoIdSkin;
            public short[] cuerpoIdTipoSkin;
            public short[] idTexturaSkin;

            public float velocidadNormal;
            public float velocidadCorriendo;
            public float velocidadTurbo;
            public float energiaCorriendo;
            public float energiaTurbo;
        }

        [System.Serializable]
        public class NetAccionFisica : NetMensaje
        {
            public enum TipoAccionFisica
            {
                golpear = 1,
                saltar = 2,
                agacharse = 3,
                quitarSeguro = 4,
                meditar = 5,
                burlarse = 6
            }
            public NetAccionFisica()
            {
                OP = NetOP.AccionFisica;
            }

            public short tipoAccion;
            public float rotacionX;
            public float rotacionY;
            public float rotacionZ;
            public float rotacionW;
        }

        [System.Serializable]
        public class NetLanzarHechizo : NetMensaje
        {

            public NetLanzarHechizo()
            {
                OP = NetOP.LanzarHechizo;
            }

            public int idSlot;
            public float originX;
            public float originY;
            public float originZ;
            public float directionX;
            public float directionY;
            public float directionZ;
        }

        [System.Serializable]
        public class NetClick : NetMensaje
        {

            public NetClick()
            {
                OP = NetOP.Click;
            }

            public float x;
            public float z;
        }

        [System.Serializable]
        public class NetMoverHechizo : NetMensaje
        {
            public enum TipoAccion
            {
                agregarAccesoDirecto = 1,
                mover = 2
            }
            public NetMoverHechizo()
            {
                OP = NetOP.MoverHechizo;
            }

            public short idSlot;
            public short idSlotDestino; //Para mover o asignar acceso directo
            public short tipoAccion;
        }


        [System.Serializable]
        public class NetInteractuarNpc : NetMensaje
        {
            public enum TipoAccion
            {
                comerciar = 1,
                boveda = 2,
                comprar = 3,
                vender = 4
            }
            public NetInteractuarNpc()
            {
                OP = NetOP.InteractuarNpc;
            }

            public string idNpc;
            public short idTipoAccion;
            public short idSlot;
            public short cantidad;
        }

        [System.Serializable]
        public class NetRespuestaHablar : NetMensaje
        {
            public enum TipoGameObject
            {
                UsuarioRed = 1,
                CriaturaRed = 2
            }

            public NetRespuestaHablar()
            {
                OP = NetOP.Respuesta_Hablar;
            }

            public short idImagen;
            public string id;
            public short tipoGameObject;
            public string texto;
            public int color;

        }

        [System.Serializable]
        public class NetRespuestaCursor : NetMensaje
        {
            enum TipoCursor
            {
                Normal = 1,
                Hechizo = 2,
                Flecha = 3
            }
            public NetRespuestaCursor()
            {
                OP = NetOP.Respuesta_Cursor;
            }

            public short tipoCursor;
        }

        [System.Serializable]
        public class NetRespuestaHechizo : NetMensaje
        {
            public NetRespuestaHechizo()
            {
                OP = NetOP.Respuesta_InventarioHechizo;
            }

            public short[] idHechizo = new short[15];
            public short[] idHechizoAccesoDirecto = new short[15];
        }

        [System.Serializable]
        public class NetCrearCuenta : NetMensaje
        {

            public NetCrearCuenta()
            {
                OP = NetOP.CrearCuenta;
            }

            public string cuenta;
            public string clave;
            public string repetirClave;
            public string email;
        }

        [System.Serializable]
        public class NetIngresarCuenta : NetMensaje
        {

            public NetIngresarCuenta()
            {
                OP = NetOP.IngresarCuenta;
            }

            public string cuenta;
            public string clave;
            public int idUsuario;
        }


        [System.Serializable]
        public class NetRespuestaPanelCuenta : NetMensaje
        {

            public NetRespuestaPanelCuenta()
            {
                OP = NetOP.Respuesta_PanelCuenta;
                cuerpoIdSkin = new short[10];
                cuerpoIdTipoSkin = new short[10];
                idTexturaSkin = new short[10];
            }
            //Aca podemos enviar todos los datos que queramos de los personajes de la cuenta
            public string token;
            public int idUsuario;
            public int[] listaIdUsuarios = new int[5];
            public string nombreCuenta;
            public string nombreUsuario;
            public short nivel;
            public long expMax;
            public long expMin;
            public short idClase;
            public short idRaza;
            public short hpMax;
            public short hpMin;
            public short manaMax;
            public short manaMin;

            public short skin1;
            public short skin2;
            public short skin3;
            public short skin4;
            public short skin5;
            public short skin6;


            public bool estaMuerto;
            public short idModeloPersonaje;
            //public float modeloPersonajeColorRojo;
            //public float modeloPersonajeColorVerde;
            //public float modeloPersonajeColorAzul;

            public short[] cuerpoIdSkin;
            public short[] cuerpoIdTipoSkin;
            public short[] idTexturaSkin;
            //public float[] cuerpoColorRojo;
            //public float[] cuerpoColorVerde;
            //public float[] cuerpoColorAzul;
        }


        //[System.Serializable]
        //public class NetRespuestaPanelCuenta : NetMensaje
        //{

        //    public NetRespuestaPanelCuenta()
        //    {
        //        OP = NetOP.Respuesta_PanelCuenta;
        //    }
        //    //Aca podemos enviar todos los datos que queramos de los personajes de la cuenta
        //    public string token;
        //    public int[] idUsuario = new int [4];
        //    public string[] nombreusuario = new string[4];
        //    public short[] nivel = new short[4];
        //    public long[] expMax = new long[4];
        //    public long[] expMin = new long[4];
        //    public short[] idClase = new short[4];
        //    public short[] idRaza = new short[4];
        //    public short[] fuerza = new short[4];
        //    public short[] agilidad = new short[4];
        //    public short[] inteligencia = new short[4];
        //    public short[] carisma = new short[4];
        //    public short[] constitucion = new short[4];
        //    public short[] hpMax = new short[4];
        //    public short[] hpMin = new short[4];
        //    public short[] manaMax = new short[4];
        //    public short[] manaMin = new short[4];
        //}

        [System.Serializable]
        public class NetCrearPersonaje : NetMensaje
        {

            public NetCrearPersonaje()
            {
                OP = NetOP.CrearPersonaje;
            }

            public string nombre;
            public short idClase;
            public short idRaza;
            public string genero;

            public short[] skills = new short[20];

            public short indexCuerpoSeleccionado;
            public short indexCabezaSeleccionada;
            public short indexManosSeleccionada;
            public short indexPiernasSeleccionada;
            public short indexOrejasSeleccionada;
            public short indexCabelloSeleccionado;
            public short indexBarbaSeleccionado;
            public short indexBigoteSeleccionado;
            public short indexColorPersonaje;
            public short indexColorCabello;
        }

        [System.Serializable]
        public class NetIngresarUsuario : NetMensaje
        {

            public NetIngresarUsuario()
            {
                OP = NetOP.IngresarUsuario;
            }

            public int idUsuario { get; set; }
        }

        [System.Serializable]
        public class NetRespuestaAviso : NetMensaje
        {

            public enum TipoAviso
            {
                Info = 1,
                Advertencia = 2,
                Error = 3,
                Imagen = 4
            }

            public NetRespuestaAviso()
            {
                OP = NetOP.Respuesta_Aviso;
            }
            public string tag;
            public short tipoAviso;
            public string titulo;
            public string texto;
            public short color;
            public int idImagen2D;
        }


        [System.Serializable]
        public class NetConsulta : NetMensaje
        {
            public enum TipoConsulta
            {
                MenuCrearPersonaje = 1,
                PosicionPersonaje = 2,
                SalirCuenta = 3,
                Salir = 4,
                InfoUsuario = 5,
                SalirCrearPersonaje = 6
            }

            public NetConsulta()
            {
                OP = NetOP.Consulta;
            }

            public short IdTipoConsulta;

        }

        [System.Serializable]
        public class NetRespuestaMenuCrearPersonaje : NetMensaje
        {
            public NetRespuestaMenuCrearPersonaje()
            {
                OP = NetOP.Respuesta_MenuCrearPersonaje;

            }

            public int fuerza;
            public int agilidad;
            public int inteligencia;
            public int carisma;
            public int constitucion;

        }

        [System.Serializable]
        public class NetRespuestaInformacion : NetMensaje
        {
            public enum TipoInformacion
            {
                SalirCuenta = 1,
                Salir = 2
            }

            public NetRespuestaInformacion()
            {
                OP = NetOP.Respuesta_Informacion;
            }

            public short idTipoInformacion;
        }

        [System.Serializable]
        public class NetRespuestaEnergiaEfecto : NetMensaje
        {
            public NetRespuestaEnergiaEfecto()
            {
                OP = NetOP.Respuesta_EnergiaEfecto;
            }

            public short idEfectoParticulas;
        }

        [System.Serializable]
        public class NetRespuestaObjetosNpc : NetMensaje
        {
            public enum TipoNpc
            {
                comerciar = 1,
                boveda = 2
            }
            public NetRespuestaObjetosNpc()
            {
                OP = NetOP.Respuesta_ObjetosNpc;
            }

            public string idNpcRespawn;
            public short idTipoNpc;
            public int[] idObjetoInventario = new int[20];
            public int[] objetoCantidad = new int[20];
        }

        [System.Serializable]
        public class NetInfoMapa : NetMensaje
        {

            public NetInfoMapa()
            {
                OP = NetOP.Respuesta_InfoMapa;
            }

            public short codigoMapa;
            public string nombreMapa;
            public string mensajeBienvenida;
            public bool zonaSegura;
            public short idMusica;
            public int idImagen;
        }

        [System.Serializable]
        public class NetAtacar : NetMensaje
        {
            public enum DestinoAtaque
            {
                Usuario = 1,
                Criatura = 2
            }

            public enum TipoAtaque
            {
                Fisico = 1,
                Hechizo = 2,
                Arco = 3
            }

            public NetAtacar()
            {
                OP = NetOP.Atacar;
            }

            public string idDestino;
            public short idDestinoAtaque;
            public short idTipoAtaque;
            public short idSlotHechizo;
        }

        [System.Serializable]
        public class NetRespuestaCriaturaMovimientoReducido : NetMensaje
        {

            public NetRespuestaCriaturaMovimientoReducido()
            {
                OP = NetOP.Respuesta_MovimientoCriaturaReducido;
            }

            public string[] idRespawn = new string[20];
            public float[] posicionX = new float[20];
            public float[] posicionY = new float[20];
            public float[] posicionZ = new float[20];
        }

        [System.Serializable]
        public class NetRespuestaMovimientoUsuarioRed : NetMensaje
        {
            public NetRespuestaMovimientoUsuarioRed()
            {
                OP = NetOP.Respuesta_MovimientoUsuarioRed;
            }

            public string[] idUsuario = new string[20];
            public short[] idTipoMovimiento = new short[20];
            public float[] posicionX = new float[20];
            public float[] posicionY = new float[20];
            public float[] posicionZ = new float[20];
        }

        [System.Serializable]
        public class NetEliminarObjetoMapa : NetMensaje
        {
            public NetEliminarObjetoMapa()
            {
                OP = NetOP.Respuesta_EliminarObjetoMapa;
            }

            public string idUsuarioRed;
            public string idCriaturaRed;
        }

        [System.Serializable]
        public class NetConstruir : NetMensaje
        {
            public enum TipoTrabajo
            {
                Carpinteria = 1,
                Herreria = 2,
                Sastreria = 3,
                ListadoCarpinteria = 4,
                ListadoHerreria = 5,
                ListadoSastreria = 6
            }

            public NetConstruir()
            {
                OP = NetOP.Construir;
            }

            public int idObjTrabajo; //No es el id del objeto sino de carpinteria, herreria o sastreria
            public int cantidad;
            public short tipoTrabajo;
        }

        [System.Serializable]
        public class NetConfiguracion : NetMensaje
        {
            public NetConfiguracion()
            {
                OP = NetOP.Configuracion;
            }

            public short idIdioma;

        }

        [System.Serializable]
        public class NetRespuestaInventarioTrabajo : NetMensaje
        {
            public enum TipoTrabajo
            {
                carpinteria = 1,
                herreria = 2,
                sastreria = 3
            }
            public NetRespuestaInventarioTrabajo()
            {
                OP = NetOP.Respuesta_InventarioTrabajo;
            }

            public short idTipoTrabajo;
            public int[] idObjetoTrabajo = new int[40]; //idCarpinteria, idHerreria, idSastreria
            public int[] idObjetoInventario = new int[40];
        }

        [System.Serializable]
        public class NetRespuestaMensajePantalla : NetMensaje
        {
            public NetRespuestaMensajePantalla()
            {
                OP = NetOP.Respuesta_MensajePantalla;
            }

            public string mensaje;
            public short idColor;
        }

        [System.Serializable]
        public class NetRespuestaInfoClima : NetMensaje
        {
            public NetRespuestaInfoClima()
            {
                OP = NetOP.Respuesta_InfoClima;
            }

            public short idTipoTemporal;
            public float intensidadTemporal;
            public float intensidadLuz;
            public bool cambioGradual;
        }


        [System.Serializable]
        public class NetAccionObjetoMapa : NetMensaje
        {

            public enum TipoAccion
            {
                utilizarRecurso = 1,
                agarrar = 2
            }
            public NetAccionObjetoMapa()
            {
                OP = NetOP.AccionObjetoMapa;
            }

            public float posicionX;
            public float posicionY;
            public float posicionZ;
            public short idTipoAccion;
            public string idObjeto;
        }

        [System.Serializable]
        public class NetRotacionUsuario : NetMensaje
        {

            public NetRotacionUsuario()
            {
                OP = NetOP.RotacionUsuario;
            }

            public float posicionX;
            public float posicionY;
            public float posicionZ;
            public float posicionW;
        }


        [System.Serializable]
        public class NetRespuestaRotacionUsuarioRed : NetMensaje
        {
            public NetRespuestaRotacionUsuarioRed()
            {
                OP = NetOP.Respuesta_RotacionUsuario;
            }

            public string idUsuario;
            public float posicionX;
            public float posicionY;
            public float posicionZ;
            public float posicionW;
        }

        [System.Serializable]
        public class NetRespuestaObjetoMapa : NetMensaje
        {
            public NetRespuestaObjetoMapa()
            {
                OP = NetOP.Respuesta_ObjetosMapa;
            }

            public string idObjetoRed;
            public bool quitarDeMapa;
            public int idObjeto;
            public int cantidad;
            public float posicionX;
            public float posicionY;
            public float posicionZ;
        }

    
}
