// 35/ Подсчитать сумму цифр в числе. Сделать подпрограмму.


int N=102354;
int sumN=0;


while (N>0)
{
    int counter=N%10;
    sumN=sumN+counter;
    N=N/10;
}

System.Console.WriteLine(sumN);
