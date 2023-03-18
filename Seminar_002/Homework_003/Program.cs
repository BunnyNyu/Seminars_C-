// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

while (userNum > 999)
{
    int firstNum = userNum / 10;
    userNum = firstNum;
}
if (userNum > 99)
{
    int secondNum = userNum % 10;
    Console.Write(secondNum);
}
else
{
    Console.Write("Третьего числа нет");
}

