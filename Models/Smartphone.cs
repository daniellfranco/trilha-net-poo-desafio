using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        //alterado para protected para poder fazer uma listagem de modelo com polimorfismo
        protected string Modelo { get; set; }
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

        //metodos de ideias adicionais abaixo
        public abstract void DesinstalarAplicativo(string nomeApp);

        public virtual void ListarApps()
        {
            if (AppsInstalados.Count == 0)
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

        //metodo para listar dados privados do smartphone
        public virtual void ListarInformacoes()
        {
            //Console.WriteLine($" {Modelo}"); //implementar com polimorfismo
            Console.WriteLine($"Numero de telefone: {Numero}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}GB");
        }
    }
}