// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число 
//кратным первому. Если число 2 не кратно 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16,4 -> кратно


Console.Clear();

Console.Write("Введите 1 число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int result = secondNum % firstNum;

if(result == 0)
{
    Console.WriteLine($"{secondNum} кратно числу {firstNum}");
}
else
{
    Console.WriteLine($"{secondNum} не кратно числу {firstNum}, остаток {result}");
}