// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого. 
// 5, 25 -> да
// -4, 16 -> да 
// 25, 5 -> да 
// 8,9 -> нет

Console.Clear();

Console.Write("Введите 1 число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(firstNum, 2) == secondNum || Math.Pow(secondNum, 2) == firstNum)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

