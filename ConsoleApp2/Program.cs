using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debug.WriteLine("hola");
            //Console.ReadKey(true);
            String cadena = "011100";

            solution(cadena);

        }

        public static int solution(string sss)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int numero = Convert.ToInt32(sss, 2);

            int pasos = 0;

            while (numero != 0)
            {
                if (numero % 2 == 0) numero = numero / 2;
                else numero = numero - 1;

                pasos++;
            }


            Debug.WriteLine(pasos);
            return pasos;
        }


    }
}
