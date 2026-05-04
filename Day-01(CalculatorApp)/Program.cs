using System;

    static double Calculate(double n1, double n2, string op)
    {
        double result = 0;
        switch (op)
        {
            case "+":
                result = n1 + n2;
                break;
            case "-":
                result = n1 - n2;
                break;
            case "*":
                result = n1 * n2;
                break;
            case "/":
                if (n2 != 0)
                    result = n1 / n2;
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            case "%":
                if (n2 != 0)
                    result = n1 % n2;
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            case "++":
                result = n1 + 1; // Increment first number
                break;
            case "--":
                result = n1 - 1; // Decrement first number
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("---CALCULATOR APP---");

        Console.WriteLine("Enter first number:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operator (" +
            "Addition: +, " +
            "Subtraction: -, " +
            "Multiplication: *, " +
            "Division: /, " +
            "Modulus: %, " +
            "Increment: ++, " +
            "Decrement: --" +
            "):");

        string op = Console.ReadLine();

        double result = Calculate(n1, n2, op);
        Console.WriteLine("Result: " + result);
    }
