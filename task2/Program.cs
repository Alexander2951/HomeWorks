// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int oneNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int tooNumber = Convert.ToInt32(Console.ReadLine());
if (oneNumber < tooNumber) Console.WriteLine(oneNumber +" меньше "+ tooNumber);
if (oneNumber > tooNumber) Console.WriteLine(oneNumber +" больше "+ tooNumber );
if (oneNumber == tooNumber) Console.WriteLine("Опять обманули !!!" );
