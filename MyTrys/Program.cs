    using System;

namespace MyTrys
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1 = -55;
            int not2 = -55;
            int sonuc = (not1 + not2) / 2;

            if (sonuc < 50)
            {
                Console.WriteLine("Puanınız : " + sonuc + "\nSınıfta kaldınız!!!");
            }
            else
            {
                Console.WriteLine("Puanınız : " + sonuc + "\nSınıfı geçtiniz");
            }

            int number = 9;

            if (number < 10)
            {
                Console.WriteLine(number + " sayısı bir rakamdır");
            }
            else
            {
                Console.WriteLine(number + " sayısı bir rakam değildir");
            }




        }
    }

}
