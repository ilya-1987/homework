Console.WriteLine("Введите число: ");

int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA%2 == 0)
{
    Console.WriteLine($"Число {numberA} чётное");
}
else
{
    Console.WriteLine($"Число {numberA} нечётное");
}
