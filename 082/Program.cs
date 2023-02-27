// 82.C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s = Console.ReadLine();
int k=0;

System.Console.WriteLine();

foreach(char c in s)
{    if(c!='.') k++;
    else break;
}
if(k==s.Length)
    System.Console.WriteLine("Точка отсутствует");
else
    System.Console.WriteLine($"Символов до точки {k}");