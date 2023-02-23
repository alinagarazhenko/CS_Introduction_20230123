// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами


int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] a=new int[N,M];
    Random random=new Random();
        for (int i=0; i<N; i++)
        {
            for (int j=0;j<M;j++)
            {
                a[i,j]=random.Next(min,max+1);
            }
        }
        return a;
}

void Print2DArray(int[,] a)
{
    for (int i=0; i<a.GetLength(0); i++)
    {
        for (int j=0; j<a.GetLength(1); j++)
        
           System.Console.Write($"{a[i,j],5}");
        System.Console.WriteLine();
    }
}

int N=new Random().Next(3,10);
int M=new Random().Next(5,10);
int min=10;
int max=100;

int[,] a = Random2DArray(N, M, min, max);
Print2DArray(a);
