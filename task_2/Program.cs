  Console.WriteLine("Введите два числа");
        int numberA = Convert.ToInt32(Console.ReadLine());
        int numberB = Convert.ToInt32(Console.ReadLine());
        if (numberA > numberB)
            { 
            Console.WriteLine($"Число {numberA} большеe, а число {numberB} меньшее");
            }
        else 
        {
               Console.WriteLine($"Число {numberB} большее, а число {numberA} меньшее");
            
        }

