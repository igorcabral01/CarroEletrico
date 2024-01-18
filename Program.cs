using Project.models;

Console.WriteLine("Bem vindo ao XS1");
Modelo_XS1 xs1 = new Modelo_XS1("XS1", 45);
xs1.Start();
xs1.Baterias();
xs1.Autonomia();
xs1.ComandoDeVoz("DESLIGAR");
xs1.Manutencao();

Console.WriteLine("-----------------------------------------------");

Console.WriteLine("Bem vindo ao XS2");
Modelo_XS2 xs2 = new Modelo_XS2("XS2", 99);
xs2.Start();
xs2.Baterias();
xs2.Autonomia();
xs2.ComandoDeVoz("LIGAR");
xs2.Manutencao();

Console.WriteLine("-----------------------------------------------");

Console.WriteLine("Bem vindo ao XS3");
Modelo_XS3 xs3 = new Modelo_XS3("XS3", 15);
xs3.Start();
xs3.Baterias();
xs3.Autonomia();
xs3.ComandoDeVoz("LIGAR");
xs3.Manutencao();