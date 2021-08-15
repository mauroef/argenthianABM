using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Contratos
{
    interface IConfiguracionRepository
    {
        Configuracion.Configuracion Obtener();
    }
}
