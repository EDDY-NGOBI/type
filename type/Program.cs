using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace type
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("press q to quit and 1 to continue:");
                string input = Console.ReadLine();

                while (input != "q")
                {
                    Console.Write("please enter the first number: ");
                    string number1 = Console.ReadLine();
                    Console.Write("please enter the operator : ");
                    string op = Console.ReadLine();
                    Console.Write("please enter the second number : ");
                    string number2 = Console.ReadLine();
                    int num1 = Convert.ToInt32(number1);
                    int num2 = Convert.ToInt32(number2);
                    if (op == "+")
                    {
                        Console.WriteLine(num1 + num2);
                        Console.ReadLine();
                    }
                    else if (op == "-")
                    {
                        Console.WriteLine(num1 - num2);
                        Console.ReadLine();
                    }
                    else if (op == "*")
                    {
                        Console.WriteLine(num1 * num2);
                        Console.ReadLine();
                    }
                    else if (op == "/")
                    {
                        Console.WriteLine(num1 / num2);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("invalid operation");
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}