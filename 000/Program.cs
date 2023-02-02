// C клавиатуры вводится 2 числа. Найти и вывести на экран их сумму
// string s;
int a,b,sum;
System.Console.Write("Введите а:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1 Конкатенация (склеивания) строк
System.Console.WriteLine(a+"+"+b+"="+sum);
//2 Форматированный вывод
System.Console.WriteLine("{0}+{1}={2}",a,b,sum);
//3 Интерполяция строк
System.Console.WriteLine($"{a}+{b}={sum}");


