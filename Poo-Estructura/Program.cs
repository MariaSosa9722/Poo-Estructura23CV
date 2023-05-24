using Poo_Estructura.Entities;
using Poo_Estructura.Services;
using System;

namespace Poo_Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {


            AlumnoService servicio = new AlumnoService();

            Alumno alumno1 = servicio.Agregar();
            servicio.Imprimr(alumno1);

            Console.WriteLine("La calificación es "+ servicio.ValidarProm(alumno1.Promedio));

            Console.WriteLine("Hello World!");


        }
    }
}
