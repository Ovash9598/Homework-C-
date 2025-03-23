using System;

public class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Введите свой год рождения:");
        int year = Convert.ToInt32(Console.ReadLine());
        int age = DateTime.Now.Year - year;
        if (age >= 18) { Console.WriteLine("Вы совершеннолетний"); }
        else if (age > 0 && age < 18) { Console.WriteLine("Вы ещё несовершеннолетний"); }
        else { Console.WriteLine("Введите коррекктное значенние"); }
    }
}
