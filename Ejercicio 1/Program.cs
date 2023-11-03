using System;

namespace Ejercicio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Se ingresan las marcas de temperatura de una semana completa comenzando por el día lunes,
al finalizar los ingresos se pide informa la temperatura más baja y que día de la semana se
produjo (lunes, martes, miércoles…).*/


            float temp, pos = 0, tempbaja = 100;


            for (int i = 1; i<=7;i++) 
            {

                Console.WriteLine(" Ingrese la temperatura del dia "  +i);
                temp = float.Parse(Console.ReadLine());


                if (temp < tempbaja) 
                {

                    tempbaja = temp;
                    pos = i;
                
                }
                Console.Clear();

            }

            if (pos == 1) 
            {
                Console.Write(" Se produjo el dia Lunes ");
            }

            if (pos == 2) 
            {
                Console.Write(" se produjo el dia Martes ");
            }

            if (pos == 3) 
            {
                Console.Write(" se produjo el dia Miercoles "); 
            }


            if (pos == 4) 
            {
                Console.Write(" se produjo el dia Jueves ");
              }

            if (pos == 5) 
            {
                Console.Write(" se produjo el dia Viernes ");
            }

            if (pos == 6) 
            {
                Console.Write(" se produjo el dia Sabado ");
              }

            if (pos == 7) 
            {
                Console.Write(" se produjo el dia Domingo "); 
            }

            Console.Write(" Y la temperatura mas baja fue de:"+tempbaja+ "C°");
            Console.ReadKey();
        }
    }
}
