using System;
namespace Task2_Product
{
    class Milk : Product
    {
        public static string Volume;
        public static string Fatrate;

        public Milk(string name,byte count):base(name,count)
        {
            Count = count;
       
        }

        static Milk()
        {
            Volume = "2litr";
            Fatrate = "30%";
        }

        public  void getInfo()
        {
            Console.WriteLine($"Mehsulun adi:{Name},Yagliligi:{Fatrate},Hecmi:{Volume}");
        }
    }
}
