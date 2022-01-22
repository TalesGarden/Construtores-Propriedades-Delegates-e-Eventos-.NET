using System;

namespace ProjetosNet.Models
{
    public class Pessoa
    {
        //readonly só pode ser modificado na inicialização ou no construtor. 
        protected readonly string nome = "José";
        private readonly string sobrenome;

        private const int maxIdade = 120;

        // public Pessoa()
        // {
        //     this.nome = string.Empty;
        //     this.sobrenome = string.Empty;            
        // }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Sou objeto da classe Pessoa");
        }
        
        public override string ToString()
        {
            return $"Olá meu nome é {this.nome} {this.sobrenome}, é um prazer Conhece-lo";
        }
        
    }
}