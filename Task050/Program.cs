// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int rowPosition = ReadInt("Введите номер строки элемента : ");
int columnPosition = ReadInt("Введите номер колонны элемента : ");
int[,] numbers = new int[10, 10];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if(rowPosition > numbers.GetLength(0) || columnPosition > numbers.GetLength(1))
{
    Console.Write("Элемент отсутствует");
}
else
{
    Console.WriteLine($"Значение {rowPosition} строки и {columnPosition} столбца = {numbers[rowPosition - 1, columnPosition - 1]}");
}


void FillArrayRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}