using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            RECURSIVIDAD Sucesion = new RECURSIVIDAD(); // OBJETO PARA HACER LS LLAMADA DE LOS METODOS DE LA CLASE
            String opcion; int numero;
            do
            {
                Console.Write("\n\tSUCECION DE FIBONACCI (1.FOR || 2.METODOS || 3. AMBOS ) : ");
                opcion = Console.ReadLine();
                if (opcion == "1") // CICLO FOR
                {
                    Console.Write("\n\tNUMERO DE LA SUCECION (FOR): ");
                    numero = int.Parse(Console.ReadLine());
                    Console.Write("\n\tEL NUMERO DE {0} FIBONACCI ES : {1}  ", numero, Sucesion.ForFibonacci(numero));
                    Sucesion.resultado(); // TIEMPO DE EJECUCION 
                }

                else if (opcion == "2") // METODOS RECURSIVIDAD
                {
                    Console.Write("\n\tNUMERO DE LA SUCECION (METODOS RECURSIVIDAD): ");
                    numero = int.Parse(Console.ReadLine());
                    Console.Write("\n\tEL NUMERO DE {0} FIBONACCI ES : {1}  ", numero, Sucesion.Fibonacci(numero));
                    Sucesion.imprimir(numero);
                    Sucesion.resultado();//TIEMPO DEEJECUCION 
                }
                else // AMBOS METODOS 
                {
                    Console.Write("\n\tNUMERO DE LA SUCECION (FOR Y METODOS RECURSIVIDAD): ");
                    numero = int.Parse(Console.ReadLine());

                    Console.Write("\n\tEL NUMERO DE {0} EN FOR FIBONACCI ES : {1}  ", numero, Sucesion.ForFibonacci(numero));

                    Console.Write("\n\tEL NUMERO DE {0} METODOS FIBONACCI ES : {1}  ", numero, Sucesion.Fibonacci(numero));
                    Sucesion.imprimir(numero);
                    Sucesion.resultado();//TIEMPO DEEJECUCION 
                }
                Console.ReadKey();
                Console.Write("\n\tREINIZAR (SI) ");
                opcion = Console.ReadLine();
            }
            while (opcion == "SI"|| opcion =="si");
           }
    }
}
