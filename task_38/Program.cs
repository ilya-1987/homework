// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

double [] GetDoubleArray (int size, int leftRange, int rightRange) // Функция заполнения массива слуцайными вещественными числами
{
    double [] array = new double [size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = rand.Next(leftRange, rightRange+1) / 10.0;
    }
    return array;
}

double DiifMaxMin ( double [] array) // Функция нахождения разницы между минимальным и максимальным элементом массива
{
double res = 0;
double min = array [0];
double max = array [0];
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array [i];
        }
    }
    res = max - min;
    return res;
}

double [] arr = GetDoubleArray (5, 1, 99);

Console.WriteLine(string.Join(" " , arr));
Console.WriteLine($"Разница между минимальным и максимальным элементом массива составляет {DiifMaxMin (arr)}");