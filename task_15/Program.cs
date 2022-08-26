// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write ("Введите номер дня недели: ");
string GetDayWeek(int number)
{
    if (number < 1 | number > 7 )
    {
        return "Введено не коректное число.";
    }
    else 
    
        if (number > 5)
        {
            return "Выходной день";    
        }
               
    
    else
        {
       return "Рабочий день";
        }
        
}

int day = Convert.ToInt32(Console.ReadLine());
System.Console.Write(GetDayWeek(day));