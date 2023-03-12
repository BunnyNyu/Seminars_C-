//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (Math.Pow(number2, 2) == number1)
{
    Console.WriteLine(number1 + " является квадратом числа " + number2);
}
else
{
    Console.WriteLine(number1 + " не является квадратом числа " + number2);
}
