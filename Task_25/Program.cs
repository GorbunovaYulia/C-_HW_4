/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int getStepen(int FN, int SN)
{
    int result = 1;
    int i = 1;
    while (i <= SN)
    {
        result = result * FN;
        i++;
    }
    return result;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(data);
    Console.ResetColor();
}

int FN = GetUserDate("Введите первое число");
int SN = GetUserDate("Введите второе число");
int result = getStepen(FN, SN);
showData($"Число {FN} в степени {SN} = ", result);