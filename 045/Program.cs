﻿// 45 Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a;
a=new int[8];
Random random=new Random(); 
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();

int ev=0;
int unev=0;
for (int i=0; i<a.Length; i++)
    {
        if (a[i]%2==0) ev++;
        else unev++;
    }
    System.Console.WriteLine($" even {ev}, uneven {unev}");
    


