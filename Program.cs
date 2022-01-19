using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
        //     int x = 3;
        //     int y = 4;
        //     int sonuc = Topla(x,y);

            

        //     //Console.WriteLine(sonuc);
        //     Metotlar ornek = new Metotlar();
            
        //     ornek.EkranaYazdir(Convert.ToString(sonuc));

        //     int sonuc2 = ornek.ArttirVeTopla(x,y);
        //     ornek.EkranaYazdir(Convert.ToString(sonuc2));
        // }

        // static int Topla (int x, int y)
        //     {
        //         return (x+y);
        //     }

            Console.WriteLine("********** OUT parametre ve Metot Overloading kavarmları********");
            string sayi = "999";
            int outSayi ;

            bool sonuc = int.TryParse(sayi,out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else{
                Console.WriteLine("Başarısız");
            }

            Metotlar ornek = new Metotlar();
            ornek.Topla(2,3,out int toplam);
            Console.WriteLine(toplam);

            //Method aşırı yükleme - Overloading

            int sayi1 = 99;
            //ornek.EkranaYazdir(Convert.ToString(sayi1));
            ornek.EkranaYazdir(sayi1);

            //Metot İmzası = Metot Adı + parametre Sayısı + parametre
            ornek.EkranaYazdir("halil","kakut");
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

        public int ArttirVeTopla(int x, int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }

        public void Topla(int a,int b,out int toplam)
        {
            toplam = a + b;
        }

    }
}
