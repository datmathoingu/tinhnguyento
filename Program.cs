using System;
using System.Text;
namespace NguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string strn;
            int n;
            Boolean kt;
            Console.Write("Nhap n: ");
            strn = Console.ReadLine();
            n = int.Parse(strn);
            kt = KTNguyenTo(n);
            if (kt)
                Console.WriteLine("{0} là số nguyên tố", n);
            else
                Console.WriteLine("{0} không phải là số nguyên tố", n);
            Console.ReadLine();
        }
        static Boolean KTNguyenTo(int n)
        {
            int i, m;
            if (n < 0) n = -n;
            if (n < 2) return false;
            if (n == 2) return true;
            m = n / 2;
            for (i = 2; i <= m; i++)
                if ((n % i) == 0)
                    return false;
            return true;
        }
    }
}
