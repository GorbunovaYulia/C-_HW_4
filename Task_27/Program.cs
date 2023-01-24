/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int getSumOfRange(int number)
{
    int result = 0;
    while (number > 10)
    {
        int temp = number % 10;
        number = (number - temp)/10;
        result = result + temp;  
    }
    result = result + number;
    return result;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write(data);
    Console.ResetColor();
}

int number = GetUserDate("Введите число");
int result = getSumOfRange(number);
showData($"Сумма цифр в числе {number} = ", result);