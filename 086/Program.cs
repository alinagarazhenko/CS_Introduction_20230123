﻿// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string str = "Подсчитать сколько раз определенный символ (например 'a') встречается в строке";
System.Console.WriteLine(str);
int k=0;
foreach(char c in str)
{
    if(c=='а') k++;
}
System.Console.WriteLine($"Символ 'a' встречается {k} раз");