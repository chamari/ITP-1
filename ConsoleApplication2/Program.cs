using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator choices: + - * / min max");
            Console.WriteLine("please enter the operand1");
            string value = Console.ReadLine();
            int operand1 = int.Parse(value);
            Console.WriteLine("please enter the operand2");
            value = Console.ReadLine();
            int operand2 = int.Parse(value);
            Console.WriteLine("please enter the operator now");
            value = Console.ReadLine();

            int answer = 0;

            switch (value)
            {
                case "+":
                    answer = operand1 + operand2;
                    break;
                case "-":
                    answer = operand1 - operand2;
                    break;
                case "*":
                    answer = operand1 * operand2;
                    break;
                case "/":
                    answer = operand1 / operand2;
                    break;
                case "min":
                    answer = Math.Min(operand1, operand2);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break; 
            }


            Console.WriteLine("Answer id " + answer);





            double answer = Math.Sin(1);
















            //for (int i = 0; i < 10; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
        }
    }
}
