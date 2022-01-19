using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int sonuc = Topla(x,y);

            

            //Console.WriteLine(sonuc);
            Metotlar ornek = new Metotlar();
            
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(x,y);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
        }

        static int Topla (int x, int y)
            {
                return (x+y);
            }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int x, int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }

    }
}
