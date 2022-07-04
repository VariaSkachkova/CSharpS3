Console.WriteLine("Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.");
Console.WriteLine("Введите координату по оси Х: ");
int x = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите координату по оси Y: ");
int y = Convert.ToInt32 (Console.ReadLine ());

void Task17()
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Эти координаты находятся в первой плоскости");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Эти координаты находятся в четвертой плоскости");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Эти координаты находятся в третьей плоскости");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Эти координаты находятся во второй плоскости");
    }
}
Task17 ();