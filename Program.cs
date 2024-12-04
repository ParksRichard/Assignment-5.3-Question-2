/*
You are climing a staircase. It takes n steps to reach the top.
Each time youc an either climb 1 or 2 steps. How many distinct ways 
can you climb to the top?
*/

//count step = n
//-1 step
//-2 step
//combo of 3? how many distinct combinations?
//1 step and 2 step as individual variables, fit how many times into n
//using array? or recursion f[n]++
//fibonacci?


namespace Assignment_5._3_Question_2
{
    using System;

    public class Staircase
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;

            int prev1 = 1;
            int prev2 = 1;

            for (int i = 2; i <= n; i++)
            {
                int current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }

            return prev1;
        }

        public static void Main(string[] args)
        {
           //input
            Console.Write("Please enter the number of steps on the staircase: ");
            Console.WriteLine("");
            int n;

            if (int.TryParse(Console.ReadLine(), out n) && n >= 1)
                
            {
                Staircase solution = new Staircase();

                int result = solution.ClimbStairs(n);
                Console.WriteLine($"The number of distinct ways to the top of the stairs: {result}");
            }
            else
            {
                Console.WriteLine("The user input doesn't caluclate.");
            }
        }
    }

}
