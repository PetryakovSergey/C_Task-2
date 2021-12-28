Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine()??"0");
if (A == B * B) 
{
    Console.WriteLine("Одно из чисел является квадратом другого ");
}
else if (B == A * A)
{
    Console.WriteLine("Одно из чисел является квадратом другого ");
} 
else
Console.WriteLine("Одно из чисел не является квадратом другого ");
