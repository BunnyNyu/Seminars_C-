// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

while (userNum <= 999)
{
    int resultNum = userNum / 10;
}
int result = resultNum;
Console.WriteLine(resultNum);
