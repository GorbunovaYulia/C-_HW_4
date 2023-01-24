/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int GetUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int[] GetArrayRandom(int end, int length)
{
    int[] arr = new int[length];
    for (int i=0; i <length; i++)
    {
        arr[i] = new Random().Next(0,end+1);
    }
    return arr;
}

void PrintArray (int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i< count-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[count-1]);
    Console.Write("]");
}

int end = GetUserDate("Введите верхний порог значений массива");
int[] array = GetArrayRandom(end, 8);
PrintArray(array);