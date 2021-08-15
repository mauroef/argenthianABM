using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Enumeraciones
    {
        public enum TipoObjeto
        {
            Capa = 1,
            Colgante = 2,
            Anillo = 3,
            Escudo = 4,
            Arma = 5,
            Casco = 6,
            Vestimenta = 7,
            Guantes = 8,
            Pantalon = 9,
            Zapatos = 10,
            Utilizable = 11,
            Hechizo = 12,
            Recurso = 13,
            Barco = 14,
            Flecha = 15,
            Arbol = 16,
            Mina = 17,
            HachaLeñador = 18,
            PiqueteMinero = 19,
            Otros = 20,
            Proyectil = 21,
            Madera = 22,
            Hierro = 23,
            Plata = 24,
            Oro = 25,
            Serrucho = 26,
            Martillo = 27,
            Aguja = 28
        }
        public enum TipoArma
        {
            Ninguna = 0,
            Espada = 1,
            Daga = 2,
            Proyectil = 3,
            Antorcha = 4,
            HachaLeñador = 5,
            Serrucho = 6
        }
        public enum Objeto
        {
            Leña = 10,
            MineralHierro = 16,
            MineralPlata = 17,
            MineralOro = 18
        }
        public enum TipoInventario
        {
            Principal = 1,
            AccesoDirecto = 2,
            InventarioVendedor = 3,
            InventarioComprador = 4,
            InventarioCarpinteria = 5,
            InventarioHerreria = 6,
            InventarioSastreria = 7
        }
        public enum TipoSlot
        {
            Objeto = 1,
            Hechizo = 2
        }
        public enum TipoHechizo
        {
            Ataque = 1,
            Sanacion = 2,
            Paralizar = 3,
            Inmovilizar = 4,
            Envenenar = 5,
            CurarVeneno = 6,
            Otro = 7
        }
        public enum TipoControllerCharacter
        {
            Normal = 0,
            EspadaEscudo = 1,
            Espada = 2,
            ArcoFlecha = 3,
            Antorcha = 4,
            Leñador = 5,
            Texto = 6,
            TitilarUI = 7
        }
        public enum TipoNpc
        {
            NoDefinido = 0,
            Comerciante = 1,
            Banquero = 2,
            Sacerdote = 3,
            Hostil = 4
        }
        public enum TipoMacro
        {
            Desactivado = 0,
            Talar = 1,
            Minar = 2,
            Golpear = 3
        }
        public enum TipoTrigger
        {
            VerTecho = 1
        }
        public enum TipoJson
        {
            Carpinteria = 0,
            Ciudades = 1,
            Clases = 2,
            Configuracion = 3,
            Habilidades = 4,
            Hechizos = 5,
            Npcs = 6,
            Objetos = 7,
            Razas = 8
        }
        public enum Idioma
        {
            Español = 1,
            Ingles = 2,
            Aleman = 3,
            Frances = 4,
            Portugues = 5,
            Italiano = 6
        }
        public enum TipoReputacion
        {
            Ciudadano = 1,
            Criminal = 2,
            ArmadaReal = 3,
            LegionOscura = 4,
            Neutral = 5
        }
        public enum TipoTemporal
        {
            Normal = 1,
            Lluvia = 2,
            Nieve = 3
        }
        public enum CodigoCursor
        {
            desactivado = -1,
            normal = 0,
            hechizo = 1,
            hacha = 2,
            flecha = 3,
            piquete = 4,
            dedo = 5,
            guante = 6,
            burbuja = 7
        }
        public enum ColisionVision
        {
            Colision = 1,
            Agua = 2
        }
        public enum TipoMovimientoUsuario
        {
            Quieto = 0,
            Caminar = 1,
            Correr = 2,
            Turbo = 3
        }
        public enum Videos
        {
            Presentacion = 0
        }
        public enum TipoSkin
        {
            Cabello = 1,
            Barba = 2,
            Bigote = 3,
            Cuerpo = 5,
            Manos = 6,
            Piernas = 7,
            Cabeza = 8,
            Orejas = 9,
            Casco = 10,
            Vestimenta = 11,
            Guantes = 12,
            Zapatos = 13
        }
        public enum Grafico2D
        {
            Leña = 12,
            Arco = 16,
            Serrucho = 17,
            Martillo = 18,
            BotonArco = 22,
            BotonSerrucho = 23,
            BotonMartillo = 24,
            BotonAguja = 25,
            logoEscribiendo = 34
        }
        public enum Clase
        {
            Guerrero = 1,
            Paladin = 2,
            Asesino = 3,
            Clerigo = 4,
            Mago = 5,
            Campesino = 6
        }
        public enum Musica
        {
            Inicio = 0,
            DungeonNewbie = 1,
            Medieval = 2,
            Ulla = 3,
            Catacumba = 4
        }
        public enum Imagen
        {
            Espada = 2,
            EscudoSeguro = 11
        }
        public enum TipoPersonaje
        {
            Criatura = 1,
            Usuario = 2
        }
        public enum MovimientoCriatura
        {
            Quieto = 0,
            Caminar = 1,
            Correr = 2,
            CaminarSolo = 3
        }
        public enum CuerpoUsuario
        {
            Torso = 1,
            BrazoIzquierdo = 2,
            BrazoDerecho = 3,
            PiernaDerecha = 4,
            PiernaIzquierda = 5,
            Cabeza = 6
        }
        public enum Sonido
        {
            SinSonido = 0,
            Fallar = 1,
            Sangre = 2,
            Golpe = 3,
            Escudo = 4,
            Muerte = 5,
            Equipar = 6,
            ClickInventario = 7,
            ClickMouse = 8,
            SubirNivel = 9,
            GolpearCriatura = 10,
            EspadazoNormal = 19,
            Martillo = 20,
            Flechazo = 21,
            PicarMina = 22,
            Caminar = 23,
            Correr = 24
        }
        public enum SonidoInventario
        {
            clickObjeto = 1,
            clickMouse = 2
        }
        public enum EfectoParticulas
        {
            sinParticulas = 0,
            dardoMagico = 1,
            misilMagico = 2,
            apocalipsis = 3,
            paralisis = 4,
            meditacionEstandar = 5,
            efectoMuerto = 6,
            seleccion = 7,
            espadazoNormalAzul = 8,
            espadazoNormalRojo = 9,
            dañoRecibido = 10,
            efectoMorir = 11,
            dañoRecibidoUsuario = 12,
            flechazoNormal = 13,
            cambioPersonaje = 14,
            meditacion1 = 15,
            espadaFuego = 16,
            correr = 17
        }
        public enum Estado
        {
            Activo = 1,
            Baneado = 2,
            PendienteActivacion = 3
        }
        public enum Habilidades
        {
            Magia = 1,
            ResistenciaMagica = 2,
            EvasionEnCombate = 3,
            PunteriaConArmas = 4,
            Meditar = 5,
            Apuñalar = 6,
            Ocultarse = 7,
            Talar = 8,
            Carpinteria = 9,
            Mineria = 10,
            Herreria = 11,
            Sastreria = 12,
            Pesca = 13,
            DefensaConEscudos = 14,
            DomarAnimales = 15,
            CombateADistancia = 16
        }
        public enum Raza
        {
            Humano = 1,
            Enano = 2,
            Elfo = 3,
            ElfoOscuro = 4,
            Gnmo = 5
        }
        public enum Color
        {
            Negro = 1,
            Rojo = 2,
            Verde = 3,
            Azul = 4,
            Blanco = 5,
            Amarillo = 6
        }
        public enum TipoCamara
        {
            InicioJuego = 1,
            PanelCuenta = 2,
            CreacionPersonaje = 3,
            JugadorVistaArriba = 4
        }
    }
}
