using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: " );
            int n = int.Parse(Console.ReadLine());

            int [] a = new int[n];

            Console.WriteLine("Nhap cac phan tu");
            for(int i = 0; i < n; i++)
                    {
                        a[i] = int.Parse(Console.ReadLine());
                    }

            int max1 =a[0];
            int max2 = 0;
            bool foud = false;
        for (int i=0;i<n;i++)
        {
            if (a[i]>max1)
            {
                max2=max1;
                max1=a[i];
                foud = true;
            }
            else if(a[i]< max1 && (!foud || a[i]>max2))
            {
                max2=a[i];
                foud = true;
                
            }
        }
        if (foud)
        {
            Console.WriteLine("So lon nhat: " +max1);
             Console.WriteLine("So lon thu 2: " +max2);
        }
        else
        {
            Console.WriteLine("NO");
        }
        }
    }
}