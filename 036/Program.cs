// 36. Написать программу вычисления произведения чисел от 1 до N


int a=1;
int N;
int multiplier=1;

N=System.Convert.ToInt32(Console.ReadLine());
 
for (int i=a; 
         i<=N; 
         i++) 
{
    multiplier*=i;
}
 
System.Console.WriteLine(multiplier);
