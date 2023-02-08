// 34/ Подсчитать сумму цифр в числе. Сделать подпрограмму.



int N=153501;
int sumN=0;

while (N>0)
{
    N=N/10;
    int counter=N%10;
    sumN=sumN+counter;
    
}

System.Console.WriteLine(sumN);

