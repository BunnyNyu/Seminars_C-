// Написать программу, которая выводит случайное 3-значное число и удаляет вторую цифру этого числа:
//456 -> 46
//782 -> 72
//918 -> 98

Console.Clear();

int num = new Random().Next(100, 1000);
Console.Write($"Число: {num}");

int firstValue = num / 100; //определяем первое число путем целочисленного деления
int secondValue = num % 10; //опеределяем третье число число путем деления на остаток

int result = firstValue * 10 + secondValue;
Console.Write($" ==>> {result}");