// //Ввести n от 0 до 10 с проверкой ввода

// {
//     int n; //область видимости переменных
//     //Дот тех пор пока
//     do 
//     {
//     n=Convert.ToInt32(Console.ReadLine());
//     }
//     while(n<0 || n>10); //цикл с постусловием, про?
// }
//Вывести на экран числа от 1 до 10
// int i=1;
// while(i>=10);
// {
//     System.Console.WriteLine(i);
//     //i=i+1
//     i++;
// }
// Цикл ДЛЯ
// int i,k;
// for(i=1, k=100;
//     i<=100 && k>=50;
//     i++, k--)
// {
//     System.Console.WriteLine(i+" "+k);
// }
// for(int i=1; i<100; i++)
// {
//     System.Console.WriteLine(i);
// }

string s="ADCDED";
foreach (char c in s) // работает с коллекциями (реализующими интерфейс IEnumerable) 
{
    System.Console.WriteLine(c);    
} 
