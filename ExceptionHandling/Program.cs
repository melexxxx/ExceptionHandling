using System;
using System.Threading;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 124;
            double num2 = 1255;
            double num3 = 67455;
            double num4 = 6643;
            double num5 = 9465;
            double num6 = 344;

            Console.WriteLine("Hello, this program will divide below numbers by the number provided by YOU!");
            Thread.Sleep(2000);
            Console.WriteLine($"Numbers : \n{num1}, \n{num2}, \n{num3}, \n{num4}, \n{num5}, \n{num6}");
            Thread.Sleep(1000);

            double divisor = 0;

            // Loop until a valid divisor is provided
            while (true)
            {
                Console.WriteLine("Provide a number to divide all numbers at the same time!");

                try
                {
                    divisor = Convert.ToDouble(Console.ReadLine());

                    // Check if the divisor is zero
                    if (divisor == 0)
                    {
                        Console.WriteLine("Nice Try! If I try to divide by 0 the universe will end!");
                        continue; // Continue to the next iteration of the loop
                    }
                    else
                    {
                        Console.WriteLine("Dividing.");
                        Thread.Sleep(300);
                        Console.WriteLine("Dividing..");
                        Thread.Sleep(300);
                        Console.WriteLine("Dividing...");
                        Thread.Sleep(300);
                        Console.WriteLine("Beep Boop, Your answer is:");
                        Thread.Sleep(1000);
                        Console.WriteLine($"{num1} / {divisor} = {num1 / divisor}");
                        Console.WriteLine($"{num2} / {divisor} = {num2 / divisor}");
                        Console.WriteLine($"{num3} / {divisor} = {num3 / divisor}");
                        Console.WriteLine($"{num4} / {divisor} = {num4 / divisor}");
                        Console.WriteLine($"{num5} / {divisor} = {num5 / divisor}");
                        Console.WriteLine($"{num6} / {divisor} = {num6 / divisor}");
                        break; // Exit the loop as a valid divisor is provided
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("This is not a number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong, Try again.");
                }
            }

            Console.ReadLine();
        }
    }
}
