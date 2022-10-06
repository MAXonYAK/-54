// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? string.Empty);

int[,] array = GetArray(row, columns, 0, 9);
PrintArray(array);

Console.WriteLine();

StringFromTheArray(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minVaiue, int maxVaiue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minVaiue, maxVaiue +1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}


void StringFromTheArray (int[,] arr)
{
    for(int y = 0; y < arr.GetLength(0); y++)
    {
        int c = arr.GetLength(1);
        int[] newArray = new int[c];
        for(int x = 0; x < arr.GetLength(1); x++)
        {
        newArray[x] = arr[y,x];
        }
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            int[] new1 = SelectionSort(newArray);
            arr[y, j] = new1[j];
       }
    }
}

int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length ; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;

        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
