// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int rows = 3;
int columns = 4;
 
int [,] GetArray (int m, int n)
{
    var result = new int [m, n];
    for (int i = 0; i < m; m++)
    {
        for (int j = 0; j < n; n++ )
        {
          result [i, j] = new Random().Next(100);
        }
    }
 
    return result;
}

bool Contains (int[,] arr, int element){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
            if (arr[i, j] == element){
                return true;
            }
        }
       }
       return false;
}

double[] GetAverragePerColumn(int[,] arr){
    var result = new double [arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++){
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++){
            sum += arr[i, j];
        }
        result[i] = Math.Round(sum / arr.GetLength(0), 2);
    }
    return result;
}

void PrintArray (double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
         Console.Write($"{arr[i, j]} ");
        }
    System.Console.WriteLine();
    }
}

foreach (var item in GetAverragePerColumn(GetArray(rows, columns)))
{
    System.Console.WriteLine(item);
}

