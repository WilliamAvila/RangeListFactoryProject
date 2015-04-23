using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = "1,2,3,5,7,9,10";

            var listRangos = ListaRangoFabrica.ConstruirListaDeRangos(cadena);

            foreach(var x in listRangos)
            {
                Console.WriteLine(x.LimiteInferior +"-"+x.LimiteSuperior);
            }

                Console.ReadLine();
        }
    }
}
