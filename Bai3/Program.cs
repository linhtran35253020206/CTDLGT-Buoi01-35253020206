using System;
using System.Diagnostics;

namespace Bai3
{
    class Program
    {
        // Phiên bản A
        static void SolveVersionA(int[] arr)
        {
            long maxSum = arr[0];
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                long currentSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }

            Console.WriteLine($"Tong lon nhat: {maxSum}");
            Console.Write("Doan con: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // Phiên bản B
        static void SolveVersionB(int[] arr)
        {
            long maxSum = arr[0];
            long currentMax = arr[0];
            
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > currentMax + arr[i])
                {
                    currentMax = arr[i];
                }
                else
                {
                    currentMax = currentMax + arr[i];
                }

                if (currentMax > maxSum)
                {
                    maxSum = currentMax;
                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }

            Console.WriteLine($"Tong lon nhat: {maxSum}");
            Console.Write("Doan con: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
              
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] a = new int[n];
            
            Console.WriteLine("Nhap cac phan tu");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ket qua tu Phien ban A: ");
            SolveVersionA(a);

            Console.WriteLine("\nKet qua tu Phien ban B: ");
            SolveVersionB(a);

            
            // PHẦN 2: ĐO THỜI GIAN(Tham khảo AI)
            
            int[] testSizes = { 100, 1000, 10000 };
            Random rnd = new Random();

            foreach (int size in testSizes)
            {
                int[] data = new int[size];
                for (int i = 0; i < size; i++) data[i] = rnd.Next(-100, 100);

                Console.WriteLine($"\n--- Kich thuoc n = {size} ---");

                // Đo thời gian Phiên bản A
                var stopwatchA = Stopwatch.StartNew();
                long maxSumA = data[0];
                for (int i = 0; i < data.Length; i++)
                {
                    long currentSum = 0;
                    for (int j = i; j < data.Length; j++)
                    {
                        currentSum += data[j];
                        if (currentSum > maxSumA) maxSumA = currentSum;
                    }
                }
                stopwatchA.Stop();
                Console.WriteLine($"Phiên bản A - Thoi gian: {stopwatchA.Elapsed.TotalMilliseconds} ms");

                // Đo thời gian Phiên bản B
                var stopwatchB = Stopwatch.StartNew();
                long maxSumB = data[0];
                long currentMax = data[0];
                for (int i = 1; i < data.Length; i++)
                {
                    currentMax = Math.Max(data[i], currentMax + data[i]);
                    maxSumB = Math.Max(maxSumB, currentMax);
                }
                stopwatchB.Stop();
                Console.WriteLine($"Phiên bản B - Thoi gian: {stopwatchB.Elapsed.TotalMilliseconds} ms");
            }
        }
    }
}