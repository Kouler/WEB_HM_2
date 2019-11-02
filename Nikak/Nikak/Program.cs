using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int getNum()
        {
            bool t = true;
            int n = 0;
            while (t)
            {
                try
                {
                    t = false;
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    t = true;
                    Console.WriteLine("That,s not a number. please, write it correctly:");
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("Run program?\n");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();

                //Task #1
                Console.WriteLine("task #1");
                Console.WriteLine("Hello, World!\n");

                //task #2;
                Console.WriteLine("task #2, write the operator(+ - / *) and two numbers");
                string chr = Console.ReadLine();
                while (chr != "+" && chr != "-" && chr != "/" && chr != "*")
                {
                    Console.Write("Please, enter correct parameter: ");
                    chr = Console.ReadLine();
                }
                Console.Write("Enter first number: ");
                int a = getNum();
                Console.Write("Enter second number: ");
                int b = getNum();
                string lb = "", rb = "";
                if (b < 0)
                {
                    lb = "(";
                    rb = ")";
                }
                Console.Write("{0} {1} {2}{3}{4} = ", a, chr, lb, b, rb);
                switch (chr)
                {
                    case "+":
                        Console.WriteLine((a + b).ToString());
                        break;
                    case "-":
                        Console.WriteLine((a - b).ToString());
                        break;
                    case "/":
                        if (b != 0) Console.WriteLine(((double)a / (double)b).ToString());
                        else Console.WriteLine("infinity");
                        break;
                    case "*":
                        Console.WriteLine((a * b).ToString());
                        break;
                }
                Console.WriteLine();

                //task #3
                Console.WriteLine("task #3. (length, min, max)");

                Console.Write("Enter array length: ");
                int length = getNum();
                while (length < 1)
                {
                    Console.Write("Only natural number: ");
                    length = getNum();
                }
                Console.Write("Enter min value: ");
                int min = getNum();
                Console.Write("Enter max value: ");
                int max = getNum();

                int[] arr = new int[length];
                Random random = new Random();
                for (int i = 0; i < length; i++)
                {
                    arr[i] = random.Next(min, max + 1);
                    Console.Write(arr[i].ToString() + " ");
                }

                Console.WriteLine('\n');

                //task #4
                Console.WriteLine("task #4, sorting (up or down)");
                string m = Console.ReadLine();
                while (m != "up" && m != "down")
                {
                    if (m == "kaboom") //booboom the program
                    {
                        System.Threading.Thread.Sleep(1000);
                        for (int i = 5; i > 0; i--)
                        {
                            Console.Write(i.ToString() + " ");
                            for (int j = 0; j < 3; j++)
                            {
                                System.Threading.Thread.Sleep(250);
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                        Console.Write("BOOBOOOOOOM");
                        return;
                    }
                    Console.Write("Please, enter correct parameter: ");
                    m = Console.ReadLine();
                }
                Array.Sort(arr);
                if (m == "up")
                {
                    for (int i = 0; i < length; i++)
                        Console.Write(arr[i].ToString() + " ");
                }
                else
                {

                    Array.Reverse(arr);
                    for (int i = 0; i < length; i++) Console.Write(arr[i].ToString() + " ");
                }
                Console.WriteLine("\n");

                //task #5
                Console.WriteLine("task #5\nChoose formula:\n1) First formula,\n2)Second formulal,\n3)Third formulala,\n4)Fourth formulalal.");
                int mode = getNum();
                int x;
                while (mode < 1 || mode > 5)
                {
                    Console.Write("Please, enter correct mode number(1,2,3,4): ");
                    mode = getNum();
                }
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("First formula is y = 3x + 4b.\nEnter x: ");
                        x = getNum();
                        Console.WriteLine("Enter b: ");
                        b = getNum();
                        Console.WriteLine("y = " + (3 * x + 4 * b).ToString() + "\n");
                        break;
                    case 2:
                        Console.WriteLine("Second formulal is y = ((x^2)*cos(z))/7 + tg(z)/sqrt(7).\nEnter x: ");
                        x = getNum();
                        Console.WriteLine("Enter z: ");
                        b = getNum();
                        Console.WriteLine("y = " + (((x * x) * Math.Cos(b)) / 7 + Math.Tan(b) / Math.Sqrt(7)).ToString() + "\n");
                        break;
                    case 3:
                        Console.WriteLine("Third formulala is y =( tg(2x) * tg(x) )/( a^2 + b^2 + 13 ).\nEnter x: ");
                        x = getNum();
                        Console.WriteLine("Enter a: ");
                        a = getNum();
                        Console.WriteLine("Enter b: ");
                        b = getNum();
                        Console.WriteLine("y = " + ((Math.Tan(2 * x) * Math.Tan(x)) / (a * a + b * b + 13)).ToString() + "\n");
                        break;
                    case 4:
                        Console.WriteLine("Fours formulalal is y = sin(x) * tg(sin(cos(x^2))).\nEnter x: ");
                        x = getNum();
                        Console.WriteLine("y = " + (Math.Sin(x) * Math.Tan(Math.Sin(Math.Cos(x * x)))).ToString() + "\n");
                        break;
                    default:
                        Console.WriteLine("How did you get here?!!\nOk let's continue without it...");
                        break;
                }

                //task #6
                Console.WriteLine("\nAnd the Last task, #6. Enter your string: ");
                string str = Console.ReadLine();
                string strange_word = "";
                bool is_word = false;
                char c;
                int w_count = 0, c_count = 0;
                double num;
                for (int i = 0; i < str.Length; i++)
                {
                    c = str[i];

                    if (((int)c >= 97 && (int)c <= 122) || ((int)c >= 65 && (int)c <= 90))
                    {
                        if (!is_word)
                        {
                            w_count++;
                            is_word = true;
                        }
                    }
                    else
                    {
                        if (i - 1 >= 0 && is_word)
                        {
                            strange_word += str[i - 1];
                        }
                        is_word = false;
                    }

                    if (c != ' ')
                    {
                        c_count++;
                    }
                }

                if ((((int)str[str.Length - 1] >= 97 && (int)str[str.Length - 1] <= 122) || ((int)str[str.Length - 1] >= 65 && (int)str[str.Length - 1] <= 90)))
                {
                    strange_word += str[str.Length - 1];
                }

                num = (double)c_count / (double)w_count;

                Console.WriteLine("Words count: " + w_count.ToString() + ";");
                Console.WriteLine("Chars count without spacebars: " + c_count.ToString() + ";");
                Console.WriteLine("Attitude the chars count to words count: {0:0.00};", num);
                if (w_count == 0)
                {
                    Console.WriteLine("Author: Yeah, I have checked the infinity of this number,\nbut float wrote 'infinity' by itself;)");
                }
                Console.WriteLine("The word constructed from the lasts letters of each word: '" + strange_word + "'.");

            }
            else
            {
                //Just for tests.
                Console.Clear();
                Console.WriteLine("It's a test window.");
                Console.WriteLine((int)Convert.ToChar("2"));
            }
        }// 97 - 122, 65 - 90
    }
}
