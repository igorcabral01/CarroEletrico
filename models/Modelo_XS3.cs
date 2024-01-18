using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.models
{
    public class Modelo_XS3 : CarroEletrico
    {
        public Modelo_XS3(string modelo, int porcentagembateria) : base(modelo, porcentagembateria)
        {
            
        }

        public override void ComandoDeVoz(string Ligar_Desligar)
        {
            Console.WriteLine($"Voce Desejou {Ligar_Desligar} o Comando de voz no XS3");
        }
    }
}