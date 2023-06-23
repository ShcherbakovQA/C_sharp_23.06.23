/* Напишите программу которая принимает на вход два числа 
и проверяет является ли первое число квадратом второго*/
Console.WriteLine("Введите первое число!");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число!");
int b = Convert.ToInt32(Console.ReadLine());

if (b*b == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Первое число не является квадратом второго");
}

