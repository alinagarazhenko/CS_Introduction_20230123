// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a,b;
System.Console.Write("Введите а:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());

int max;
if (a>b)
{
    max=a;
}
else 
{
    max=b;
}
System.Console.WriteLine($"max={max}");


