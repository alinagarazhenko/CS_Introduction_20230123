// Задать массив из 8 целых элементов и вывести их на экран

int[] a;
a=new int[8];
Random random=new Random(); //описание и создание объекта
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

