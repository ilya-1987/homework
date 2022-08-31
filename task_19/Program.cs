// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введи пятизначное число: ");
           int num = Convert.ToInt32(Console.ReadLine());
           
           if (num < 9999 | num > 1000000) //Проверка является ли число пятизначным
           {
                Console.Write($"Число {num} не является пятизначным");
           }
           else 
           {
                Console.WriteLine(Palindrome(num));
           }
           
            
                
        string Palindrome(int num) // Функция определения палиндрома
        {       
             
            int numLength = GetLength(num); 
            int[] digits = new int[numLength]; // Инициализируем массив
            for (int i = numLength - 1; i >= 0; i--) {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digits[i] != digits[numLength - i - 1])
                    return "Число не является полиндромом";
            }
            return "Число является полиндромом";
        }
        
        int GetLength(int num) // Функция вычисления длинны массива
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }
