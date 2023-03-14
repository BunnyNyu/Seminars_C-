// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//индексы        0  1  2  3  4
int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 6, 7 };
int n1 = array1.Length;
int n2 = array2.Length;
int find = new Random().Next(1, 8);
Console.Write($"День недели номер {find} выходной?: ");

int index1 = 0;
int index2 = 0;

while (index1 < n1 || index2 < n2 )
{
    if(array1[index1] == find)
    {
        int result1 = index1;
        Console.WriteLine(result1);
        index1++;
        break;
    }
    else if(array2[index2] == find)
    {
        int result2 = index2;
        Console.WriteLine(result2);
        index2++;
    }
}
