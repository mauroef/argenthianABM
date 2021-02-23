using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Enumeraciones
    {
        public enum Grafico2D
        {
            Serrucho = 17,
            Martillo = 18
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
            Ulla = 3
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

        public enum CuerpoUsuario
        {
            Torso = 1,
            BrazoIzquierdo = 2,
            BrazoDerecho = 3,
            PiernaDerecha = 4,
            PiernaIzquierda = 5,
            Cabeza = 6
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
            dañoRecibidoUsuario = 12
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
            Elfo = 2,
            ElfoOscuro = 3,
            Enano = 4,
            Gnmo = 5
        }

        public enum Videos
        {
            Presentacion = 0
        }

        public enum MovimientoCriatura
        {
            Quieto = 0,
            Caminar = 1,
            Correr = 2,
            CaminarSolo = 3
        }

        //Para moverse
        public enum TipoMovimientoUsuario
        {
            Quieto = 0,
            Caminar = 1,
            Correr = 2
        }

        public enum TipoControllerCharacter
        {
            Normal = 0,
            EspadaEscudo = 1,
            Espada = 2,
            ArcoFlecha = 3
        }

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
            Martillo = 27
        }

        public enum TipoArma
        {
            Espada = 1,
            Daga = 2,
            Proyectil = 3
        }

        public enum Objeto
        {
            Leña = 10,
            MineralHierro = 11,
            MineralPlata = 12,
            MineralOro = 13
        }

        public enum TipoInventario
        {
            Principal = 1,
            AccesoDirecto = 2
        }

        public enum TipoSlot
        {
            Principal = 1,
            AccesoDirecto = 2
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

        public enum TipoNpc
        {
            NoDefinido = 0,
            Comerciante = 1,
            Banquero = 2,
            Sacerdote = 3,
            Hostil = 4
        }

        public enum CodigoCursor
        {
            normal = 0,
            hechizo = 1,
            hacha = 2
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
    }
}
