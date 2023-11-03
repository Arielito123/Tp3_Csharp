using System;

namespace Ejercicio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Para realizar un control sobre las costumbres alimenticias y el peso de las personas de una
población, se solicita desarrollar un programa que permita realizar el ingreso de N personas, al
finalizar la carga de la primera persona el sistema deberá pregustar si se desea cargar otra [S=si
/ N=no] si el usuario pulsa S se cargará otra persona de lo contrario el sistema deberá informar
el peso promedio, por sexo, de dicha población*/




            int contF = 0, contM = 0;
            string nombre;
            char sexo,letra;
            float peso, promF = 0,promM=0,sumaF=0,sumaM=0;

            Console.WriteLine("Ingrese Un nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el peso");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el sexo F=Femenino O M=Masculino");
            sexo = char.Parse(Console.ReadLine());
       
            if (sexo == 'f')
            {
               
                contF++;
                sumaF = sumaF + peso;
            }

            if (sexo == 'm')
            {
               
                contM++;
                sumaM = sumaM + peso;
            }



            Console.Clear();
            Console.WriteLine("s para cargar otro Dato y n para no cargar otro Dato");
            letra = char.Parse(Console.ReadLine());

            while (letra == 's')
            {
                Console.WriteLine("Ingrese Un nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el peso");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el sexo F=Femenino O M=Masculino");
                sexo = char.Parse(Console.ReadLine());

                if (sexo == 'f')
                {

                    contF++;
                    sumaF = sumaF + peso;
                }

                if (sexo == 'm')
                {
                   
                    contM++;
                    sumaM = sumaM + peso;
                }


                Console.Clear();

                Console.WriteLine("s para cargar otro Dato Y n para no cargar otro Dato");
                letra = char.Parse(Console.ReadLine());
            }

            if (letra == 'n')
            {
                Console.WriteLine(" Hay "+ contF +" Mujeres ");
                Console.WriteLine(" Hay "+ contM +" Hombres ");

               
                 promF = sumaF / contF;

                Console.WriteLine("El peso promedio de las mujeres es de "+ promF);

                promM = sumaM / contM;

                Console.WriteLine("El peso promedio de los hombres es de "+ promM);
            }


            Console.ReadKey();
        }
    }
}
