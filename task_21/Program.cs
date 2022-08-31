// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты двух точек в трехмерной системе");
Console.WriteLine("Координыты первой точки: ");
Console.Write("x = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координыты второй точки: ");
Console.Write("x = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Расстояние между двя точками составляет ");
Console.Write(LengthSegment(x1, x2, y1, y2, z1, z2));

    double LengthSegment (int x1, int x2, int y1, int y2, int z1, int z2){
       double L = 0;
        L = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((x2-x1), 2));
        return L; 
}

