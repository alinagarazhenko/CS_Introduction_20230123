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
    //System.Console.WriteLine(Counter); //мусорный вывод - подпрограммы ничего не выводят
    return counter;
}

//вывод только в основной подпрограмме
System.Console.WriteLine(CounterDigits(789));