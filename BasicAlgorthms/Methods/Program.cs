// Напишите подпрограмму нахождения расстояния между двумя точками

//тип Название(аргументы)

//метод, функция
double Distance(double x1,double у1,double x2,double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
}


//процедуры - С# -нет  (методы которые ничего не возвращают, или функция которая возвращает "ничто")
void Pause()
{
    Console.ReadKey();
}

double x1=0,y1=0,x2=2,y2=2;

// double distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));

double distance=Distance(0,0,2,2);
System.Console.WriteLine(distance);

Pause ();
