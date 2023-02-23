// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] a=new int[N, M];
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=new Random().Next(min, max);
        }
    }
    return a;
}

int[,] New2DArray(int[,] a2)
{
    for (int i=0;i<a2.GetLength(0);i++)
    {
        for (int j=0;j<a2.GetLength(1);j++)
        {
            if (i%2==0 && j%2==0) 
                a2[i,j]*=a2[i,j];
            else a2[i,j]=a2[i,j];
        }
    }
    return a2;
}

void Print2DArray(int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            if (a[i,j]<10) 
            System.Console.Write($"{a[i,j],5}");
            else 
            System.Console.Write($"{a[i,j],5}");
        }
        System.Console.WriteLine();
    }
}

int row=5;
int col=6;
int min=1;
int max=10;

int[,] a = Random2DArray(row, col, min, max);
Print2DArray(a);
System.Console.WriteLine();
System.Console.WriteLine();
int[,] a2 = New2DArray(a);
Print2DArray(a2);