// 35/ Подсчитать сумму цифр в числе. Сделать подпрограмму.



int N=153501;
int sumN=0;
int a = 10;

while (N>0)
{
    N=N/a;
    int counter=N%a;
    sumN=sumN+counter;
    
}

System.Console.WriteLine(sumN);

