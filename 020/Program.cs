// 20. Дано число. Проверить кратно ли оно 7 и 23

int N = 77;

int a = 7;
int b = 23;
string Result = " ";

if (N%a == 0 && N%b == 0) 
     Result = "кратно 7 и 23";
else if (N%a != 0 && N%b != 0) 
     Result = "не кратное 7 и 23";
else if (N%a == 0) 
     Result = $"кратно только {a}";
else Result = $"кратно только {b}";

System.Console.WriteLine($"{N} {Result} ");
