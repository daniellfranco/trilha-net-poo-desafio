using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        //adicional
        public List<string> AppsInstalados = new List<string>();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public virtual void ListarApps()
        {
            if(AppsInstalados.Count == 0)
            {
                Console.WriteLine("Não há aplicativos instalados, que tal instalar algum?");
            }
            else
            {
                foreach (string aplicativo in AppsInstalados)
                {
                    Console.WriteLine(aplicativo);
                }
            }

        }

        //ideia adicional
        //metodo para listar dados do smartphone
        public void ListarInformacoes()
        {
            Console.WriteLine($"Numero de telefone: {Numero}");
            //Console.WriteLine($" {Modelo}"); //implementar com polimorfismo
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}GB");
        }
    }
}