using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain = "y";

            while (runAgain != "n")
            {
                Console.Write("Please enter a number between 1 and 100: ");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                //if userInput is even
                if (userInput >= 1 && userInput <= 100)
                {
                    if (userInput % 2 == 0)
                    {
                        if (userInput >= 2 && userInput <= 25)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        if (userInput >= 26 && userInput <= 60)
                        {
                            Console.WriteLine("Even");
                        }
                        if (userInput > 60)
                        {
                            Console.WriteLine($"{userInput} and even");
                        }
                    }
                    else
                    {
                        if (userInput > 60)
                        {
                            Console.WriteLine("odd and greater than 60");
                        }
                        else
                        {
                            Console.WriteLine($"{userInput}, Odd.");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input was not between 1 and 100");
                    Console.ResetColor();
                }

                Console.WriteLine("Run Again?(y/n)");
                runAgain = Console.ReadLine();
            } 
        }
    }
}
