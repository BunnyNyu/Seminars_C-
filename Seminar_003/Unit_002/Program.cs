// Напишите программу, которая по заднному номеру четверти показывает диапазон
// возможных координат точек в этой четверти (x и y).




// Вариант 1 - через if/else
Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()); // Parse = Convert.To, но при этом он еще может содержать литералы(пустые значения)

if (quarter == 1)
    Console.WriteLine("x > 0, y > 0");
else if (quarter == 2)
    Console.WriteLine("x < 0, y > 0");
else if (quarter == 3)
    Console.WriteLine("x > 0, y < 0");
else if (quarter == 4)
    Console.WriteLine("x < 0, y < 0");
else
    Console.WriteLine("четверть  не определена");




// Вариант 2 - через switch
Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
switch (quarter)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;

    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;

    case 3:
        Console.WriteLine("x > 0, y < 0");
        break;

    case 4:
        Console.WriteLine("x < 0, y < 0");
        break;

    default: Console.WriteLine("четверть  не определена");
}


//case 1