// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число и степень в которую нужно возвести число");
int num = Convert.ToInt32(Console.ReadLine()); // Число которое необходимо возвести в степень
int x = Convert.ToInt32(Console.ReadLine()); // Степень в которую необходимо возвести число
int Pow (int number, int rank){        // Функция возводящая число в степень
    if (rank == 0) {
        return 1;
    }

    int result = 1;

for (int i = 0; i < rank; i++){
    result *= number;
}
return result;
}

System.Console.Write($"Число {num} в степени {x} будет равно {Pow(num, x)}");