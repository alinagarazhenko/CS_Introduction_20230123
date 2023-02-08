// 33/ Возведите число А в натуральную степень B используя цикл

int a=9;
int b=2;
int i=1;
int result=a;

while (i<b)
{
    result=result*a;
    i++;
}

System.Console.WriteLine(result);