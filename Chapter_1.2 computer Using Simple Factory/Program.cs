using System;

namespace Chapter_1._2_computer_Using_Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class OperationFactory 
    {
        public static Operation createOperate(string operate) 
        {
            Operation oper = null;
            switch (operate) 
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    throw new Exception("operate is not define.");
                    break;
            }

            return oper;
        }
    }
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除數不得為零");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
