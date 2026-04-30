using System.Runtime.CompilerServices;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e1, e2, e3, e4, e;
            double p1, p2, p3, p4, por1, por2, por3, por4, mi;

            Console.WriteLine("Ingrese monto a repartir");
            mi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese edad de la 1er niña");
            e1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese edad de la 2da niña");
            e2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese edad de la 3er niña");
            e3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese edad de la 4ta niña");
            e4 = Convert.ToInt32(Console.ReadLine());

            e = e1 + e2 + e3 + e4;

            por1 = e1 * 100.0 / e;
            por2 = e2 * 100.0 / e;
            por3 = e3 * 100.0 / e;
            por4 = e4 * 100.0 / e;

            p1 = mi * por1 / 100.0;
            p2 = mi * por2 / 100.0;
            p3 = mi * por3 / 100.0;
            p4 = mi * por4 / 100.0;

            Console.WriteLine($"Niña 1: Edad: {e1} - Porcentaje asignado: {por1}% - Monto asignado: ${p1}");
            Console.WriteLine($"Niña 2: Edad: {e2} - Porcentaje asignado: {por2}% - Monto asignado: ${p2}");
            Console.WriteLine($"Niña 3: Edad: {e3} - Porcentaje asignado: {por3}% - Monto asignado: ${p3}");
            Console.WriteLine($"Niña 4: Edad: {e4} - Porcentaje asignado: {por4}% - Monto asignado: ${p4}");

            Console.ReadKey();
        }
    }
}
