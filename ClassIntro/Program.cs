using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adi = "Naim";
            // int yas = 29;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Naim";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Saim";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "İbrahim";
            kurs3.IzlenmeOrani = 85;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Feryad";
            kurs4.IzlenmeOrani = 82;

            //Console.WriteLine(kurs1.KursAdi + " "  + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " %" + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
