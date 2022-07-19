using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una oracion"); //solicitamos la o las oraciones
            string frase = Console.ReadLine(); //leemos las oraciones
            string caracter=""; //variable acumuladora de conteo
            int[] contador = new int[12];

            List<string> palabras = new List<string>(); //declaramos e instaciamos una lista de tipo String para guardar las palabras 
            for (int i = 0; i < frase.Length; i++) //procedemos a recorrer la frase caracter por caracter
            {
                caracter += frase[i]; //en cada iteracion se guarda el carater de la misma en la variable
                if (frase[i] == ' ' || frase[i] == '.'|| i == (frase.Length - 1))  // al encontrar un espacio en blanco o un punto
                {   
                    palabras.Add(caracter.RemoveWhiteSpaces()); //agragamos la palabra a la lista
                    caracter = ""; //reiniciamos la palabra
                }
               
            }
            
            foreach (var item in palabras)
            {
                Console.WriteLine(item.Length);
                
                 if (item.Length == 1)
                {
                    contador[1] +=1;
                }
                 if (item.Length == 2)
                {
                    contador[2] +=1;
                }
                
                if (item.Length == 3)
                {
                    contador[3] +=1;
                }
                 if (item.Length == 4)
                {
                    contador[4] +=1;
                }
                  if (item.Length == 5)
                {
                    contador[5] +=1;
                }
                  if (item.Length == 6)
                {
                    contador[6] +=1;
                }
                  if (item.Length == 7)
                {
                    contador[7] +=1;
                }
                  if (item.Length == 8)
                {
                    contador[8] +=1;
                }
                  if (item.Length == 9)
                {
                    contador[9] +=1;
                }
                  if (item.Length == 10)
                {
                    contador[10] +=1;
                }

            }
            Console.Clear();
     
           Console.WriteLine( "FRASE INTRODUCIDA: =="+frase.ToUpper()+"==");
           Console.WriteLine("==============================");
                 Console.WriteLine("CONTADOR DE PALABRA POR TAMAÑO");
            for (int i=1;i<11;i++)
            {   
                if (contador[i]>0)
                {
                    Console.WriteLine("HAY "+contador[i] +" PALABRAS CON "+ i+ " LETRAS");
                }
                
            }
            Console.WriteLine("==============================");
        }

      
    }


    public static class Extensions  //esta clase se creo para eliminar los espacios de
    {
        private static readonly Regex regex = new Regex(@"\s+");
    
        public static string RemoveWhiteSpaces(this string str)
         {
            return regex.Replace(str, String.Empty);
        }
    }
}