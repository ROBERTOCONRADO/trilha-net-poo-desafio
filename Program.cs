using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo X Pro", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Iphone 15", imei: "123456", memoria: 264);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");