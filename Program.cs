using DesafioPOO.Utils;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Qual o seu smartphone (digite nokia ou iphone)?");
        string modeloSmartphone = Console.ReadLine().ToLower();

        Smartphone smartphone = SmartphoneUtils.CriarSmartphone(modeloSmartphone);

        do
        {
            SmartphoneUtils.ExecutarAcao(smartphone);

            Console.WriteLine("Deseja realizar outra ação? (s/n)");
        } while (Console.ReadLine().ToLower() == "s");
    }
}