using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите время:");
        int time = Convert.ToInt32(Console.ReadLine());
        if (time >= 0 && time <=5) { Console.WriteLine("Ночь"); }
        else if (time >= 6 && time <= 11) { Console.WriteLine("Утро"); }
        else if (time >= 12 && time <= 17) { Console.WriteLine("День"); }
        else if (time >= 18 && time <= 23) { Console.WriteLine("Вечер"); }
        else { Console.WriteLine("Введите коррекктное значенние"); }
    }
}
