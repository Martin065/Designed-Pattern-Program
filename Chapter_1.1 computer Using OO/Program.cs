using System;

namespace Chapter_1._1_computer_Using_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string operandA = "";
                string operandB = "";
                string operatorC = "";
                Console.WriteLine("Please input number (operandA) : ");
                operandA = Console.ReadLine();
                Console.WriteLine("Please input operator(+,-,*,/) : ");
                operatorC = Console.ReadLine();
                Console.WriteLine("Please input number (operandB) : ");
                operandB = Console.ReadLine();

                double result = 0;
                double numberA = Convert.ToDouble(operandA);
                double numberB = Convert.ToDouble(operandB);

                result = Operation.getResult(numberA, numberB, operatorC);

                Console.WriteLine("The result is : " + result.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Your input have problem. Exception message:" + e.Message);
            }

        }
    }

    public class Operation
    {
        public static double getResult(double numberA, double numberB, string operate)
        {
            double result = 0;

            // 需要詢問考題的input範圍，這裡假定要求皆為正數
            if (numberA >= 0 && numberB >= 0)
            {
                switch (operate)
                {
                    case "+":
                        result = numberA + numberB;
                        break;
                    case "-":
                        result = numberA - numberB;
                        break;
                    case "*":
                        result = numberA * numberB;
                        break;
                    case "/":
                        result = numberA / numberB;
                        break;
                }
            }
            return result;
        }
    }
}
