// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов,  стоящих на нечётных позициях.

int [] GetArray (int size, int leftRange, int rightRange) // Функция заполнения массива слуцайными целыми числами
{
    int [] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = rand.Next(leftRange, rightRange+1);
    }
    return array;
}

int SumOfOddElements (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int [] arr = GetArray (12, 100, 999); // Задаем массив из 12 элементов в диапазоне чисел от 100 до 999

Console.WriteLine(string.Join("," , arr));
Console.WriteLine($"Сумма всех нечетных элементов массива равна {SumOfOddElements (arr)}");