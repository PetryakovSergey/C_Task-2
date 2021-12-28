Console.WriteLine("Введите координаты векторов ");
Console.WriteLine("Координаты вектора 1 " );
double x1 = int.Parse(Console.ReadLine()??"0");
double y1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Координаты вектора 2 " );
double x2 = int.Parse(Console.ReadLine()??"0");
double y2 = int.Parse(Console.ReadLine()??"0");
double d = Math.Sqrt((x1-x2) * 2) + ((y1 - y2) * 2);
Console.WriteLine("Расстояние = " + d);