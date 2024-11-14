using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_t3
{
    internal class CitaUtil
    {
        public static void CrearCita(Cita[] citas, ref int contador)
        {
            Console.Write("Ingrese número de cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese código del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese universidad del estudiante: ");
            string universidad = Console.ReadLine();
            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);

            Console.Write("Ingrese enfermedad: ");
            string enfermedad = Console.ReadLine();
            Console.Write("Ingrese precio de la cita: ");
            double precio = double.Parse(Console.ReadLine());

            citas[contador] = new Cita(numero, estudiante, enfermedad, precio);
            contador++;
            Console.WriteLine("Cita creada exitosamente.\n");
        }

        public static void ListarCitas(Cita[] citas, int contador)
        {
            double total = 0;
            Console.WriteLine("Lista de citas:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(citas[i].ToString());
                total += citas[i].Precio;
            }
            Console.WriteLine($"\nSuma total de precios: {total:C}\n");
        }

        public static void ModificarUniversidad(Cita[] citas, int contador)
        {
            Console.Write("Ingrese texto a buscar en las universidades: ");
            string buscar = Console.ReadLine();
            Console.Write("Ingrese texto por el cual reemplazar: ");
            string reemplazar = Console.ReadLine();

            for (int i = 0; i < contador; i++)
            {
                if (citas[i].Estudiante.Universidad.Contains(buscar))
                {
                    citas[i].Estudiante.Universidad = citas[i].Estudiante.Universidad.Replace(buscar, reemplazar);
                }
            }
            Console.WriteLine("Modificación realizada.\n");
        }
    }
}
