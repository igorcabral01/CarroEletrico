using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Data;

namespace Project.models
{
    public abstract class  CarroEletrico
    {
        protected string Modelo { get; set; }
        protected int PorcentagemBateria { get; set; }
        public string VerificacaoDeManutencao { get; set; }

        protected CarroEletrico(string modelo, int porcentagembateria)
        {
            Modelo = modelo;
            PorcentagemBateria = porcentagembateria;
        }

        public void Start()
        {
            Console.WriteLine("Veiculo Ligado com sucesso! \n Verificando Baterias...");
        }
        public void Baterias()
        {
            Console.WriteLine($"Veiculo Pronto, Bateria :"+ PorcentagemBateria +"%");
        }

        public void Autonomia()
        {
            if(PorcentagemBateria <= 15)
            {
                Console.WriteLine("Autonomia de 50...");
            }
            else if(PorcentagemBateria <= 30)
            {
                Console.WriteLine("Autonomia de 100");
            }
            
             else if(PorcentagemBateria <= 50)
            {
                Console.WriteLine("Autonomia de 150");
            }
             else if(PorcentagemBateria <= 70)
            {
                Console.WriteLine("Autonomia de 210");
            }
             else if(PorcentagemBateria <= 80)
            {
                Console.WriteLine("Autonomia de 290");
            }
             else if(PorcentagemBateria <= 90)
            {
                Console.WriteLine("Autonomia de 340");
            }
            else
            {
                Console.WriteLine("Autonomia de 420km");
            }
            
        }
        public void Manutencao()
        {
            Console.WriteLine("Verificando Manutençoes Preventivas, Proxima a ser realida em 01/03/2024");
        }
        public abstract void ComandoDeVoz(string Ligar_Desligar);
        
        
    }
    
}