// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
System.Console.WriteLine("Введите координаты точек двух прямых через пробел:");
string [] stringArray = Console.ReadLine().Split(' ');
 
double b1 =  double.Parse(stringArray[0]);
double k1 =  double.Parse(stringArray[1]);
 
double b2 =  double.Parse(stringArray[2]);
double k2 =  double.Parse(stringArray[3]);
 
double [] GetPoint (double b1, double k1, double b2, double k2){
    double [] result = new double[2];
    result[0] = (b2-b1) / (k1-k2);
    result[1] = k1 * result[0] + b1;
 
    return result;
}
 
System.Console.WriteLine("Координата точки пересечения двух прямых: ");
System.Console.WriteLine(string.Join(" ", GetPoint(b1,k1,b2,k2)));
