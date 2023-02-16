/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int getDataFronUser(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] getArray(int colLength, int rowLength, int start, int Finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, Finish + 1);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[] SumRow(int[,] array, int row)
{
    int[] sum = new int[row];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum1 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum1 = sum1 + array[i, j];
            sum[i] = sum1;
        }
    }
    return sum;
}
int MinSum(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int IndexMin(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            index = i+1;
        }
    }
    return index;
}
void PrintArray2(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int n = getDataFronUser("Введите количествуо строк = ");
int m = getDataFronUser("Введите количествуо столбцов = ");
int[,] array = getArray(n, m, 0, 10);
Console.WriteLine();
printArray(array);
Console.WriteLine();
int[] summa = SumRow(array, n);
int minsumma = MinSum(summa);
int ind = IndexMin(summa);
PrintArray2(summa);
Console.WriteLine($"строка {ind} с наименьшей суммой элементов = {minsumma}");