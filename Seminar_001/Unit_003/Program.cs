﻿//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

int N = int.Parse(Console.ReadLine());
int B = -N;
while (B <= N)
{
    Console.WriteLine($"{B} ");
    B++;
}