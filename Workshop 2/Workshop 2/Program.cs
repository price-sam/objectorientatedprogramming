using System;

namespace Workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Collatz collatz = new Collatz(9329);
        }
    }

    class Collatz
    {
        int positiveInteger = 0;
        public Collatz(int thePositiveInteger)
        {
            if (thePositiveInteger > 0)
            {
                positiveInteger = thePositiveInteger;
            }
            else
            {
                Console.WriteLine("thePositiveInteger must be an integer > 0");
                return;
            }

            Console.WriteLine(positiveInteger);

            while (positiveInteger != 1)
            {
                if (positiveInteger % 2 == 0)
                {
                    positiveInteger = positiveInteger / 2;
                }
                else
                {
                    positiveInteger = (positiveInteger * 3) + 1;
                }
                Console.WriteLine(positiveInteger);
            }
        }

  

          

    }
}
