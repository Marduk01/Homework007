// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = ReadInt("Введите количество строк : ");
int columns = ReadInt("Введите количество столбцов : ");
int[,] numbers = new int[rows, columns];

FillArrayRandomNumbers(numbers);
PrintArrayNumbers(numbers);

double sum = 0;
double result = 0;

for (int j = 0; j < numbers.GetLength(1); j++)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = sum + numbers[i, j];
    }
    result = sum / numbers.GetLength(1);
    result = Math.Round(result, 2);
    Console.Write(result + "; ");
    result = 0;
    sum = 0;
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}