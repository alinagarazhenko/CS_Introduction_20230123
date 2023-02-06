// Определить количество цифр в числе. Сделать подпрограмму.

// int n=678;
int CounterDigits(int n)
{
    if (n==0) return 1; //пограничный случай
    
    int counter=0;//счетчик
    while(n!=0)
    {
        counter++;
        n/=10; //n=n/10
    }
    return counter;
}

System.Console.WriteLine(CounterDigits(789));