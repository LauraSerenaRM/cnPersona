using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPersona
{
    /// <summary>
    /// Nombre: Laura Serena Rivera Mejía
    /// Fecha: 24-02-2023
    /// Descripción: Este programa solicita datos adicionales si el dato ingresado corresponde a mayoria de edad.
    /// </summary>


    internal class ClsPersona
    {
        //Declaración variables
        int Edad;
        string Apellido;
        string CorreoElectronico;
        static void Main(string[] args)
        {
            //Se crea un objeto de la Clase Persona.
            ClsPersona oPersona = new ClsPersona();
            //Se llaman los métodos a partir del objeto persona
            oPersona.SolicitarDatos();
            oPersona.EvaluacionDatos();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();


        }

        //Método 1
        public void SolicitarDatos()
        {
            //Mensaje de salida y captura de datos de entrada
            Console.WriteLine("Por favor ingrese la edad para continuar con la solicitud de sus datos personales");
            Edad = int.Parse(Console.ReadLine());
        }
        //Método 2
        public void EvaluacionDatos()
        {
            //Ciclo lógico
            if (Edad < 18)
            {
                Console.WriteLine("Al ser menor de edad no se autoriza continuar con el ingreso de sus datos personales. Presione cualquier tecla para salir");
            }

            else if (Edad >= 18)
            {
                Console.WriteLine("Por favor ingrese su apellido");
                Apellido = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su correo electronico");
                CorreoElectronico = Console.ReadLine();
                Console.WriteLine("Muchas gracias, registo de datos finalizado. Presione cualquier tecla para salir");

            }


        }


    }
}
