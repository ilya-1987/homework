// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int number){                             //Функция нахождения суммы цифр числа
 

    int sum =0;
    while (number > 0){
        sum += number % 10;
        number /= 10;
    }
return sum;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());          // Число в котором нужно найти сумму всех чисел
  if (num < 9){                                         // Проверка введена цифра или число
   Console.Write("Вы ввели цифру введите число");
 }
else {
  System.Console.Write($"Сумма цифр в числе {num} равна {GetSum(num)}");
 }
