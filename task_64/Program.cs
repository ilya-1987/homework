// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine ("Введи целое положительное число ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
else
{
    Console.WriteLine($"Все натуральные числа в промежутке от {m} до {n}");
    Console.Write(NaturalNumber(n, m));
}


int NaturalNumber(int n, int m)
{
    if (n == m)
    return n;
    else
    Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}