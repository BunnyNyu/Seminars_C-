// Написать программу, которая выводит случайное 3-значное число и удаляет вторую цифру этого числа:
//456 -> 46
//782 -> 72
//918 -> 98

Console.Clear();

int num = new Random().Next(100, 1000);
Console.Write($"Число: {num}");

int firstNum = num / 100; //определяем первое число путем целочисленного деления
int secondNum = num % 10; //опеределяем третье число число путем деления на остаток

//int result = firstNum * 10 + secondNum;
//Console.Write($" ==>> {result}");

//или

Console.Write($" ==>> {firstNum}{secondNum}");