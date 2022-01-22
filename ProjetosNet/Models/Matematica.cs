using System;
using ProjetosNet.Models;

namespace ProjetosNet.Models
{
    public class Matematica
    {

        public int x { get; set; }
        public int y { get; set; }

        public Matematica(int first, int second)
        {
            this.x = first;
            this.y = second;
            Calculadora.EventoCalculadora += EventHandler;
        }


        public void somar()
        {
            Calculadora.Somar(this.x,this.y);
        }

        public  void EventHandler()
        {
            Console.WriteLine("Método incrito matematica EXECUTADO");
        }
    }
}