using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите свой возраст:");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18) { Console.WriteLine("Вы совершеннолетний"); }
        else if (age > 0 && age < 18) { Console.WriteLine("Вы ещё несовершеннолетний"); }
        else { Console.WriteLine("Введите коррекктное значенние"); }
    }
}