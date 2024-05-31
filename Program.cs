using DesafioSistCelular.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo: "modelo A50", imei: "1111000", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "modelo 17", imei: "222222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

