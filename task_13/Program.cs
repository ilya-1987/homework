// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int GetThirdDigit (int number){
    int result = 0;
if (number < 0 )
{
    number = number * (-1);
}
if (number < 100)
{
    Console.Write("Третьей цифры нет ");
    return 0; 
}
else if ( number > 99 && number < 999)
{
result = number % 10;
}
   
else
  while (number > 999)
{
    number /= 10;
    result = number % 10;
}
Console.Write("Третья цифра: ");
return result;  
}

int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetThirdDigit(a));