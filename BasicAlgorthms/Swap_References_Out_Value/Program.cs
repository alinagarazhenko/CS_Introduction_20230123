
void Swap(int x, int y)
{
    int t=x;
    x=y;
    y=t;
}

void Calculator(int a, int b, out int sum, out int sub)  // вернуть множество значений
{
sum = a+b;
sub = a-b;
}

int a=4;
int b=5;
int s, sb;

Calculator(a,b, out s, out sb);



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
