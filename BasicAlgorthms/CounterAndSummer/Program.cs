// Подсчитать количество цифр и сумму цифр

int N=1234;
N=Convert.ToInt32(Console.ReadLine());
int counter=0; //счетчик
int sum=0; //сумматор

while(N!=0)
{
   // counter=counter+1;
   counter++; //увеличение на единицу 1
    int d=N%10;
    // sum=sum+d;
    sum+=d;
    // N=N/10; Ниже аналог записи соращенно
    N/=10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);
