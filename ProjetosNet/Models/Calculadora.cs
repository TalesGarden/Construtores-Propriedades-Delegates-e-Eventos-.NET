using System;

namespace ProjetosNet.Models
{    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();
        
        // Evento
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int first, int second)
        {
            //caso exista inscitos
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Valor da soma: {first + second}");

                //o código depende de quem é inscrito
                EventoCalculadora();
            }
            else{
                Console.WriteLine("Nenhum Inscrito");
            }

        }
        public static void Subtrair(int first, int second)
        {
            Console.WriteLine($"Valor subtração {first - second}");            
        }
    }
}