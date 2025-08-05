using DesafioPOO.Models;

// Teste com Iphone
Console.WriteLine("Teste com iPhone:");
Smartphone iphone = new Iphone(numero: "11999999999", modelo: "iPhone 13", imei: "IMEI12345", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

// Teste com Nokia
Console.WriteLine("Teste com Nokia:");
Smartphone nokia = new Nokia(numero: "21988888888", modelo: "Nokia 3310", imei: "IMEI67890", memoria: 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
