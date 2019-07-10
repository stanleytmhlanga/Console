using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { 1, 2,3 };
            var sol = solutionMissingIntiger(array);
            var d = solutionmultipleRange(2000000000, 2000000000, 2000000000);
            Console.WriteLine("first solution "+sol);
            Console.WriteLine("second solution " + d);
            CheckDivisibility(2000000000, 2000000000, 2000000000);
            Console.WriteLine("solution2 " + solution2(2000000000, 2000000000, 2000000000));
            Console.Read();
        }

        public static int solutionMissingIntiger(int[] A)
        {
            //var i = 0;
            //var result = A.Where(a => a > 0).Distinct().OrderBy(a => a).Any(a => a != (i = i + 1)) ? i : i + 1;
            //return result;
            int result = 1;
            Dictionary<int, bool> found = new Dictionary<int, bool>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && !found.ContainsKey(A[i]))
                {
                    found.Add(A[i], true);
                }
            }

            while (found.ContainsKey(result))
            {
                result++;
            }

            return result;
        }
        public static int solutionmultipleRange(int A, int B, int K)
        {

            int count = (B / K - A / K) + (A % K == 0 ? 1 : 0);

            return count;
        }
        public static void CheckDivisibility(int A, int B, int k)
        {
            int firstdivisorpos = A + (k - (A % k));
            int lastdivisorpos = B - B % k;
            int totalnosdivisble = (lastdivisorpos - firstdivisorpos) / k;
            Console.WriteLine("CheckDivisibility answer " + totalnosdivisble + 1);
            Console.ReadKey();
        }
        public static int solution2(int A, int B, int K)
        {
            return (int)Math.Floor(((B - A) % (double)K));
        }
        public static int solutionSuming(int[] A)
        {
            double sum = A.Sum(d => (double)d);
            double leftSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (leftSum == (sum - leftSum - A[i]))
                {
                    return i;
                }
                else
                {
                    leftSum = leftSum + A[i];
                }
            }
            return -1;
        }

        public int solutionPerm(int[] A)
        {
            return (Enumerable.Range(1, A.Length).Except(A).Count() == 0) ? 1 : 0;
        }
        public int solutionPerm2(int[] A)
        {
            // idea: add to set,dictionary. Count the size and compare to N.
            // dedupe data when needed. 
            var set = new HashSet<int>();
            var max = int.MinValue;

            foreach (var item in A)
            {
                if (set.Contains(item)) return 0;

                set.Add(item);
                if (item > max) max = item;
            }
            return set.Count == max ? 1 : 0;
        }
    }
}
