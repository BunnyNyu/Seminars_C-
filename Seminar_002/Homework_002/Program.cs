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

while (index1 < n1 && index2 < n2)
{
    if (array1[index1] == find)
    {
        int result1 = index1;
        Console.Write(result1);
    }
    else if (array2[index2] == find);
    {
        int result2 = index2;
        Console.Write(result2);
    }
 index1++;
 index2++;
}


// где-то ошибка...
//индексы       0   1   2  3   4   5   6   7   8
//int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 }; //если имеется два одинаковых искомых элемента
                                                    //то в результате программа покажет оба 
//int n = array.Length;
//int find = 18;

//int index = 0;

//while (index < n)
//{
//    if(array[index] == find)
//    {
//        Console.WriteLine(index);
//        break;  //останавливает процесс поиска при первом найденном соответствии
//    }
//    index++;    //index = index + 1;
//}