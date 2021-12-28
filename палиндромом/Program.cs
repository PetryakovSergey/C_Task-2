Console.WriteLine("Введите пятизначное число ");
int x = int.Parse(Console.ReadLine()??"0");
int ost1 = x /10 % 10;
int ost2 = x % 10;
int first_number = x / 10000;
int second_number = x / 1000 % 10;
if ((ost1 == second_number) & (ost2 == first_number))
{
    Console.WriteLine("Число является палиндромом ");   
}

else
{
    Console.WriteLine("Число не является палиндромом ");
}