using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_examen
{
    public struct CuentaBancaria
    {
        public int NumeroDeCuenta;
        public string NombreTitular;
        public double Saldo;

        // Constructor para inicializar todos los campos
        public CuentaBancaria(int numeroDeCuenta, string nombreTitular, double saldo)
        {
            NumeroDeCuenta = numeroDeCuenta;
            NombreTitular = nombreTitular;
            Saldo = saldo;
        }

        // mostrar la información de la cuenta
        public void MostrarInformacion()
        {
            Console.WriteLine($"Número de cuenta: {NumeroDeCuenta}");
            Console.WriteLine($"Nombre del titular: {NombreTitular}");
            Console.WriteLine($"Saldo: {Saldo:C}");     
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir el tamaño del arreglo
            Console.WriteLine("¿Cuántas cuentas bancarias desea registrar?");
            int cantidad = int.Parse(Console.ReadLine());

            // Crear un arreglo de "CuentaBancaria"
            CuentaBancaria[] cuentas = new CuentaBancaria[cantidad];

            // Inicializar el arreglo utilizando el constructor
            for (int i = 0; i < cuentas.Length; i++)
            {
                Console.WriteLine($"Ingrese los datos de la cuenta {i + 1}:");

                Console.Write("Número de cuenta: ");
                int numeroDeCuenta = int.Parse(Console.ReadLine());

                Console.Write("Nombre del titular: ");
                string nombreTitular = Console.ReadLine();

                Console.Write("Saldo: ");
                double saldo = double.Parse(Console.ReadLine());

                cuentas[i] = new CuentaBancaria(numeroDeCuenta, nombreTitular, saldo);

                Console.WriteLine(); // Espacio en blanco para separar cada entrada
            }

            // Mostrar la información de todas las cuentas
            Console.WriteLine("Información de todas las cuentas bancarias:");
            foreach (var cuenta in cuentas)
            {
                cuenta.MostrarInformacion();
            }

            Console.ReadKey();
        }
    }
}