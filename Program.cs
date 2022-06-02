using System;

namespace Ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicitar y resolver 2 números utilizando las 4 operaciones + - / //
            Console.WriteLine(">>> Solicitar y resolver 2 números utilizando las 4 operaciones <<<");
          
            int n1, n2, resultado;

                Console.WriteLine("Ingresar un numero : ");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar otro numero : ");
                n2 = int.Parse(Console.ReadLine());

                //resultado = n1 * n2;
                //resultado = n1 / n2;
                //resultado = n1 - n2;
                  resultado = n1 + n2;

            Console.WriteLine("El resultado es : " + resultado);


           // Hacer un programa que permita saber el tiempo estimado de llegada entre cada ciudad//
            Console.WriteLine(">>> Hacer un programa que permita saber el tiempo estimado de llegada entre cada ciudad <<<");

            int km, tiempo, velocidad; 
            

                Console.WriteLine("Ingresa los kilometros entre cada ciudad : ");
                km = int.Parse(Console.ReadLine( )); 

                Console.WriteLine("Ingresar la velocidad a la que iras conduciendo: ");
                velocidad = int.Parse(Console.ReadLine());

                /// Utilizamos una division para saber el tiempo de llegada entre cada ciudad
                tiempo = km / velocidad;

            Console.WriteLine("El Tiempo de llegada es : " + tiempo +" hs");


            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado.
            // Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            Console.WriteLine(">>> Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo <<<");

            float sueldo = 15000f, facturacion, porcentaje = 0.05f, sueldoTotal;

                Console.WriteLine("Facturación del mes : ");
                facturacion = int.Parse(Console.ReadLine());

                sueldoTotal = (facturacion * porcentaje) + sueldo;

            Console.WriteLine("El total a pagar al empleado : " + sueldoTotal);


            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final//
            Console.WriteLine(">>>  Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final <<<");

            int filosofia, programacion, economia;
            float promedio;


                Console.WriteLine("Ingresar la nota de Filosofía : ");
                filosofia = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar la nota de Programacion : ");
                programacion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar la nota de Economia : ");
                economia = int.Parse(Console.ReadLine());

                promedio = (filosofia + programacion + economia) / 3f;

            Console.WriteLine("La nota promedio final es de : " + promedio);

            Console.WriteLine("Fin de las actividades");






        }
    }
}
