using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("------- Smartphone Nokia ---------");
Nokia n = new Nokia(numero: "12345",modelo: "xyz", imei: "ABC234T", memoria: 64);

Console.WriteLine($"Numero: {n.Numero}");
n.Ligar();
n.InstalarAplicativo("WhatsApp");

Console.WriteLine("------- Smartphone IPhone ---------");
Iphone i1 = new Iphone(numero: "98765",modelo: "ABC", imei: "DEF998T", memoria: 128);
Console.WriteLine($"Numero: {i1.Numero}");
i1.ReceberLigacao();
i1.InstalarAplicativo("Discord");
