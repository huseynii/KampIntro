﻿Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Huseyin";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Hasan";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Veli";
kurs3.IzlenmeOrani = 80;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3
};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
