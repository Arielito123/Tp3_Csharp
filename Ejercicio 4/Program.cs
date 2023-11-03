using System;

namespace Ejercicio4
{
    class MainClass
    {
        public static int i { get; private set; }

        public static void Main(string[] args)
        {
            //Se ingresan 5(cinco) N enteros, informar la suma de sus factoriales.


            int numero, suma = 0, fac = 1;

            for(int i = 1; i <= 5; i++) 
            
            {


                Console.WriteLine("Ingrese 5 numeros");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                Console.WriteLine("La suma de sus numero es de:" +suma);

            }


            for (i = 1; i<=suma; i++) 
            {

                fac = fac * i;
            
            }


            Console.WriteLine("el factorial de la suma de sus 5 numeros es de "+ fac);
            Console.ReadKey();


        }
    }
}
