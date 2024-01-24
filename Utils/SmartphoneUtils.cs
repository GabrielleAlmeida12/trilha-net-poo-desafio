using DesafioPOO.Models;

namespace DesafioPOO.Utils
{
    public static class SmartphoneUtils
    {
        //A classe SmartphoneUtils é declarada como static porque fornece métodos utilitários relacionados a smartphones que não dependem do estado específico de instâncias da classe.
        public static Smartphone CriarSmartphone(string modelo)
        {
            Console.WriteLine($"Smartphone {modelo}");
            Console.WriteLine("Numero:");
            string numero = Console.ReadLine();
            Console.WriteLine("Modelo:");
            string modeloSmartphone = Console.ReadLine();
            Console.WriteLine("Imei:");
            string imei = Console.ReadLine();
            Console.WriteLine("Memoria:");
            int memoria = Convert.ToInt32(Console.ReadLine());

            return modelo == "nokia" ? new Nokia(numero, modeloSmartphone, imei, memoria) :
                                                  (Smartphone)new Iphone(numero, modeloSmartphone, imei, memoria);
        }

        public static void ExecutarAcao(Smartphone smartphone)
        {
            Console.WriteLine("Que ação você deseja executar?");
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Receber ligação");
            Console.WriteLine("3 - Instalar aplicativo");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    smartphone.Ligar();
                    break;

                case 2:
                    smartphone.ReceberLigacao();
                    break;

                case 3:
                    Console.WriteLine("Que aplicativo você deseja instalar?");
                    string nomeAplicativo = Console.ReadLine();
                    smartphone.InstalarAplicativo(nomeAplicativo);
                    break;

                default:
                    Console.WriteLine("Escolha inválida");
                    break;
            }
        }
    }
}
