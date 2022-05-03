using System;

namespace Task2_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zehmet olmasa mehsulun sayini daxil edin:");
            byte count = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            Milk milk = new Milk("Loktaid", count);
            bool result = false;
            int selection;
            do
            {
                Console.WriteLine("1.Mehsul haqda melumat");
                Console.WriteLine("2.Mehsulu satmaq");
                Console.WriteLine("3.Proqrami terk etmek");
                Console.Write("Select:");
                selection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (selection == 1)
                {
                    milk.getInfo();
                    Console.WriteLine();
                }

                else if (selection == 2)
                {
                    milk.Sell();
                }

                else
                {
                    result = true;
                }
            } while (!result);

            
        }
    }
}
