// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//индексы       0  1  2  3  4  5  6
int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int n = array.Length;
int find = new Random().Next(1, 8);
Console.Write($"День недели номер {find} выходной?: ");

int index = 0;

while (index < n)
{
    int result = array[index];
    if (array[index] == find)
    {
        if (result < 6)
        {
            Console.Write("net");
        }
        else
        {
            Console.Write("da");  
        }
    }
index++;
}