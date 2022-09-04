// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] GetArray (int size = 8){
    int [] arr = new int [size];

    for ( int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10);
    }
return arr;
}

foreach (var item in GetArray()){
    Console.WriteLine(item);
}
