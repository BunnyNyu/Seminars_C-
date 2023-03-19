// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.




// Вариант 1 - через цикл

Console.Clear();

Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine()); // Parse = Convert.To, но при этом он еще может содержать литералы(пустые значения)

Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
else
{
    Console.WriteLine("x = 0, y = 0, четверть  не определена");
}





// Вариант 2 - через функцию рандом и switch

Console.Clear();

int GetRandomNumber() // Имя функций всегда начинать с глагола
{
    return new Random().Next(-1000, 1000);
}

Console.WriteLine("Координата x: ");
int x = GetRandomNumber();

Console.Write("Координата y: ");
int y = GetRandomNumber();

switch (x, y)
{
    case (x > 0, y > 0):
        Console.WriteLine("1 четверть");
        break;

    case (x < 0, y > 0):
        Console.WriteLine("2 четверть");
        break;

    case (x > 0, y < 0):
        Console.WriteLine("3 четверть");
        break;

    case (x < 0, y < 0):
        Console.WriteLine("4 четверть");
        break;

    default: Console.WriteLine("четверть  не определена");
}



//var e = Math.Pow(x, 2);
//Console.WriteLine(Convert.ToDouble(e));

double e = (double) x; // обертка