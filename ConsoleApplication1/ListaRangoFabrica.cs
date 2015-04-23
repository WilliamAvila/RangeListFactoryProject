using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class ListaRangoFabrica
    {
        public static List<Rango> ConstruirListaDeRangos(string cadena)
        {
            var arreglo = cadena.Split(',');

            var numeros = ConvertirAListaDeEnteros(arreglo);

            var listRangos = new List<Rango>();

            var rango = new Rango();
            rango.LimiteInferior = numeros[0];

            for (int i = 0; i < numeros.Count() - 1; i++)
            {
                rango.LimiteSuperior = numeros[i];
                if (numeros[i] != (numeros[i + 1] - 1))
                {
                    listRangos.Add(rango);
                    rango = new Rango();
                    rango.LimiteInferior = numeros[i + 1];
                }
            }
            rango.LimiteSuperior = numeros.Last();
            listRangos.Add(rango);
            return listRangos;
        }

        private static List<int> ConvertirAListaDeEnteros(string[] arreglo)
        {
            return arreglo.Select(s => Int32.Parse(s)).ToList();
        }
    }
}