using System;

namespace Programacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Hola, bienvenido. Por favor ingrese su edad.");

            A = int.Parse(Console.ReadLine());

            if (A >= 60)

                Console.WriteLine("Disculpe, usted no tiene permitida la entrada, por favor espere en el área designada");

            else
            {
                Console.WriteLine("Por favor ingrese su estatura en centímetros");

                B = int.Parse(Console.ReadLine());

                if (B <= 159)

                {

                    Console.WriteLine("Tienes permitido ingresar a todas las atracciones que en la entrada tengan el color azul");

                }

                else

                {

                    Console.WriteLine("Puedes disfrutar de todas las atracciones de nuestro complejo.");

                }

            }

            Console.ReadKey();
        }
    }
}
