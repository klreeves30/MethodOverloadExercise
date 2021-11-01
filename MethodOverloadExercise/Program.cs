using System;

namespace MethodOverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the sum");
            Add(5, 8);

            Console.WriteLine("This is the sum");
            Add(4.5m, 6.3m);

            Console.WriteLine("False bool");
            Add(7, 1, false);

            Console.WriteLine("True Bool");
            Add(15, 9, true);

            Console.WriteLine("True Bool");
            Add(0, 1, true);

        }

        public static int Add(int num1, int num2)
        {
            return   num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue)
            {
                
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return sum.ToString();
            }  
        }
        

        
        
        

    }
}
