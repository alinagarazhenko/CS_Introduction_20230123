// 56 Написать программу копирования массива

int size=8;
int min=1;
int max=50;

int[] origin = GetArray(size, min, max);
PrintArray(origin);
System.Console.WriteLine();
int[] copy = CopyArray(origin);
PrintArray(copy);


int[] GetArray(int size, int min, int max)
{
    int[] arr=new int[size];
    for (int i=0; i<size; i++)
    {
        arr[i]=new Random().Next(min, max+1);
    }
    return arr;
}

int[] CopyArray(int[] origArray)
{
    int[] copy=new int[origArray.Length];
    for (int i=0; i<origArray.Length; i++)
    {
        copy[i]=origArray[i];
    }
    return copy;
}

void PrintArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

