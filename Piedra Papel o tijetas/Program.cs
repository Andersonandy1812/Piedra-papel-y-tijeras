using System;

namespace Piedra_Papel_o_tijetas
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("1vs1");
                Console.WriteLine("Dijite los 2 numeros que desea comparar(solamente del 1 al 3):\n1-piedra\n2-papel\n3-tijeras");
                int jugador1 = Convert.ToInt32(Console.ReadLine());
                int jugador2 = Convert.ToInt32(Console.ReadLine());

                if (jugador1 == 1 && jugador2 == 1)
                {
                    Console.WriteLine("Empate");
                }

                else if (jugador1 == 1 && jugador2 == 2)
                {
                    Console.WriteLine("El ganador es el jugador 2");
                }

                else if (jugador1 == 2 && jugador2 == 2)
                {
                    Console.WriteLine("Empate");
                }

                else if (jugador1 == 2 && jugador2 == 1)
                {
                    Console.WriteLine("El ganador es el jugador 1");
                }

                else if (jugador1 == 1 && jugador2 == 3)
                {
                    Console.WriteLine("El ganador es el jugador 1");
                }

                else if (jugador1 == 3 && jugador2 == 1)
                {
                    Console.WriteLine("El ganador es el jugador 2");
                }
                else if (jugador1 == 3 && jugador2 == 2)
                {
                    Console.WriteLine("El ganador es el jugador 1");
                }
                else if (jugador1 == 2 && jugador2 == 3)
                {
                    Console.WriteLine("El ganador es el jugador 2");
                }
                else if (jugador1 == 3 && jugador2 == 3)
                {
                    Console.WriteLine("Empate");
                }
                else
                {
                    Console.WriteLine("Error no a ingresado un numero correcto");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No escribiste un numero o digitaste mal");
            }
        }
    }
}
