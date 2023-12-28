using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456",modelo:"Nokia G11", imei: "111111", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatssap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Iphone(numero:"654321",modelo:"iPhone X", imei: "222222", memoria: 128 );
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");