using System;
using DesafioPOO.Models;

Nokia meuNokia = new Nokia("1234-5678", "Nokia 3310", "IMEI123456");
meuNokia.Ligar();
meuNokia.InstalarAplicativo("WhatsApp");

Iphone meuIphone = new Iphone("9876-5432", "iPhone 13", "IMEI654321");
meuIphone.Ligar();
meuIphone.InstalarAplicativo("Telegram");
