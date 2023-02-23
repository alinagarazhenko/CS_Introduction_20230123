// 71. Показать натуральные числа от N до 1, N задано


int N=20;
string a(int i)
{
    if(i<=N) 
        return a(i+1)+$"{i,4}";
            else 
                return String.Empty;
}
Console.WriteLine(a(1));

