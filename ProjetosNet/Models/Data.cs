using System;
namespace ProjetosNet.Models
{
    public class Data
    {
    //Primeiro Design de código 
         public int statusMes = ((int)EstadoMes.INVALIDO);
         private int mes;

         enum EstadoMes
         {
             VALIDO = -1,
             INVALIDO = -2
         }

         public int GetMess()
         {
             return this.mes;
         }
         public void SetMes(int value)
         {
             if (value >=1 && value <=12)
             {
                 this.mes = value;
                 statusMes = ((int)EstadoMes.VALIDO);              
             }
         }

         public void ApresentaMes()
         {
             if ( statusMes == ((int)EstadoMes.INVALIDO))
             {
                 Console.WriteLine("");
                 Console.WriteLine($" Mês Inválido");
                 return;
             }
             Console.WriteLine($"Estamos no mês {this.mes}");
         }

    //Segundo Design de código 
    //      private bool mesValido = false;        
    //      public int Mes { 
            
    //          get
    //          {
    //              return this.Mes;
    //          }
        
    //       set
    //       {
    //          if (value >=1 && value <=12)
    //          {
    //              this.Mes = value;
    //              mesValido = true;
    //          }

    //       } }

    //     public void  ApresentaMesTipoProp()
    //     {
    //         if (!this.mesValido)
    //         {
    //             Console.WriteLine("Mês Inválido");
    //         }

    //         Console.WriteLine($"Estamos no mês {this.Mes}");
    //     }


    // }
}
}