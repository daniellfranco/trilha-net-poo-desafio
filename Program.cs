using DesafioPOO.Models;

// Realizando testes nas classes Nokia e Iphone

Iphone celIphone = new Iphone("(99) 9-9999-9999", "14 Pro", "11111111111111", 6);

Nokia celNokia = new Nokia("(77) 7-7777-7777", "5.4", "22222222222222", 4);

Console.WriteLine("Testando iPhone");
celIphone.Numero = "(88) 8-8888-8888";
celIphone.Ligar();
celIphone.ReceberLigacao();
celIphone.ListarApps();
celIphone.InstalarAplicativo("Whatsapp");
celIphone.InstalarAplicativo("Discord");
celIphone.InstalarAplicativo("Gmail");
celIphone.InstalarAplicativo("Whatsapp");
celIphone.ListarApps();
celIphone.DesinstalarAplicativo("Gmail");
celIphone.DesinstalarAplicativo("Caixa");
celIphone.ListarApps();
celIphone.ListarInformacoes();

Console.WriteLine("-----------------------------------");
Console.WriteLine("Testando Nokia");
celNokia.Ligar();
celNokia.ReceberLigacao();
celNokia.ListarApps();
celNokia.InstalarAplicativo("Whatsapp");
celNokia.InstalarAplicativo("Discord");
celNokia.InstalarAplicativo("Gmail");
celNokia.InstalarAplicativo("Discord");
celNokia.ListarApps();
celNokia.DesinstalarAplicativo("Discord");
celNokia.DesinstalarAplicativo("Telegram");
celNokia.ListarApps();
celNokia.ListarInformacoes();