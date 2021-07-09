using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialNumber
{
    public class Program
    {
        /// <summary>
        /// Special Number
        /// Special Number is list of non-negative integer that is constructed from non-negative integer
        /// Special Number has two operations, Special Summation and Special Multiplication
        /// 
        /// You must implement SpecialSummation and Special Multiplication Method
        /// See explanation for each method below
        /// 
        /// DO NOT CHANGE THE CODE IN MAIN
        /// </summary>
        static void Main(string[] args)
        {
            TestResult(6, SpecialSummation(123));
            TestResult(9, SpecialSummation(567));

            TestResult(6, SpecialMultiplication(123));
            TestResult(0, SpecialMultiplication(567));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /**
         * PLEASE DO NOT CHANGE THE CODE OF THIS METHODO
         **/
        private static void TestResult(int expected, int actual)
        {
            if (expected == actual)
            {
                Console.WriteLine("Answer is correct");
            }
            else
            {
                Console.WriteLine("Answer is wrong. Expected level is {0} but your result is {1}", expected, actual);
            }
        }

        /// <summary>
        /// SpecialSummation is sums of all digit in Special Number
        /// Example:
        /// >>> SpecialSummation(123)
        /// >>> 6   (from 1+2+3)
        /// 
        /// >>> SpecialSummation(567)
        /// >>> 9   (from 5+6+7 = 18 then 1+8 = 9)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Summation of Special Number</returns>
        public static int SpecialSummation(int number)
        {
            // AMEND YOUR CODE BELOW THIS LINE

            
            string list1 = Console.ReadLine();
            int sum1 = 0;
            int sum2 = 0;

            if (list1.Length > 1)
            {
                foreach (char c in list1)
                {
                    sum1 += int.Parse(c.ToString());
                }
                if (sum1 > 9)
                {
                    string list2 = sum1.ToString();
                    
                    foreach (char c in list2)
                    {
                        sum2 += int.Parse(c.ToString());
                    }
                    Console.WriteLine(sum2);
                }
                else
                {
                    Console.WriteLine(sum1);
                }
            }

            //throw new NotImplementedException();
            if (sum1 > 9)
            {
                return sum2;
            }
            else
            {
                return sum1;
            }
            
            


            // AMEND YOUR CODE ABOVE THIS LINE
        }

        /// <summary>
        /// SpecialMultiplication is multiplication of all digit in Special Number
        /// Example:
        /// >>> SpecialMultiplication(123)
        /// >>> 6   (from 1*2*3)
        /// 
        /// >>> SpecialSummation(567)
        /// >>> 0   (from 5*6*7 = 210 then 2*1*0 = 0)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Multiplication of Special Number</returns>
        public static int SpecialMultiplication(int number)
        {
            // AMEND YOUR CODE BELOW THIS LINE
            string list1 = Console.ReadLine();
            int mul1 = 1;
            int mul2 = 1;
            int mul3 = 1;

            //while (list1.Length < 3 )
            //{
            //    foreach(char c in list1)
            //    {
            //        sum1 += int.Parse(c.ToString());
            //    }
            //    Console.WriteLine(sum1);
            //}

            //foreach (char c in list1)
            //{
            //    sum1 += int.Parse(c.ToString());
            //}
            //Console.WriteLine(sum1);

            if (list1.Length > 1)
            {
                foreach (char c in list1)
                {
                    mul1 *= int.Parse(c.ToString());
                }
                if (mul1 > 9)
                {
                    string list2 = mul1.ToString();

                    foreach (char c in list2)
                    {
                        mul2 *= int.Parse(c.ToString());
                    }
                    if (mul2 > 9)
                    {
                        string list3 = mul2.ToString();

                        foreach (char c in list3)
                        {
                            mul3 *= int.Parse(c.ToString());
                        }
                        Console.WriteLine(mul3);
                    }
                    else
                    {
                        Console.WriteLine(mul2);
                    }
                    //Console.WriteLine(mul2);
                }
                else
                {
                    Console.WriteLine(mul1);
                }
            }

            //throw new NotImplementedException();
            if (mul1 > 9)
            {
                return mul2;
            }
            else if (mul2 > 9)
            {
                return mul3;
            }
            else
            {
                return mul1;
            }
            //throw new NotImplementedException();
            // AMEND YOUR CODE ABOVE THIS LINE
        }

    }
}