// 54. С клавиатуры вводится число N. 
// Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1

int N=new Random().Next(0, 10);
int[] GetFibonacci(int N)

{
    int a1=1;
    int a2=1;
    int[] fib=new int[N];
    fib[0]=1;
    fib[1]=1;
    for (int i=2; i<N; i++)
    {
        fib[i]=a1+a2;
        a2=a1;
        a1=fib[i];
    }
    return fib;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

PrintArray(GetFibonacci(N));