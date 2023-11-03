/*Conociendo la implementación de los siguientes métodos:
 Console.SetCursorPosition(int32 x, int32 y); Este método posiciona el cursor en
 los valores indicados en x e y.
 Thread.Sleep(tiempo en milisegundo); Este método permite realizar una pausa en la
 ejecución del programa según el tiempo indicado entre paréntesis en milisegundos. Para
 utilizar el método deberán importar el espacio de nombre System.Threading mediante la
 línea using System.Threading;
 Console.Clear(); Limpia la pantalla, borra su contenido.
 Realizar un programa que permita visualizar la palabra “Nave” desplazándose por la mitad de la
 pantalla. Y que al pulsar la tecla “B” (bomba) la Nave suelte un proyectil “I” (letra I), el cual deberá
 caer hacia la parte inferior de la pantalla. */
using System;
using System.Threading;
namespace Ejercicio6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int x = 1,y;

            Console.CursorVisible = false;
            while (x <= 80)
            {
                Console.SetCursorPosition(x, 5);
                Console.WriteLine("NAVE");
                Thread.Sleep(150);
                Console.SetCursorPosition(x, 5);
                Console.WriteLine("    ");
                x++;



                if (Console.KeyAvailable)//me detecta si toque algo en el teclado
                {
                    ConsoleKeyInfo Tecla = Console.ReadKey(true);//la tecla que pulse la va aguardar en tecla

                        if (Tecla.Key == ConsoleKey.B)
                    { y = 6;
                        while (y <= 23)

                        {
                            Console.SetCursorPosition(x, 5);
                            Console.WriteLine("NAVE");
                            Thread.Sleep(150);
                            Console.SetCursorPosition(x, 5);
                            Console.WriteLine("    ");
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("I");
                            Thread.Sleep(50);
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine(" ");
                            y++;
                            x++;
                        }
                    }
                }
                x++;
            }


        }
    };
}
