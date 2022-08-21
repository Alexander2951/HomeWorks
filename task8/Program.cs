// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number");
double x = Convert.ToDouble(Console.ReadLine());
int i = 1;
while ( i < x)
{
    if(i%2==0) Console.Write(i+", ");
i++;
}
Console.WriteLine();


