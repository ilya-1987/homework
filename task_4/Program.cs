Console.WriteLine("Введите три числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int max;
if (numberA > numberB)
{
    max = numberA;
}
else if (numberB > numberC)
{
    max = numberB;
}
else
{
    max = numberC;
}

Console.WriteLine($"Число {max} максимальное из введенных чисел");