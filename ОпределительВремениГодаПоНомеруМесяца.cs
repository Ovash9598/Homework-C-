using System;

public class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Введите номер месяца (от 1 до 12):");
        int month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case 1 or 2 or 12:
                Console.WriteLine("Зима");
                break;
            case 3 or 4 or 5:
                Console.WriteLine("Весна");
                break;
            case 6 or 7 or 8:
                Console.WriteLine("Лето");
                break;
            case 9 or 10 or 11:
                Console.WriteLine("Осень");
                break;
            default:
                Console.WriteLine("Месяца с таким номером не существует. Пожалуйста, перезапустите программу и введите номер существующего месяца.");
                break;

        }  
    }
}
