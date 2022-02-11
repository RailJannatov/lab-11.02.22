using System;

namespace lab1

{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int Sum = A;
            //for (int i = 1; i < B; i+=2)
            //{

            //    Sum *= A;
            //    //Sum = Sum * A;
            //}
            //Console.WriteLine(Sum);
            //Console.WriteLine(  CheckNumberInDigit(421,9));


            //int num1 = 2;
            //int num2 = 16;

            //int sum = 0;
            //while (num2>=num1)
            //{
            //    num2 /= num1;
            //    sum++;
            //}
            //Console.WriteLine(sum);

            //int A = Convert.ToInt32(Console.ReadLine());
            //int tameded = Convert.ToInt32(Console.ReadLine());
            //int i;
            //for (i = 1; tameded > A; i++)
            //{
            //    tameded /= A;
            //}
            //Console.WriteLine(i);

            Console.WriteLine(CheckFactorialNumber(5));
        }

        //static Boolean CheckNumberInDigit(int digit,int number)
        //{
        //    while (digit != 0)
        //    {
        //        if ((digit % 10) == number)
        //        {
        //            return true;
        //        }
        //        digit /= 10;
                
        //    }

        //    return false;
        //}
        static int CheckFactorialNumber(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial*i;
            }
            return factorial;
        }
    }
}
