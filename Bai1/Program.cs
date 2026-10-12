using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, max, min, sum, agv, result;
            Console.WriteLine("Nhap a: " );
            a =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c =Convert.ToDouble(Console.ReadLine());

            max = Math.Max(a, Math.Max(b,c));
            min = Math.Min(a, Math.Min(b,c));

            sum = a+b+c;
            agv = sum/3;
            result = Math.Round(agv,2);

            Console.WriteLine("Gia tri lon nhat: " + max);
            Console.WriteLine("Gia tri nho nhat: " + min);
            Console.WriteLine("Tong: " + sum);
            Console.WriteLine("Trung binh cong: "+ result);
        }
    }
}