
void Swap(int x, int y)
{
    int t=x;
    x=y;
    y=t;
}

int a=4;
int b=5;
System.Console.WriteLine($"a={a} b={b}");
//Стандартный классический обмен
int t;
t=a;
a=b;
b=t;
// Другой вариант алгоритма
// a=a+b;
// b=a-b;
// a=a-b;

System.Console.WriteLine($"a={a} b={b}");
