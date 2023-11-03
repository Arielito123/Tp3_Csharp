using System;

namespace Ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*En una Fábrica trabajan tres categorías de operarios: Operario Calificado (A), Operario
Maquinista (B) y Operario Común (C). Por cada hora trabajada, y en base a la categoría los
operarios cobran:
●Operario Calificado $ 1000,00 x hora.
●Operario Maquinista $ 850,00 x hora.
●Operario Común $ 700,00 x hora.
En la fábrica se trabaja únicamente de lunes a viernes de 8:00hs a 20:00hs. Escribir un programa
que permita calcular, en base al ingreso de la cantidad de horas trabajadas (validar cantidad) y
la categoría, el sueldo semanal del operario.*/


            int a = 1000, b = 850, c = 700, horasTrabajadas,sueldoDiarios=0,sueldoSemanal=0,suma=0,menu;

            Console.WriteLine(" Seleccione su funcion dentro de la empresa ");
            Console.WriteLine(" 1. Operario Calificado ");
            Console.WriteLine(" 2. Operario Maquinista ");
            Console.WriteLine(" 3. Operario Comun ");
            Console.WriteLine("********************************************************************************");
            menu = int.Parse(Console.ReadLine());
           

            switch (menu) 
            
            {

                case 1: for(int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine(" Ingrese las horas trabajadas en ese dia "   +i);
                        horasTrabajadas = int.Parse(Console.ReadLine());
                      

                       
                        while (horasTrabajadas >= 13) 
                        {

                            Console.WriteLine(" Las horas ingresadas no son validas vuelva a ingresarlas");
                            horasTrabajadas = int.Parse(Console.ReadLine());
                        }


                        if ((horasTrabajadas>=1)&&(horasTrabajadas<= 12))
                        {

                           

                                sueldoDiarios = horasTrabajadas * a;
                                Console.WriteLine(" Ese dia le corresponden " + sueldoDiarios + " Pesos " + " como Operario Calificado");
                            Console.WriteLine("*****************************************************************************");


                            suma = suma+horasTrabajadas;
                            
                                
                                
                                }




                      
                    }

                    Console.Clear();

                     sueldoSemanal = suma*a;
                    Console.WriteLine("el salario semanal que le corresponde es de:" + sueldoSemanal + " pesos " + "\nComo Operario Calificado");


                    break;



                case 2:
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine(" Ingrese las horas trabajadas en ese dia " + i);
                        horasTrabajadas = int.Parse(Console.ReadLine());
                        sueldoDiarios = horasTrabajadas * b;
                       
                        while (horasTrabajadas >= 13)
                        {

                            Console.WriteLine(" Las horas ingresadas no son validas vuelva a ingresarlas");
                            horasTrabajadas = int.Parse(Console.ReadLine());
                        }


                        if ((horasTrabajadas >= 1) && (horasTrabajadas <= 12))
                        {
                            sueldoDiarios = horasTrabajadas * b;
                            Console.WriteLine(" Ese dia le corresponden " + sueldoDiarios + " Pesos " + " como Operario Maquinista");
                            Console.WriteLine("*****************************************************************************");

                            suma = suma + horasTrabajadas;



                        }




                    }

                    Console.Clear();
                    sueldoSemanal = suma * b;
                    Console.WriteLine("el salario semanal que le corresponde es de:" + sueldoSemanal + " pesos " + "\nComo Operario Maquinista");


                    break;

                case 3:
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine(" Ingrese las horas trabajadas en ese dia " + i);
                        horasTrabajadas = int.Parse(Console.ReadLine());

                        while (horasTrabajadas >= 13)
                        {

                            Console.WriteLine(" Las horas ingresadas no son validas vuelva a ingresarlas");
                            horasTrabajadas = int.Parse(Console.ReadLine());
                           
                        }


                        if ((horasTrabajadas >= 1) && (horasTrabajadas <= 12))
                        {

                            sueldoDiarios = horasTrabajadas * c;
                            Console.WriteLine(" Ese dia le corresponden5 " + sueldoDiarios + " Pesos " + "\ncomo Operario Comun");
                            Console.WriteLine("*****************************************************************************");

                            suma = suma + horasTrabajadas;



                        }




                    }

                    Console.Clear();
                    sueldoSemanal = suma * c;
                    Console.WriteLine("el salario semanal que le corresponde es de:" + sueldoSemanal + " pesos "+ " Como Operario Comun ");


                    break;


            }










        }
    }
}
