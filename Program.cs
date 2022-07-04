void Task17()
{
    Console.WriteLine("Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.");
    Console.WriteLine("Введите координату по оси Х: ");
    int x = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите координату по оси Y: ");
    int y = Convert.ToInt32 (Console.ReadLine ());
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
    else 
    {
        Console.WriteLine ("Точка находится на координатной прямой");
    }
}
//Task17 ();

void Task18()
{
    Console.WriteLine("Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).");
    Console.WriteLine("Введите номер четверти: ");
    int q = Convert.ToInt32 (Console.ReadLine ());
    if (q == 1)
    {
        Console.WriteLine("0 < x < infinity, 0 < y < infinity");
    }
    else if (q == 2)
    {
        Console.WriteLine("infinity < x < 0, 0 < y < infinity");
    }
    else if (q == 3)
    {
        Console.WriteLine("infinity < x < 0, infinity < y < 0");
    }
    else if (q == 4)
    {
        Console.WriteLine("0 < x < infinity, infinity < y < 0");
    }
    else 
    {
        Console.WriteLine ("Неправильно задана четверть");
    }
}
Task18 ();