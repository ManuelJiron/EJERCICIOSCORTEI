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

                Console.WriteLine(); 
            }

            
            MostrarCuentas(cuentas);

            Console.ReadKey();
        }

        //  mostrar la información de todas las cuentas
        static void MostrarCuentas(CuentaBancaria[] cuentas)
        {
            Console.WriteLine("Información de todas las cuentas bancarias:");

            for (int i = 0; i < cuentas.Length; i++)
            {
                Console.WriteLine($"Cuenta {i + 1}:");
                Console.WriteLine($"Número de cuenta: {cuentas[i].NumeroDeCuenta}");
                Console.WriteLine($"Nombre del titular: {cuentas[i].NombreTitular}");
                Console.WriteLine($"Saldo: {cuentas[i].Saldo:C}");  
                Console.WriteLine();  
            }
        }
    }
}