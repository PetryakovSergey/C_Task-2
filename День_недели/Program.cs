int i = new Random().Next(1, 8);
Console.WriteLine("День недели " + i);
if (i > 5) 
{
    Console.WriteLine("Выходной день");
}
else
Console.WriteLine("Рабочий день недели");