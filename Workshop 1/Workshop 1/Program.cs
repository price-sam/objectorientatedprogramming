using System;

namespace Workshop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string greeting1 = "Hello"l
            //Console.WriteLine(greeting1);

            int number = 0;
            while (number < 5)
            {
                Console.WriteLine($"The number is {number}");
                number++;
            }

            do
            {
                Console.WriteLine($"The number is {number}");
                number++;
            } while (number < 5);

            for (int anotherNumber = 0; anotherNumber < 5; anotherNumber++)
            {
                Console.WriteLine($"The number is {number}");
            }

            int sum = 0;
            for (int aNumber = 0; aNumber < 101; aNumber++)
            {
                if (aNumber % 2 == 0)
                {
                    sum = sum + aNumber;
                }
            }
            Console.WriteLine($"The sum of even numbers between 0 and 100 is {sum}");



        }
    }
}
