namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {

            if (AppsInstalados.Contains(nomeApp))
            {
                Console.WriteLine($"O Aplicativo {nomeApp} ja está instalado no seu iPhone");
            }
            else
            {
                Console.WriteLine($"Instalando o app {nomeApp} no seu Iphone.");
                AppsInstalados.Add(nomeApp);
            }

        }

        public override void DesinstalarAplicativo(string nomeApp)
        {

            if (AppsInstalados.Contains(nomeApp))
            {
                Console.WriteLine($"Desinstalando o app {nomeApp} do seu Iphone.");
                AppsInstalados.Remove(nomeApp);
            }
            else
            {
                Console.WriteLine($"O Aplicativo {nomeApp} não encontrado no seu iPhone");
            }

        }

        public override void ListarApps()
        {
            Console.WriteLine("Os seguintes aplicativos estão instalados no seu Iphone:");
            base.ListarApps();
        }

        public override void ListarInformacoes()
        {
            Console.WriteLine("Informações do iPhone:");
            Console.WriteLine($"Modelo: Iphone {Modelo}");
            base.ListarInformacoes();
        }
    }
}