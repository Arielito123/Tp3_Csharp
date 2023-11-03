using System;

namespace Ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*3. Modificar el programa del punto anterior, sabiendo que en la fábrica trabajan 10
Informar en una lista:
empleados.
a. Sueldo mensual de cada empleado (Se ingresa cantidad de horas mensuales, validar
el ingreso).
b. El empleado que más gana y la categoría del mismo.
c. Cantidad de empleados por cada categoría.
d. Porcentaje de Operarios Calificados que trabajan en la fábrica.*/

        

            int a = 1000, m= 850, c= 750, contCa = 0, contMa = 0, contCo = 0,horasMensuales,sueldoMensual=0,sueldoMensual1=0,sueldoMensual2=0,aux=0,pos=0,masGana=-240000;
            float porcentaje = 0;
            char categoria;
            



            for (int i = 1; i <= 10; i++)//ciclo de repeticion para repetir 10 veces
            {


                Console.WriteLine(" Ingrese las horas mensuales del trabajador " + i);//leyenda con las horas mensuales que debe ingresar el usuario
                horasMensuales = int.Parse(Console.ReadLine());//Guardo la variable de tipo entero


                while (horasMensuales <= 0)//uso ciclo de repeticio para validar que el usuario no ponga 0 horas ni menor al 0
                {
                    Console.WriteLine(" no se puede trabajar menos de 0 horas volver a ingresar ");//leyenda para que vuelva ingresar las horas
                    horasMensuales = int.Parse(Console.ReadLine());//Volvemos a guardar la variable
                }

           
                while (horasMensuales>241)//uso ciclo de repeticio para validar que el usuario no pongas mas de 240 horas
                {
                    Console.WriteLine(" no se puede trabajar mas de 240 horas volver a ingresar ");//leyenda para que vuelva ingresar las horas
                    horasMensuales = int.Parse(Console.ReadLine());//Volvemos a guardar la variable

                }

              


                if ((horasMensuales >= 1) && (horasMensuales <= 240))//if condicional para validar de 1 a 240 horas se guardara la variable 
                {

                    Console.WriteLine(" Elija la categoria que quiera operar A=Calificado,B=Maqunista y C=Comun ");
                    categoria = char.Parse(Console.ReadLine());
                    


                    if (categoria == 'a')
                    {

                        contCa++;
                        sueldoMensual = horasMensuales * a;

                        Console.WriteLine(" El sueldo Mensual del trabajador "+sueldoMensual);
                        

                   

                        if (sueldoMensual > masGana)
                        {
                            masGana = sueldoMensual;
                            pos = i;

                        }


                      

                    }

                 

                    if (categoria == 'b')
                    {
                       contMa++;
                        sueldoMensual1 = horasMensuales * m;
                        Console.WriteLine(" El sueldo Mensual del trabajador "+sueldoMensual1);
                       
                        if (sueldoMensual1 > masGana)
                        {
                            masGana = sueldoMensual1;
                            pos = i;

                        }

                        
                      


                    


                }


                if (categoria == 'c')
                    {
                        contCo++;
                        sueldoMensual2 = horasMensuales * c;
                        Console.WriteLine(" El sueldo Mensual del trabajador " +sueldoMensual2);

                        if (sueldoMensual2 > masGana)
                        {
                            masGana = sueldoMensual2;
                            

                            pos = i;
                        }

                       
                    }


                   

                }
               




            }

           

            Console.WriteLine(" Hay " + contCa+ "Empleados Calificados");
            Console.WriteLine(" Hay " + contMa + "Empleados Maquinista");
            Console.WriteLine(" Hay " + contCo + "Empleados Comun" );
            porcentaje = (contCa * 100) / 10;
            Console.WriteLine(" El porcentaje de operarios calificados es de: "+porcentaje+"%");
            Console.WriteLine("El salario mas alto es:" + masGana+" La posicion del trabajador es: " + pos);

            if (masGana == sueldoMensual)
            {
                Console.WriteLine("El salario mas grande lo tiene el Operario calificado");




            }

            if (masGana == sueldoMensual1)
            {
                Console.WriteLine("El salario mas grande lo tiene el Operario maquinista");

           

            }

            if (masGana == sueldoMensual2)
            {
                Console.WriteLine(" El salario mas grande lo tiene el Operario comun");



            }
            Console.WriteLine("la categoria es"+aux);

            Console.ReadKey();
        }
    }
}
