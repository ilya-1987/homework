int [] GetArrayFromString (string stringArray){  // Функция организации массива
    string [] nums = stringArray.Split(' ');
    int [] result = new int [nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = Convert.ToInt32(nums[i]);
    }
    return result;
}
 
int CountPositiveNumbers(int [] arr){ // Функция проверки количества положительных чисел в массиве
    int count = 0;
    foreach (var item in arr)
    {
        if (item > 0){
            count++;
        }
    }
    return count;
}
 
System.Console.WriteLine("Введите числа через пробел: ");
int [] numbers = GetArrayFromString(Console.ReadLine());
System.Console.WriteLine($"Количество положительных чисел в массиве: {CountPositiveNumbers(numbers)}");