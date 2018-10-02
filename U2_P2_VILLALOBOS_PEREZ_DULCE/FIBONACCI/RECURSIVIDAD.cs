using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FIBONACCI
{
    class RECURSIVIDAD
    {
     
        public int ForFibonacci(int numero) //FIBONACCI CON EL CICLO FOR 
        {
            int final=0, inicial = 1, suma = 0;
            if (numero < 2)
                return numero;
            else
            {
                for (int contar = 0; contar < numero; contar++)
                {
                    final = inicial + suma; // AL RESULTADO ES IGUAL A LA SUMA DEL VALOR INICIAL MAS EL 2DO
                    suma = inicial; //LA SUMA ES IGUAL AL VALOR INICIAL 
                    inicial = final; // ES VALOR INICIAL ES IGUAL AL RESULTADO               
                }
                return suma;  // RESULTADO ES IGUAL A SUMA POR QUE ES EL VALOR FINAL ANTES DE REINICIAR LA SUCESION            
            }          
        }

        public int Fibonacci(int numero)
        {    // EL NUMERO DEBE SER MAYOR A 2 , DE LO CONTRARIO EL RESULTADO ES 1
            if (numero < 2 )    {      return numero;    }
            else { return Fibonacci(numero - 1) + Fibonacci(numero - 2); }     
        }

        public void imprimir (int numero)
        {
            int suceso = 1; // DESPEGAR LA SUCESION INICAIANDO DE 1 MAYOR IGUAL AL NUMERO 
            while (suceso <= numero) // PARA DESPEGAR EL NUMERO DE LA SUCESION QUE CORRESPONDA
            {
                Console.Write("\n\tsucesion :  {0}", Fibonacci(suceso));
                suceso++;
            }
        }

        public void resultado ()
        { // DETERMINA EL TIEMPO DE EJECUCION FINAL
            var Tiempo = Stopwatch.StartNew();  Tiempo.Stop();
            Console.Write("\n\tTIEMPO METODO: {0}\n", Tiempo.Elapsed);
        }
        

    }
}
