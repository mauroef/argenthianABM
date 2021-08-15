using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Archivo
    {
        public static void EscribeEnArchivo(string texto, string rutaArchivo, bool sobrescribir = false)
        {
            StreamWriter sw = new StreamWriter(rutaArchivo + " \n", !sobrescribir);
            sw.Write(texto);
            sw.Close();
        }

        public static void EscribirTxt(string texto, string rutaArchivo)
        {
            using (StreamWriter sw = File.AppendText(rutaArchivo))
            {
                sw.WriteLine(texto);
            }
        }
    }
}
