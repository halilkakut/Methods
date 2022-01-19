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

            // Console.WriteLine("********** OUT parametre ve Metot Overloading kavarmları********");
            // string sayi = "999";
            // int outSayi ;

            // bool sonuc = int.TryParse(sayi,out outSayi);
            // if (sonuc)
            // {
            //     Console.WriteLine("Başarılı");
            //     Console.WriteLine(outSayi);
            // }else{
            //     Console.WriteLine("Başarısız");
            // }

            // Metotlar ornek = new Metotlar();
            // ornek.Topla(2,3,out int toplam);
            // Console.WriteLine(toplam);

            // //Method aşırı yükleme - Overloading

            // int sayi1 = 99;
            // //ornek.EkranaYazdir(Convert.ToString(sayi1));
            // ornek.EkranaYazdir(sayi1);

            // //Metot İmzası = Metot Adı + parametre Sayısı + parametre
            // ornek.EkranaYazdir("halil","kakut");

            // Rekürsif Fonksdiyonlar
            // int result = 1;
            // for(int i = 1; i<5; i++)
            // {
            //     result=result*3;

            // }
            // Console.WriteLine(result);

            // Islemler ornek1 = new();
            // Console.WriteLine(ornek1.Expo(3,4));

            // Extension Metotlar
            string ifade = "Halil İbrahim Kakut";
            bool result = ifade.CheckSapces();
            Console.WriteLine(result);
            
            if(result)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {2,6,4,8,9,1,3,0};
            dizi.SortArray();
            dizi.PrintScreen();

            int sayi2 = 5;
            Console.WriteLine(sayi2.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    class Metotlar
    {
        // public void EkranaYazdir(string veri)
        // {
        //     Console.WriteLine(veri);
        // }

        // public void EkranaYazdir(int veri)
        // {
        //     Console.WriteLine(veri);
        // }
        // public void EkranaYazdir(string veri1,string veri2)
        // {
        //     Console.WriteLine(veri1 + veri2);
        // }

        // public int ArttirVeTopla(int x, int y)
        // {
        //     x+=1;
        //     y+=y;
        //     return (x+y);
        // }

        // public void Topla(int a,int b,out int toplam)
        // {
        //     toplam = a + b;
        // }

        

    }

    class Islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us<2)
            {
                return sayi;
            }
            return Expo(sayi,us-1)*sayi;
        }
    }

    static class Extension
    {
        public static bool CheckSapces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintScreen(this int[] param)
        {
            foreach (var item in param)
            {
                Console.Write(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
