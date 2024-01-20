using System.Diagnostics;
using Project.models;

Console.WriteLine("Bem vindo ao XS1");
Modelo_XS1 xs1 = new Modelo_XS1("XS1", 10);

bool exibirmenu = true;
while (exibirmenu)
{
    Console.Clear();
    Console.WriteLine("Bem Vindo ao Menu do XS1");
    Console.WriteLine("");
    Console.WriteLine("1 Info.Ignição");
    Console.WriteLine("2 Bateria/Autonomia");
    Console.WriteLine("3 Comando de Voz");
    Console.WriteLine("4 Verificar Manutenção");
    Console.WriteLine("5 WAZE");
    Console.WriteLine("6 Spotfy");
    Console.WriteLine("7 YOUTUBE");
    Console.WriteLine("8 - Encerrar");

   switch (Console.ReadLine())
   {
     case "1":
     xs1.Start();
     xs1.InfoCarro();
     break;

      case "2":
     xs1.Baterias();
     xs1.Autonomia();
     break;

     case "3":
     xs1.ComandoDeVoz("DESLIGAR");
     break;

     case "4":
     xs1.Manutencao();
     break;

     case "5":
     xs1.Waze();
     break;

     case "6":
     xs1.Spotfy();
     break;

     case "7":
     xs1.Youtube();
     break;

     default:
      Console.WriteLine("Opção inválida");
      break;
      case "8":
     exibirmenu = false;
     break;
   }
     Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");
// Console.WriteLine("-----------------------------------------------");

// Console.WriteLine("Bem vindo ao XS2");
// Modelo_XS2 xs2 = new Modelo_XS2("XS2", 99);
// xs2.Start();
// xs2.Baterias();
// xs2.Autonomia();
// xs2.ComandoDeVoz("LIGAR");
// xs2.Manutencao();

// Console.WriteLine("-----------------------------------------------");

// Console.WriteLine("Bem vindo ao XS3");
// Modelo_XS3 xs3 = new Modelo_XS3("XS3", 15);
// xs3.Start();
// xs3.Baterias();
// xs3.Autonomia();
// xs3.ComandoDeVoz("LIGAR");
// xs3.Manutencao();void Switch(string v)
// {
//     throw new NotImplementedException();
// }