// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Random2DArray(int N, int M, int min, int max)

{
    int[,] a=new int[N, M];
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=new Random().Next(min,max+1);
        }
    }
    return a;
}

int[,] Replace2DArray(int[,] a2)
{
    for (int i= 0;i<a2.GetLength(0);i++)
    {
        for (int j=0;j<a2.GetLength(1);j++)
        {
            if (a2[i,j]%2==0)
                a2[i,j]=a2[i,j]*(-1);
        }
    }
    return a2;
}

void Print2DArray(int[,] a2)
{
    for (int i=0;i<a2.GetLength(0);i++)
    {
        for (int j=0;j<a2.GetLength(1);j++)
        {
            System.Console.Write($"{a2[i,j],5}");
        }
        System.Console.WriteLine();
    }
}

int row=3;
int col=4;
int min=1;
int max=100;

int[,] a=Random2DArray(row, col, min, max);
Print2DArray(a);
System.Console.WriteLine();
System.Console.WriteLine();
int[,] a2=Replace2DArray(a);
Print2DArray(a2);