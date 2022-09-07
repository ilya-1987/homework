// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

int [] GetArray (int size, int leftRange, int rightRange)
{
    int [] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = rand.Next(leftRange, rightRange+1);
    }
    return array;
}
   
int GetEventCout (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int [] arr = GetArray (12, 100, 999);

Console.WriteLine(string.Join("," , arr));
Console.WriteLine($"Количество четных элементов массива равно {GetEventCout (arr)}");