// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

int rows = 3;
int columns = 4;
 
int [,] GetArray (int m, int n){
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

var arr = GetArray(rows, columns);
foreach (var item in arr){
System.Console.WriteLine(item);
}

System.Console.WriteLine(Contains(arr, 23));