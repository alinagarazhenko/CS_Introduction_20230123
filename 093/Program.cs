// Задача 93: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
//а) простым поэлементным перемножением

int[,] firstArray=Random2DArray(7,7);
Print2DArray(firstArray);
Console.WriteLine();

int[,] secondArray=Random2DArray(7,7);
Print2DArray(secondArray);
Console.WriteLine();

int[,] aArray=new int[firstArray.GetLength(0),secondArray.GetLength(1)];
for(int i=0;i<aArray.GetLength(0);i++)
{
    for(int j=0;j<aArray.GetLength(1);j++)
    {
		for (int k=0;k<secondArray.GetLength(1);k++)
		{
        	aArray[i,j]+=firstArray[i,k]*secondArray[k,j];
		}
		System.Console.Write($"{aArray[i,j]} ");
    }
    System.Console.WriteLine();
}




void Print2DArray(int[,] arr)
{
	for(int i=0;i<arr.GetLength(0);i++)
	{
		for(int j=0;j<arr.GetLength(1);j++)
		{
			Console.Write($"{arr[i,j]} ");
		}
		Console.WriteLine();
	}
}


int[,] Random2DArray(int row,int col)
{
    int[,] array2D=new int[row,col];
    Random rand=new Random();
    for(int i=0;i<row;i++)
    {
        for(int j=0; j<col;j++)
            array2D[i,j]=rand.Next(1,10);			
    }
    return array2D;
}