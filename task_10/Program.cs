Console.Write("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
}
int result = (number / 10) % 10;
Console.WriteLine($"Вторая цифра числа {result}");
