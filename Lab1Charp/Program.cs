// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Lab1
{
    static void task1()
    {
        //double a = 0, b = 0;
        Console.Write("Enter side A: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double a))
        {
            Console.Write("Enter side B: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out double b))
            {
                double c = Math.Sqrt(a * a + b * b);
                double p = a + b + c;
                //Console.WriteLine($"c = {c}");
                Console.WriteLine($"Perimeter of the triangle is: {p}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void task2()
    {
        Console.Write("Enter a 2-digit number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int num) && num >= 10 && num <= 99)
        {
            int digit_1 = num % 10;
            int digit_2 = num / 10;

            Console.WriteLine($"First digit equals second digit: {digit_1 == digit_2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid 2-digit number.");
        }
    }

    static void task3()
    {
        double circleRadius = 25;

        Console.Write("Enter the x-coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double circleY = -Math.Abs(x);

        Console.Write("Enter the y-coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Print the result based on the conditions
        if (y < circleY && y > -circleRadius)
        {
            Console.WriteLine("Yes");
        }
        else if (y == -circleRadius || y == circleY)
        {
            Console.WriteLine("On the border");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static string GetMonthName(int month)
    {
        return new DateTime(2022, month, 1).ToString("MMMM");
    }

    static void task4()
    {
        Console.Write("Enter the number of months (m > 0): ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m > 0)
        {
            DateTime currentDate = DateTime.Now;
            DateTime targetDate = currentDate.AddMonths(-m);

            int month = targetDate.Month;
            string monthName = GetMonthName(month);

            Console.WriteLine($"The month {m} months ago was: {monthName}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number of months (m > 0).");
        }
    }

    static void task5()
    {
        Console.Write("Enter first number(a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number(b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write($"a / b = {a / b}");
    }

    static void task6()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = (a / (a * a + 1)) + (b / (b * b + 1));

        Console.WriteLine($"Result: {result}");
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //task1();
        //task2();
        //task3();
        //task4();
        //task5();
        task6();
    }
}
