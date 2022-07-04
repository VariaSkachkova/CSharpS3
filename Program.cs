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


void Task21()
{
    Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.");
    Console.WriteLine("Введите первую координату по оси Х: ");
    int x1 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите первую координату по оси Y: ");
    int y1 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите вторую координату по оси Х: ");
    int x2 = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Введите вторую координату по оси Y: ");
    int y2 = Convert.ToInt32 (Console.ReadLine ());
    double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
    Console.WriteLine(result);
    
}
//Task21 ();
void Task22()
{
    Console.WriteLine("Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.");
    Console.WriteLine("Введите целое положительное число: ");
    int num = Convert.ToInt32 (Console.ReadLine ());
    double count = 1;
    while (count <= num)
    {
        double result = Math.Pow(count, 2);
        Console.Write(result + " ");
        count ++;
    }
}
Task22();




