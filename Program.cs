using DesafioPOO.Models;

Nokia nokia = new Nokia("11999999999", "Nokia 3310", "1234567890", 64);
Iphone iphone = new Iphone("11988888888", "Iphone 13", "0987654321", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Angry Birds");