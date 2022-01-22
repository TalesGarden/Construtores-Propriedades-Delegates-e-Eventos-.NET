using System;

namespace ProjetosNet.Models
{
    public class Aluno : Pessoa
    {
        public string Disciplina { get; set; }
        public int idade { get; set; }
        public Aluno(string nome, string sobrenome) : base(nome, sobrenome)
        {
            Console.WriteLine("Sou objeto da classe Aluno");
        }

        public Aluno(string nome, string sobrenome, int idade) : base(nome, sobrenome)
        {
            this.idade = idade;
            Console.WriteLine($"Sou objeto da classe Aluno {this.nome}");
        }

        public override string ToString()
        {
          return  $" {base.ToString()} + . Sou Aluno";
        }
    }
}