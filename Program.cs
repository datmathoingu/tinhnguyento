using System;

namespace blablabla
{
    class Program
    {
        public static void Main()
        {

            int number;
            int n = 0;

            Console.Write("Nhap mot so bat ky: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    n++;

            if (n == 2)
                Console.WriteLine("{0} la so nguyen to.", number);
            else
                Console.WriteLine("{0} khong phai la so nguyen to.", number);

            Console.ReadKey();
        }
    }
}