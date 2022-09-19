// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputInt("Введите первое натуральное число: ");
int n = InputInt("Введите второе натуральное число: ");
if (m < 1 | n < 1 )
{
    Console.WriteLine("Вы ввели не натуральные числа.");
}
else
{
    Console.WriteLine($"Сумма всех натуральных чисел в промежутке от {m} до {n} равна {CountNaturalSum(m, n)}");
}


int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
    return n;
    return n + CountNaturalSum(m, n - 1);
}