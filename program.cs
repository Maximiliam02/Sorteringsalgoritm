using System;
using System.Threading;
using System.Diagnostics;

namespace sfdfwedfs
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10000];


            int temp;
            Random Talet = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Talet.Next(A.Length);

            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < A.Length; i++)
            {
                for (int b = 0; b < A.Length - 1 - i; b++)
                {

                    if (A[b] > A[b + 1])
                    {
                        temp = A[b];
                        A[b] = A[b + 1];
                        A[b + 1] = temp;



                    }


                }

            }
            stopwatch.Stop();
            for (int x = 0; x < A.Length; x++)
            {
                Console.WriteLine(A[x]);
            }
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds + " Milisekunder");
        }
    }
}
            


