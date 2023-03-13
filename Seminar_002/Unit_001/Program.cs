// Написать программу, которая выводит случайное число отрезка [10, 99] и показывает наибольшую цифру этого числа
// 78 -> 8


Console.Clear();

int num = new Random().Next(10, 100);
Console.WriteLine($"Число: {num}");

int firstValue = num / 10; //определяем первое число путем целочисленного деления
int secondValue = num % 10; //опеределяем второе число путем деления на остаток

int max = firstValue;
if (secondValue > max)
{
    max = secondValue;
}

Console.WriteLine($"Максимальная цифра в числе {max}");