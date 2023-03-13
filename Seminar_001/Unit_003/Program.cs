//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.


Console.Clear();
Console.Write("Введите число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
for (int i = -numberUser; i <= numberUser; i++)
{
    Console.Write(i + ", ");
}
Console.WriteLine();