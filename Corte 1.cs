using System;

namespace Ejercicio_corte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A , B , C;
            Console.WriteLine("Se hará realizará un ejercicio, por favor solo escoger números entre 0 y 9");
            Console.WriteLine("Por favor ingrese un número");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor vuelva a ingresar otro número");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el último número");
            C = int.Parse(Console.ReadLine());
            Console.Write("Su número es ");
            Console.Write(A);
            Console.Write(B);
            Console.WriteLine(C);
            Console.WriteLine("Ahora mediante su número escogido se le asignaran los siguientes:");
            Console.Write(A);
            Console.Write(A);
            Console.Write(C);
            Console.WriteLine(B);
            Console.Write(B);
            Console.Write(C);
            Console.WriteLine(A);
            Console.Write(B);
            Console.Write(C);
            Console.Write(B);
            Console.WriteLine(C);
            Console.WriteLine("Gracias por su tiempo");
            Console.ReadKey();
        }
    }
}
