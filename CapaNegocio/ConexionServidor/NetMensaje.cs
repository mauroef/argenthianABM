using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio.ConexionServidor
{
    [System.Serializable]
    public abstract class NetMensaje
    {
        public int OP { get; set; }
        public string tokenConexion { get; set; }
        public string idJugadorRed { get; set; }

        public NetMensaje()
        {
            OP = NetOP.None;
        }

    }
}
