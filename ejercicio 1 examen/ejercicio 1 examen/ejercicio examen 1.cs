using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_examen
{
/*Crea un struct llamado “Estudiante” con campos para Nombre, Edad, y Promedio. Luego, escribe un programa que cree una instancia de “Estudiante”, 
asigne valores a los campos, y muestre la información en la consola. El programa se repetirá las veces que el usuario lo desee. 

 */
    public struct estudiante
    {
        public double Promedio;
        public string Nombre;
        public int Edad;
         
        public estudiante(double promedio, string nombre, int edad)
        {
            Promedio = promedio;
            Nombre = nombre;
            Edad = edad;
        }
        public void mostrar()
        {
            Console.WriteLine($"promedio del estudiante: {Promedio}");
            Console.WriteLine($"nombre del estudiante {Nombre}");
            Console.WriteLine($"edad del estudiante: {Edad}");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            bool repetir = true;

            while (repetir)
            {
                estudiante est1 = new estudiante();
                
                Console.WriteLine("digite su promedio: ");
                est1.Promedio = double.Parse(Console.ReadLine());
                Console.WriteLine("digite su nombre: ");
                est1.Nombre = Console.ReadLine();
                Console.WriteLine("digite su edad: ");
                est1.Edad = int.Parse(Console.ReadLine());

                est1.mostrar();

                Console.WriteLine("desea ingresar mas datos? s/n");
                string respuesta = Console.ReadLine().ToLower();
                repetir = respuesta == "s";




            }
             Console.WriteLine("fin del programa");
            Console.ReadKey
                ();

        }
    }
}
