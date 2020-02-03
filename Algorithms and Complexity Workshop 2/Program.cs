using System;

namespace Algorithms_and_Complexity_Workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 4;
            //for (int i = 0; i <= (1.5*n) ; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = n; i >=1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i= 2; i<=n; i++)
            //{
            //    for (int j = 0; j <=n;)
            //    {
            //        Console.WriteLine(i + ":" + j);
            //        j = j + (n / 4);
            //    }
            //}

            int add_them(int n, int[] A)
            {
                var j = 0;
                for (int i = 1; i <=n; i++)
                {
                    j = j + A[i];
                }
                var k = 1;
                for (int i = 1; i <=n; i++)
                {
                    k = k + k;
                }

                return j + k;
            }

            int[] array = {0,2,5,3,7,8};
            Console.WriteLine(add_them(5, array));
        }
    }
}
