using System;

public class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Введите первое число:");
        Double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        Double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите операцию (+, -, *, /):");
        char op = Convert.ToChar(Console.ReadLine());
        switch (op)
        {
            case '+':
                Console.WriteLine(num1 + num2);
                break;
            case '-':
                Console.WriteLine(num1 - num2);
                break;
            case '*':
                Console.WriteLine(num1 * num2);
                break;
            case '/':
                if (num2 == 0) { Console.WriteLine("Невозможно поделить на 0"); }
                else { Console.WriteLine(num1 + num2); }
                break;

        }
        
    }
}
