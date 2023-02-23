// 61 Показать двумерный массив размером m×n заполненный вещественными случайными числами


double[,] Random2DArrayDouble(int M, int N)
{
    double[,] a=new double[M, N];
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=new Random().NextDouble()*10;
        }
    }
    return a;
}

void Print2DArray(double[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            System.Console.Write($"{a[i,j],8:F2}");
        }
        System.Console.WriteLine();
    }
}

int c=8;
int r=4;
double[,] a=Random2DArrayDouble(r, c);
Print2DArray(a);