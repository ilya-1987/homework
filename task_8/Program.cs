 Console.Write("Введите число ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        
    Console.Write($"Все четные числа в диапазоне от 1 до {numberA}: ");
        for (int i = 1; i <= numberA; i++ )
        {
        if (i % 2 == 0)
        {
           Console.Write(i + " ");
        }
        }