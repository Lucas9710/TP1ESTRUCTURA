/*
* Materia: Estructura de datos
* Docente: Ing. Pablo Avellaneda
*TP nro 1
*Fecha 21/05/2021
*Equipo : 'Equipo 1'
*Integrantes ( nombre y apellido ):
*Lucas Nuñez
*Carina Vega
*Laura Lopez

....
*/
using System;



namespace tp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ejercicio1();
            //Ejercicio2();
             //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
        }

        static void Ejercicio1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            int suma = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                suma = suma + numbers[i];

            }
            Console.WriteLine("la suma es: " + suma);
        }

        static void Ejercicio2()
        {
            int[] arreglo = new int[10];
            int[] otroArreglo = new int[10];

            // un for para que el usuario ingrese los 10 numeros, hasta que no los ingrese el bucle no sale
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            // recorre el arreglo desde arriba hacia abajo, es arregle.length - 1 porque recorre desde la posicion 9
            for (int v = arreglo.Length - 1; v >= 0; v--)
            {
                otroArreglo[v] = arreglo[v];
                Console.Write("{0}, ", otroArreglo[v]);
            }
        }

        static void Ejercicio3()
        {
            int contador = 0;


            string[] arreglo1 = new string[3] { "1", "3", "4" };
            string[] arreglo2 = new string[3] { "1", "3", "4" };


            // creo un for que recorra el primer arreglo
            for (int i = 0; i < arreglo1.Length; i++)
            {
                //verifico que los arreglos tengan el mismo tamaño, si no, le aviso al usuario que no tienen el mismo
                //tamaño y corto el for
                if (arreglo1.Length == arreglo2.Length)
                {
                    //comparo los elementos del arrglo en caso de que sean iguales voy sumando un contador
                    if (arreglo1[i] == arreglo2[i])
                    {
                        contador++;
                    }
                }
                else
                {
                    Console.WriteLine("el arreglo no tiene el mismo tamaño");
                    break;

                }

            }

            // si el contado es igual al largo del arreglo significa que paso todas las validaciones del for.
            if (contador == arreglo1.Length)
            {
                Console.WriteLine("el arreglo es igual");
            }
            else
            {
                Console.WriteLine("el arreglo no es igual");
            }

        }


        static void Ejercicio4()
        {
            // ingresa el tamaño de los arreglo
            int espacios = 0;
            Console.WriteLine("ingrese cuantos espacios tendran los arreglos");
            espacios = int.Parse(Console.ReadLine());

            int[] arreglo = new int[espacios];
            int[] arreglo2 = new int[espacios];
            int[] arregloMulti = new int[espacios];

            for (int i = 0; i < espacios; i++)
            {
                Console.WriteLine("ingrese los numeros del primer arreglo");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < espacios; i++)
            {
                Console.WriteLine("ingrese los numeros del segundo arreglo");
                arreglo2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < espacios; i++)
            {
                arregloMulti[i] = arreglo[i] * arreglo2[i];
            }


            foreach (int i in arregloMulti)
            {
                Console.WriteLine("la multiplicacion de los arregloes es {0}", i);
            }
        }

        static void Ejercicio5()
        {
            string[] producto = new string[5];
            double[] precio = new double[5];
            double[] cantidad = new double[5];
            double[] precioFinal = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un producto");
                producto[i] = Console.ReadLine();

                Console.WriteLine("ingrese el precio");
                precio[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la cantidad");
                cantidad[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                precioFinal[i] = precio[i] * cantidad[i];
                Console.WriteLine("el precio final del producto  " + producto[i] + " es  " + precioFinal[i]);
            }
        }


        static void Ejercicio6()
        {
            int espacio = 0;
            Console.WriteLine("ingrese el tamaño del vector");
            espacio = int.Parse(Console.ReadLine());

            int[] arreglo = new int[espacio];

            for (int i = 0; i < espacio; i++)
            {
                Console.WriteLine("ingrese un numero");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                int temp = arreglo[i];
                for (int j = 0; j < temp; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }


        static void Ejercicio7()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 10);  //limitamos random por una cuestion de carga
            Console.WriteLine("el vector tiene " + numeroAleatorio + " espacios");

            int[] arreglo = new int[numeroAleatorio];

            for (int i = 0; i < numeroAleatorio; i++)
            {
                Console.WriteLine("ingrese un numero");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                int temp = arreglo[i];
                for (int j = 0; j < temp; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
}