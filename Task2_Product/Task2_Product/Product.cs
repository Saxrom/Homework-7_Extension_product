using System;
namespace Task2_Product
{
    abstract class Product
    {
        public string Name;
        public static double Price;
        public byte Count;
        public double TotalInCome;
        public static double Income;

        public Product(string name,byte count)
        {
            Name = name;
            Count = count;
            TotalInCome = Count * Price;
        }

        static Product()
        {
            Price = 5;
            Income = 0;
        }

        public void Sell()
        {
            if (Count>0)
            {
                
                Income += Price;
                Console.WriteLine($"Mehsulun sayi:{Count-1},Gelir:{Income}");
                Count--;
            }

            else
            {
                Console.WriteLine($"Mehsuldan qalmayib,Umumi gelir:{Income}");
            }
        }

        

    }
}
