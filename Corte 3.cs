using System;

namespace AaronMorales
{
    class Program
    {
        public static void Main(string[] args)
        {
            //declaracion de variables 
            int TamañoPerro;
            int ActividadPerro, opcion, Edad;
            double peso, PesoIdeal;



            do
            {

                Console.WriteLine("Bienvenidos a programa de cuanto debe comer tu perro.\n\n");

                //Recolecion de datos

                //Peso
                Console.WriteLine("¿Cual es el peso de su perro?:");

                peso = Convert.ToDouble(Console.ReadLine());

                //Actividad
                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                ActividadPerro = Convert.ToInt32(Console.ReadLine());

                //Edad
                Console.WriteLine("¿Cuantos meses tiene su perro?");
                Edad = Convert.ToInt32(Console.ReadLine());


                if (Edad <= 12 && Edad > 0)
                {
                    //tamaño del perro
                    Console.WriteLine("Indique el tamaño de su perro.");
                    Console.WriteLine("1-Miniatura");
                    Console.WriteLine("2-Pequeño");
                    Console.WriteLine("3-Mediano");
                    Console.WriteLine("4-Grande");
                    TamañoPerro = Convert.ToInt32(Console.ReadLine());

                    //
                    switch (TamañoPerro)
                    {
                        //Tamaño miniatura
                        case 1:
                            {
                                Console.WriteLine("El peso ideal de su mascota es de 2kg");

                                //2 meses o menos
                                if (Edad <= 2)
                                {
                                    Console.WriteLine("Debe consumir 50g de comida diaria");
                                }
                                // 3 meses
                                else if (Edad == 3)
                                {

                                    Console.WriteLine("Debe consumir  60g de comida diaria");
                                }
                                //4 meses
                                else if (Edad == 4)
                                {

                                    Console.WriteLine("Debe consumir  60g de comida diaria");
                                }
                                //5 meses
                                else if (Edad == 5)
                                {
                                    Console.WriteLine("Debe consumir  60g de comida diaria");
                                }
                                //6 meses o mas 
                                else if (Edad >= 6)
                                {
                                    Console.WriteLine("Debe consumir  55g de comida diaria");
                                }
                            }
                            break;

                        case 2:
                            {

                                // tamaño pequeño
                                Console.WriteLine("Escriba el peso ideal de su mascota");
                                Console.WriteLine("1-5kg");
                                Console.WriteLine("2-10kg");
                                PesoIdeal = Convert.ToDouble(Console.ReadLine());
                                //5 kg
                                if (PesoIdeal == 1)
                                {
                                    //2 meses o menos
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 95g de comida diaria");
                                    }
                                    // 3 meses
                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  110g de comida diaria");
                                    }
                                    //4 meses 
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  115g de comida diaria");
                                    }
                                    //5 meses
                                    else if (Edad == 5)
                                    {
                                        Console.WriteLine("Debe consumir  115g de comida diaria");
                                    }
                                    //6 meses o mas
                                    else if (Edad >= 6)
                                    {
                                        Console.WriteLine("Debe consumir  110g de comida diaria");
                                    }

                                }
                                else if (PesoIdeal == 2)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 155g de comida diaria");
                                    }

                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  185g de comida diaria");
                                    }
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  195g de comida diaria");
                                    }
                                    else if (Edad == 5)
                                    {
                                        Console.WriteLine("Debe consumir  190g de comida diaria");
                                    }
                                    else if (Edad >= 6)
                                    {
                                        Console.WriteLine("Debe consumir  185g de comida diaria");
                                    }

                                }

                            }
                            break;
                        //tamaño mediano
                        case 3:
                            {
                                Console.WriteLine("El peso ideal de su mascota es de 17kg");

                                //2 meses o menos
                                if (Edad <= 2)
                                {
                                    Console.WriteLine("Debe consumir 215g de comida diaria");
                                }
                                // 3 meses
                                else if (Edad == 3)
                                {

                                    Console.WriteLine("Debe consumir  265g de comida diaria");
                                }
                                //4 meses
                                else if (Edad == 4)
                                {

                                    Console.WriteLine("Debe consumir  285g de comida diaria");
                                }
                                //5 meses
                                else if (Edad == 5)
                                {
                                    Console.WriteLine("Debe consumir  285g de comida diaria");
                                }
                                //6 meses o mas 
                                else if (Edad >= 6)
                                {
                                    Console.WriteLine("Debe consumir  280g de comida diaria");
                                }
                            }
                            break;

                        case 4:
                            {

                                //tamaño grande

                                Console.WriteLine("Escriba el peso ideal de su mascota");
                                Console.WriteLine("1-25kg");
                                Console.WriteLine("2-32kg");
                                Console.WriteLine("3-40kg");
                                Console.WriteLine("4-50kg");
                                Console.WriteLine("5-60kg");
                                Console.WriteLine("6-70kg");
                                Console.WriteLine("7-90kg");
                                PesoIdeal = Convert.ToDouble(Console.ReadLine());
                                //25 kg
                                if (PesoIdeal == 1)
                                {
                                    //2 meses o menos
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 270g de comida diaria");
                                    }
                                    // 3 meses
                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  350g de comida diaria");
                                    }
                                    //4 meses 
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  375g de comida diaria");
                                    }
                                    //5 meses
                                    else if (Edad == 5)
                                    {
                                        Console.WriteLine("Debe consumir  375g de comida diaria");
                                    }
                                    //6 meses o mas
                                    else if (Edad >= 6)
                                    {
                                        Console.WriteLine("Debe consumir  370g de comida diaria");
                                    }

                                }
                                //32kg
                                else if (PesoIdeal == 2)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 300g de comida diaria");
                                    }

                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  400g de comida diaria");
                                    }
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  445g de comida diaria");
                                    }
                                    else if (Edad == 5)
                                    {
                                        Console.WriteLine("Debe consumir  450g de comida diaria");
                                    }
                                    else if (Edad >= 6)
                                    {
                                        Console.WriteLine("Debe consumir  450g de comida diaria");
                                    }
                                }

                                //40kg
                                else if (PesoIdeal == 3)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 355g de comida diaria");
                                    }

                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  475g de comida diaria");
                                    }
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  525g de comida diaria");
                                    }
                                    else if (Edad == 5)
                                    {
                                        Console.WriteLine("Debe consumir  530g de comida diaria");
                                    }
                                    else if (Edad >= 6)
                                    {
                                        Console.WriteLine("Debe consumir  530g de comida diaria");
                                    }
                                }
                                //50kg
                                else if (PesoIdeal == 4)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 405g de comida diaria");
                                    }

                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  445g de comida diaria");
                                    }
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  610g de comida diaria");
                                    }
                                    else if (Edad == 5)
                                    {
                                        Console.WriteLine("Debe consumir  625g de comida diaria");
                                    }

                                }
                                //60kg
                                else if (PesoIdeal == 5)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 450g de comida diaria");
                                    }

                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  605g de comida diaria");
                                    }
                                    else if (Edad == 4)
                                    {

                                        Console.WriteLine("Debe consumir  685g de comida diaria");
                                    }

                                }
                                //70kg
                                else if (PesoIdeal == 6)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 485g de comida diaria");
                                    }

                                    else if (Edad == 3)
                                    {

                                        Console.WriteLine("Debe consumir  670g de comida diaria");
                                    }

                                }
                                //90kg
                                else if (PesoIdeal == 7)
                                {
                                    if (Edad <= 2)
                                    {
                                        Console.WriteLine("Debe consumir 580g de comida diaria");
                                    }

                                }

                            }
                            break;
                    }


                }
                else
                {


                    //Tamaño Miniatura
                    if (peso <= 5 && peso >= 2)
                    {

                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 45 y 85 gramos.");
                                break;
                        }

                    }
                    //Tamaño pequeño
                    if (peso > 5 && peso <= 10)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 100 y 170  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 85 y 145 gramos.");
                                break;
                        }
                    }
                    // Tamaño mediano 

                    if (peso > 10 && peso <= 15)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 190 y 255 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 170 y 225  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 145 y 195 gramos.");
                                break;
                        }
                    }
                    //tamaño grande 1
                    if (peso > 15 && peso <= 25)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 255 y 380 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 225 y 330  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 195 y 285 gramos.");
                                break;
                        }
                    }
                    //Tamaño grande 2
                    if (peso > 25 && peso <= 40)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 380 y 535 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 330 y 475  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 285 y 410 gramos.");
                                break;
                        }
                    }

                    //Tamaño grande 3
                    if (peso > 40 && peso <= 55)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 535 y 680 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 475 y 600  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 410 y 520 gramos.");
                                break;
                        }
                    }

                    //Tamaño grande 4
                    if (peso > 55 && peso <= 70)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 680 y 820 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 600 y 720  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 520 y 620 gramos.");
                                break;
                        }
                    }

                    //Tamaño grande 4
                    if (peso > 70)
                    {
                        switch (ActividadPerro)
                        {
                            case 1:
                                Console.WriteLine("Su perro debe comer entre 820 y 985 gramos de alimento.");
                                break;
                            case 2:
                                Console.WriteLine("Su perro debe comer entre 720 y 870  gramos.");
                                break;
                            case 3:
                                Console.WriteLine("Su perro debe comer entre 620 y 750 gramos.");
                                break;
                        }
                    }

                }


                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");

                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


            } while (opcion != 4);





        }
    }
}