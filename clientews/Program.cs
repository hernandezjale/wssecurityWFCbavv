using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientews
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente=  new clientews.manejoidentidad01.WSBA_ManejoIdentidad_autenticar_FMClient();
            var respuesta = cliente.autenticar(new manejoidentidad01.autenticar() { oe_entrada = new manejoidentidad01.oe_Autenticacion() { strUsuario = "1032396905", strContrasena = "PWd12345" } });
            Console.WriteLine("Respuesta WS");
            Console.WriteLine(" " + respuesta.os_salida.@return);

            Console.Write("\n\n\tPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
