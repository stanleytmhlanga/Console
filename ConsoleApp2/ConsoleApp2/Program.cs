using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            var sentance = Setance.SentanceReversed("Hello my reversed word im happy !");
            Console.WriteLine("Revesed Sentance :{0}", sentance);
            int[] arr = { 1, 2, 3, 4, 5 };
            var sorted = Setance.IsSorted(arr);
            Console.WriteLine("Is Sorted  :{0}", sorted);



            int no_row, c = 1, blk, i, j;

            Console.Write("\n\n");
            Console.Write("Display the Pascal's triangle:\n");
            Console.Write("--------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows: ");
            no_row = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < no_row; i++)
            {
                for (blk = 1; blk <= no_row - i; blk++)
                    Console.Write("  ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write("{0}   ", c);
                }
                Console.Write("\n");
            }

            //prime number
            int num, ci, ctr = 0;

            Console.Write("\n\n");
            Console.Write("Check whether a given number is prime or not:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
            {
                Console.Write("{0} is a prime number.\n", num);
            }
            else
            {
                Console.Write("{0} is not a prime number\n", num);
            }



            int nums, di, ctrr, stno, enno;
            ctrr = 0;
            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (nums = stno; nums <= enno; nums++)
            {
                ctr = 0;

                for (i = 2; i <= nums / 2; i++)
                {
                    if (nums % i == 0)
                    {
                        ctrr++;
                        break;
                    }
                }

                if (ctrr == 0 && nums != 1)
                {
                    Console.Write("{0} ", nums);
                }
            }
            Console.Write("\n");
        }

    }
}

public static class Setance
{
    // reversing sentance
    public static string SentanceReversed(string toReverse)
    {
        string[] reverseArry = toReverse.Split(" ");
        Array.Reverse(reverseArry);
        string reversed = String.Join(" ", reverseArry);

        return reversed;
    }

    public static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }


}

