using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("--------------------------------------------------------------------------------");
Iphone iphone = new Iphone("0000");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine("--------------------------------------------------------------------------------");
Nokia nokia = new Nokia("1111");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.Numero = "3333";
Console.WriteLine("--------------------------------------------------------------------------------");
