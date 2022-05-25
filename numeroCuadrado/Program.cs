using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroCuadrado
{
    class Program
    {
        //Programa con excepciones
        //que repite el mensaje hasta que se ingrese
        //Un valor valido
        static void Main(string[] args)
        {
            //Variable booleana para salir de ciclo
            bool x = false;
            //Ciclo para repetir el mensaje
            do
            {
                //Limpieza de pantalla
                Console.Clear();
                try
                {
                    //Captura de datos
                    Console.Write("Enter a number: ");
                    int num1 = int.Parse(Console.ReadLine());

                    //Elevar el numero capturado al cuadrado
                    int cuadrado = num1 * num1;

                    //Impresion de resultado
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThe typed value " + num1 + " squared is: " + cuadrado);
                    Console.ResetColor();

                    //Variable en true para salir de ciclo
                    x = true;
                }
                //Error de formato
                catch (FormatException e)
                {
                    //Impresion de mensaje
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Format error " + e.Message);
                    Console.ResetColor();
                }
                //Mensaje para continuar
                Console.Write("Presione ENTER para continuar . . . ");
                Console.ReadKey();
            } while (x == false);//Condicion de ciclo para repetirse siempre que este en false
        }
    }
}
