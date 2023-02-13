// 49 В указанном массиве целых чисел найдите разницу между максимальным и минимальным элементом


int [] a=new int[3];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,100);
    
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();

int max=a[0];
for(int i=1;i<a.Length;i++)
    if (a[i]>max)
    max=a[i];

// for(int i=1;i<a.Length;i++)
//     max=int.Max(a[i], max);

int min=a[0];
for(int i=1;i<a.Length;i++)
    if (a[i]<min)
    min=a[i];

// for(int i=1;i<a.Length;i++)
//     min=int.Min(a[i], min);

System.Console.WriteLine(max);
System.Console.WriteLine(min);
System.Console.WriteLine(max-min);