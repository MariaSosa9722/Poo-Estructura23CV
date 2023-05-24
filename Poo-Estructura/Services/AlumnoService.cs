using Poo_Estructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Poo_Estructura.Services
{
    public class AlumnoService
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno res = new Alumno()
                {
                    id = 1,
                    Nombre = "Majo",
                    Apellido = "Sosa",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,       
                    Promedio = 5
                };
                return res;

            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error " + ex.Message);
                
            }

        }


        public void Imprimr(Alumno request)
        {
            try
            {
                Console.WriteLine("El nombre es: "+request.Nombre);
                Console.WriteLine("El apellido es: " + request.Apellido);
                Console.WriteLine("El dia de ingreso  es: " + request.FechaIngreso);
                Console.WriteLine("El grado es: " + request.Grado);

            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error " + ex.Message);
            }

        }

        #region ------ Validar Aprobación 
        public bool ValidarProm(double num1)
        {
            bool validar = false;
       
            if (num1 > 7 )
            {
                validar = true;
            }
            return validar;


        }



        #endregion


    }
}
