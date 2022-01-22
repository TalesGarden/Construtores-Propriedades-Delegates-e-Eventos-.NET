using System;
using ProjetosNet.Models;

namespace ProjetosNet
{

  public class Program
  {

    public delegate void Operacao(int x,int y);
    public static void Main(string[] args)
    {
      Matematica math = new Matematica(10,10);
      math.somar();

      math.ToString();

      //DELEGATE
      //Operacao executaFuncao = Calculadora.Somar;
      // Operacao executaFuncao = new Operacao (Calculadora.Somar);

      //  // Mult cast DELEGATE( += )
      // executaFuncao += Calculadora.Subtrair;

      // executaFuncao.Invoke(10,10);



      // Data dia =  new Data();
      // dia.SetMes(1);
      // dia.ApresentaMes();
      // Aluno aluno = new Aluno("João","Gabriel");
      // aluno.ToString();

      //dia.GetMes();
      //dia.ApresentaMesTipoProp();

      // //Pessoa indigente = new Pessoa();
      // Pessoa normal = new Pessoa("Tales","Jardim");
      
      // Console.WriteLine (normal.ToString());

      // //Um objeto Singleton

      // Log log = Log.GetInstance();

      // log.propLog = "Primeira Instância Singleton";
      // Log logDois = Log.GetInstance();

      // Console.WriteLine(log.propLog);
      // Console.WriteLine(logDois.propLog);


      // Aluno aluno = new Aluno("João","Gabriel");
      // aluno.Disciplina = "Matemática";
      // aluno.idade = 25;
      // aluno.ToString();


      // Aluno alunoDois = new Aluno("Kayke","Richard",29);
      // aluno.ToString();


    }

  }
}