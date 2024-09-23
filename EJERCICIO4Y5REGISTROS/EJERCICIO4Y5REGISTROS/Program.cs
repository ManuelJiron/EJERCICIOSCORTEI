using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EJERCICIO4Y5REGISTROS
{
    internal class Program
    {
        const int MAX = 11;

        public struct Direccion
        {
            public string Calle;
            public string Ciudad;
            public string CodigoPostal;
        }

        public struct Empleado
        {
            public string Nombre;
            public Direccion direccion;

            public Empleado(string nombre, Direccion direction) //Constructor
            {
                Nombre = nombre;
                direccion = direction;
            }

            public void MostrarInfo() //Metodo mostrar info
            {
                 
                    Console.WriteLine($"Nombre: {Nombre}");
                    Console.WriteLine($"Calle: {direccion.Calle}");
                    Console.WriteLine($"Ciudad:  {direccion.Ciudad}");
                    Console.WriteLine($"Codigo postal: {direccion.CodigoPostal}");
                    Console.WriteLine();
            }

            public void Buscar(Empleado[] empleados)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese una ciudad a buscar: ");
                string valor = Console.ReadLine();
                bool encontrado = false;

                Console.WriteLine();

                for (int i = 1; i < MAX; i++) //Se hace uso de la busqueda secuencial
                {
                    if (empleados[i].direccion.Ciudad == valor)//Recorre el arreglo en busca de la ciudad
                    {
                        Console.WriteLine("Datos de empleados que viven en esta ciudad: "); //Si lo encuentra muestra la info de los empleados relacionados
                        empleados[i].MostrarInfo();
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Ningun empleado vive en esta ciudad");
                }
            }
        }
           
            

        static void Main(string[] args)
        {
            /*4. Define un struct llamado “Empleado” que contenga un campo Nombre y otro Direccion, donde Direccion es otro struct con campos para Calle,
             * Ciudad, y CódigoPostal. Crea una instancia de ”Empleado”, asigna valores a todas las propiedades, y muestra la información completa del empleado
             * en la consola. Permitir almacenar 10 empleados.

            5. Usa el struct “Empleado” del ejercicio anterior. Escribe un programa que busque los empleados que viven en una ciudad específica y muestre la
            información de estos empleados. Aplica búsqueda secuencial.*/

            

            Empleado[] empleados = new Empleado[MAX]; //Inicializo arreglo

            for (int i = 1; i < MAX; i++)  //Se ingresan las propiedades del arreglo
            {
                Console.WriteLine("Ingrese el nombre del empleado " + i);
                empleados[i].Nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Apartado Direccion");
                Console.WriteLine("Introduzca la calle del empleado " + i);
                empleados[i].direccion.Calle = Console.ReadLine();
                Console.WriteLine("Introduzca la ciudad del empleado " + i);
                empleados[i].direccion.Ciudad = Console.ReadLine();
                Console.WriteLine("Introduzca el Codigo Postal del empleado " + i);
                empleados[i].direccion.CodigoPostal = Console.ReadLine();
               
                Console.Clear();
            }

           

            Console.WriteLine("Info empleados: "); 
            Console.WriteLine();
            for (int i = 1; i < MAX; i++) // 
            {
                Console.WriteLine($"Empleado {i}");
                empleados[i].MostrarInfo(); //Manda a llamar al metodo mostrarInfo
                
            }

            for (int i = 1; i < MAX; i++)
            {
                empleados[i].Buscar(empleados);
                break;
            }
            Console.ReadKey();
        }
    }
}
