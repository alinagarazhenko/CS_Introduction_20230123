// 35/ Подсчитать сумму цифр в числе. Сделать подпрограмму.


int N=102354;
int sumN=0;
int i=10;

while (N>0)
{
    int counter=N%i;
    sumN=sumN+counter;
    N=N/i;
}

System.Console.WriteLine(sumN);
