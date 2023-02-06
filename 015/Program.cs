// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

// int N=123456;
int N;
    N=Convert.ToInt32(Console.ReadLine());

int counterDigit=0;
int N1=N;
while(N!=0)
{
    counterDigit++;
    N/=10;
}
int d=N1/(int)Math.Pow(10,counterDigit-3)%10;
System.Console.WriteLine(d);
// int d1=N1/(int)Math.Pow(10,counterDigit-1)%10;
// int n2=N1%(int)Math.Pow(10,counterDigit-2);
// System.Console.WriteLine(d1+""+n2);
