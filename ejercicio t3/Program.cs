using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cita[] citas = new Cita[100];
            int contador = 0;
            int opcion;

            do
            {
                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Crear Cita");
                Console.WriteLine("2. Listar Citas");
                Console.WriteLine("3. Modificar Universidad de Estudiantes");
                Console.WriteLine("4. Fin");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CitaUtil.CrearCita(citas, ref contador);
                        break;
                    case 2:
                        CitaUtil.ListarCitas(citas, contador);
                        break;
                    case 3:
                        CitaUtil.ModificarUniversidad(citas, contador);
                        break;
                    case 4:
                        Console.WriteLine("Programa finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
