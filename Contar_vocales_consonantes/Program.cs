using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contar_vocales_consonantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las variables
            string palabra;
            int contador1 = 0, contador2 = 0, consonantes;
            Console.WriteLine("Introduzca una palabra");
            //Método que obtiene el dato ingresado
            palabra = Console.ReadLine();
            /*Ciclo for que obtiene la longitud de la cadena ingresado 
                 o que obtiene la cantidad de letras que tiene la cadena */
            for (int i = 0; i < palabra.Length; i++)
            {
                contador1++; 
            }
            for (int i = 0; i <palabra.Length; i++)
            {
                //condición que evalúa  la cadena ingresada en busca de las siguientes vocales
                if ((palabra[i] == 'a') || (palabra[i] == 'e') || (palabra[i] == 'i') || (palabra[i] == 'o') ||(palabra[i] == 'u'))
                {
                    contador2++;
                }
            }
            //Resta de las variables contador
            consonantes = contador1 - contador2;
            Console.WriteLine("La palabra " + palabra + " tiene " + contador2 + " vocales");
            Console.WriteLine("La palabra " + palabra + " tiene " + consonantes + " consonantes");
            Console.ReadLine();
        }
    }
}
