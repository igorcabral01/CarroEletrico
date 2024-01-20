using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.models
{
    public class Modelo_XS1 : CarroEletrico
    {
        public Modelo_XS1(string modelo, int porcentagembateria  ) : base(modelo, porcentagembateria)
        {

        }
        public void Atualizaçao()
        {
            
        }

        public override void ComandoDeVoz(string Ligar_Desligar)
        {
            Console.WriteLine($"Voce Desejou {Ligar_Desligar} o Comando de voz no XS1");
        }
         public void Waze()
         {
            Console.WriteLine("Bem Vindo ao Waze, Digite o Destino ...");
            List<string> lugares = new List<string>();
            lugares.Add(Console.ReadLine());
            if(lugares.Any())
            {
                for (int i = 1; i < lugares.Count; i++)
                {
                    Console.WriteLine($"{i} - {lugares[i]}");
                }
            }
         }
         public void Spotfy()
         {
            Console.WriteLine("Qal Musica Quer Ouvir?");
            List<string> Historic = new List<string>();
            Historic.Add(Console.ReadLine());
            if(Historic.Any())
            {
                for (int i = 1; i < Historic.Count; i++)
                {
                    Console.WriteLine($"{i} - {Historic[i]}");
                }
            }

         }
         public void Youtube()
         {
          Console.WriteLine("Qual Musica Quer Ouvir?");
            List<string> HistoricYT = new List<string>();
            HistoricYT.Add(Console.ReadLine());
            if(HistoricYT.Any())
            {
                for (int i = 1; i < HistoricYT.Count; i++)
                {
                    Console.WriteLine($"{i} - {HistoricYT[i]}");
                }
            }
         }
         public void InfoCarro()
         {
         Console.WriteLine("INFORMAÇOES DE SOFTWARE E ATUALIZAÇOES DISPONIVEIS");
         Console.WriteLine("Versao Software 1.0.0");
    
         

         }
        
      
    }
}