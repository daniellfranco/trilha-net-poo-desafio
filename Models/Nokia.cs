namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {

            if (AppsInstalados.Contains(nomeApp))
            {
                Console.WriteLine($"O Aplicativo {nomeApp} ja está instalado no seu Nokia");
            }
            else
            {
                Console.WriteLine($"Instalando o app {nomeApp} no seu Nokia.");
                AppsInstalados.Add(nomeApp);
            }

        }

        public override void ListarApps()
        {
            Console.WriteLine("Os seguintes aplicativos estão instalados no seu Nokia:");
            base.ListarApps();
        }
    }
}