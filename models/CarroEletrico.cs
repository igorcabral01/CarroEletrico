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
        
        public CarroEletrico(string modelo, int porcentagembateria, bool autonomiadabateria,string verificacaodemanutencao)
        {
            Modelo = modelo;
            PorcentagemBateria = porcentagembateria;
            
        }

        protected CarroEletrico(string modelo, int porcentagembateria, string verificacaodemanutencao)
        {
            Modelo = modelo;
            PorcentagemBateria = porcentagembateria;
            VerificacaoDeManutencao = verificacaodemanutencao;
        }

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
            if(PorcentagemBateria <= 30)
            {
                Console.WriteLine("Autonomia de 150KM...");
            }
            else if(PorcentagemBateria <= 60)
            {
                Console.WriteLine("Autonomia de 300km");
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