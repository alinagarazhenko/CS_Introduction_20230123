// 51 С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры

int N=7;            
int i=0;

while (N>0)
{
    string num=System.Console.ReadLine();
    int number=System.Convert.ToInt32(num);
    if (number>0) i++;
    N--;
}

System.Console.WriteLine();
System.Console.WriteLine(i);


